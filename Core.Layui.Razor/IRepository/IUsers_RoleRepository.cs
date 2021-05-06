using Core.Layui.Razor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.IRepository
{
    public interface IUsers_RoleRepository
    {
        List<Users_Role> GetUsers_Role(int pageIndex, int pageSize,
            string userName, string role_UniqueId);
    }
}
