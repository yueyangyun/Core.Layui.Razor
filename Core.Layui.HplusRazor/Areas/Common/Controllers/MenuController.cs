using Core.Layui.HplusRazor.Areas.User.Enum;
using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Layui.HplusRazor.Areas.Common.Controllers
{
    [Area("Common")]
    public class MenuController : BaseController
    {
        public readonly IMenuRepository _menuRepository;
        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public IActionResult List()
        {
            return View();
        }

        public JsonResult GetList(int pageIndex, int pageSize, string name)
        {
            List<Menus> menus = _menuRepository.GetMenus(1, int.MaxValue, name);
            if (menus != null && menus.Count > 0)
            {
                foreach (var item in menus)
                {
                    item.LevelStr = item.Level == MenuLevel_Enum.一级菜单.GetHashCode() ? "一级菜单" : "二级菜单";
                    item.StatusStr = item.Status == Status_Enum.启用.GetHashCode() ? "启用" : "禁用";
                }
            }
            var response = new
            {
                code = 0,
                data = menus,
                msg = "",
                count = menus.Count
            };
            return Json(response);
        }

        public IActionResult Save(int id)
        {
            Menus menu = new Menus();
            if (id > 0)
            {
                menu = _menuRepository.GetMenu(id);
            }
            return View(menu);
        }

        [HttpPost]
        public IActionResult Save(Menus menu)
        {
            menu.UpdateTime = DateTime.Now;
            menu.UpdateName = UserName;
            if (menu.Id == 0)
            {
                menu.CreateTime = DateTime.Now;
                menu.CreateName = UserName;
            }
            int count = _menuRepository.Save(menu);
            if (count > 0)
            {
                menu.SuccessCode = 200;
            }
            return View(menu);
        }
    }
}
