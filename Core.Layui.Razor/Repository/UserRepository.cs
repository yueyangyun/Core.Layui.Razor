using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using static Core.Layui.Razor.Model.Users;

namespace Core.Layui.Razor.Repository
{
    public class UserRepository : IUserRepository
    {
        string _conn;
        public UserRepository(string conn)
        {
            _conn = conn;
        }

        public List<Users> GetUsers(int pageIndex, int pageSize, string name)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (!string.IsNullOrEmpty(name))
                {
                    sql = string.Format(SQL_QUERY + " AND Name_Cn LIKE '%{0}%' OR Name_En LIKE '%{0}%'", name);
                }
                var result = connection.Query<Users>(sql)?.ToList();
                return result;
            }
        }

        public Users GetUser(Users user)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (!string.IsNullOrEmpty(user.UniqueId))
                {
                    sql += string.Format(" AND UniqueId='{0}'", user.UniqueId);
                }
                if (!string.IsNullOrEmpty(user.Password))
                {
                    sql += string.Format(" AND Password='{0}'", user.Password);
                }
                if (!string.IsNullOrEmpty(user.Name_Cn))
                {
                    sql += string.Format(" AND Name_Cn='{0}'", user.Name_Cn);
                }
                if (!string.IsNullOrEmpty(user.Name_En))
                {
                    if (!string.IsNullOrEmpty(user.Name_Cn))
                    {
                        sql += string.Format(" OR Name_En='{0}'", user.Name_En);
                    }
                    else
                    {
                        sql += string.Format(" AND Name_En='{0}'", user.Name_En);
                    }
                }
                var result = connection.QueryFirstOrDefault<Users>(sql);
                return result;
            }
        }

        public bool Save(Users entity)
        {
            int result;
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();

                string sql = string.Format("SELECT * FROM Users WHERE Name_Cn='{0}'", entity.Name_Cn);
                if (!string.IsNullOrEmpty(entity.Name_En))
                {
                    sql += string.Format(" AND Name_En='{0}'", entity.Name_En);
                }
                int count = connection.Execute(sql);
                if (count > 0)
                {
                    return false;
                }

                if (!string.IsNullOrEmpty(entity.UniqueId))
                {
                    result = connection.Execute(SQL_UPDATE, entity);
                }
                else
                {

                    entity.UniqueId = Guid.NewGuid().ToString("N");
                    result = connection.Execute(SQL_INSERT, entity);
                }
                return result > 0 ? true : false;
            }
        }

        public bool UpdatePassWord(Users entity)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = "UPDATE Users SET Password=@Password,PrivateKey=@PrivateKey,UpdateTime=@UpdateTime,UpdateName=@UpdateName WHERE 0=0  AND UniqueId=@UniqueId";
                int result = connection.Execute(sql, entity);
                return result > 0 ? true : false;
            }
        }

        public static IEnumerable<T> GetPageList<T>(IDbConnection _connection, Page page, out int totalCount)
        {
            int skip = 1;
            if (page.PageIndex > 0)
            {
                skip = (page.PageIndex - 1) * page.PageSize + 1;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT COUNT(1) FROM {0} where {1};", page.TableName, page.Where);
            sb.AppendFormat(@"SELECT  {0}
                                FROM(SELECT ROW_NUMBER() OVER(ORDER BY {3}) AS RowNum,{0}
                                          FROM  {1}
                                          WHERE {2}
                                        ) AS result
                                WHERE  RowNum >= {4}   AND RowNum <= {5}
                                ORDER BY {3}", page.Fields.ToString(), page.TableName,
                                page.Where, page.Orderby, skip, page.PageIndex * page.PageSize);
            using (var reader = _connection.QueryMultiple(sb.ToString()))
            {
                totalCount = reader.ReadFirst<int>();
                return reader.Read<T>();
            }
        }
    }
}
