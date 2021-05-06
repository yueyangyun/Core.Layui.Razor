using Core.Layui.Razor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.IRepository
{
    public interface IMenuRepository
    {
        List<Menus> GetMenus(int pageIndex = 1, int pageSize = int.MaxValue, string name = null);

        Menus GetMenu(int id);

        int Save(Menus entity);
    }
}
