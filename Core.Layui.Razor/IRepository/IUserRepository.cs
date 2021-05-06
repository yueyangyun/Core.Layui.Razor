using Core.Layui.Razor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.IRepository
{
    public interface IUserRepository
    {
        List<Users> GetUsers(int pageIndex = 1, int pageSize = int.MaxValue, string name = null);

        Users GetUser(Users user);

        bool Save(Users entity);

        bool UpdatePassWord(Users entity);
    }
}
