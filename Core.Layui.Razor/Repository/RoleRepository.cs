using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Core.Layui.Razor.Model.Roles;

namespace Core.Layui.Razor.Repository
{
    public class RoleRepository : IRoleRepository
    {
        string _conn;
        public RoleRepository(string conn)
        {
            _conn = conn;
        }

        public Roles GetRole(string uniqueId)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (!string.IsNullOrEmpty(uniqueId))
                {
                    sql = string.Format(SQL_QUERY + " AND UniqueId='{0}'", uniqueId);
                }
                var result = connection.QueryFirstOrDefault<Roles>(sql);
                return result;
            }
        }

        public List<Roles> GetRoles(int pageIndex, int pageSize, string name)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (!string.IsNullOrEmpty(name))
                {
                    sql = string.Format(SQL_QUERY + " AND Name LIKE '%{0}%'", name);
                }
                var result = connection.Query<Roles>(SQL_QUERY)?.ToList();
                return result;
            }
        }

        public int Save(Roles entity)
        {
            int result;
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                if (!string.IsNullOrEmpty(entity.UniqueId))
                {
                    result = connection.Execute(SQL_UPDATE, entity);
                }
                else
                {
                    entity.UniqueId = Guid.NewGuid().ToString("N");
                    result = connection.Execute(SQL_INSERT, entity);
                }
                return result;
            }
        }

    }
}
