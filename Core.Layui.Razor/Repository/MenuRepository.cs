using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Core.Layui.Razor.Model.Menus;

namespace Core.Layui.Razor.Repository
{
    public class MenuRepository : IMenuRepository
    {
        string _conn;
        public MenuRepository(string conn)
        {
            _conn = conn;
        }

        public List<Menus> GetMenus(int pageIndex, int pageSize, string name)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (!string.IsNullOrEmpty(name))
                {
                    sql = string.Format(SQL_QUERY + " AND Name LIKE '%{0}%'", name);
                }
                var result = connection.Query<Menus>(sql)?.ToList();
                return result;
            }
        }

        public Menus GetMenu(int id)
        {
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                string sql = SQL_QUERY;
                if (id > 0)
                {
                    sql = string.Format(SQL_QUERY + " AND Id={0}", id);
                }
                var result = connection.QueryFirstOrDefault<Menus>(sql);
                return result;
            }
        }

        public int Save(Menus entity)
        {
            int result;
            using (var connection = new SqlConnection(_conn))
            {
                connection.Open();
                if (entity.Id > 0)
                {
                    result = connection.Execute(SQL_UPDATE, entity);
                }
                else
                {
                    result = connection.Execute(SQL_INSERT, entity);
                }
                return result;
            }
        }
    }
}
