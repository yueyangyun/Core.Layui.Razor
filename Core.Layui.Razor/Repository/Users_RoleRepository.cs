using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Layui.Razor.Model.Users_Role;

namespace Core.Layui.Razor.Repository
{
    public class Users_RoleRepository : IUsers_RoleRepository
    {
        string _conn;
        public Users_RoleRepository(string conn)
        {
            _conn = conn;
        }

        public List<Users_Role> GetUsers_Role(int pageIndex, int pageSize,
            string userName, string role_UniqueId)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = string.Format(@"SELECT r.Name 'RoleName',u.Name_Cn 'UserName_Cn',u.Name_En 'UserName_En',u.Status 'UserStatusStr'
FROM Users_Role ur LEFT JOIN Roles r ON ur.Role_UniqueId = r.UniqueId
LEFT JOIN Users u ON ur.User_UniqueId = u.UniqueId
WHERE ur.Role_UniqueId = '{0}'", role_UniqueId);
                if (!string.IsNullOrEmpty(userName))
                {
                    sql += string.Format(" AND(u.Name_Cn LIKE '%{0}%' OR u.Name_En LIKE '%{0}%')", userName);
                }
                var result = connection.Query<Users_Role>(sql)?.ToList();
                return result;
            }
        }
    }
}
