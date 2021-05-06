using Core.Layui.Razor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.IRepository
{
    public interface IRoleRepository
    {
        List<Roles> GetRoles(int pageIndex, int pageSize, string name);

        Roles GetRole(string uniqueId);

        int Save(Roles entity);
    }
}
