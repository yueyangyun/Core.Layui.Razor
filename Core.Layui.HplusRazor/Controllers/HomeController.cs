using Core.Layui.HplusRazor.Areas.User.Enum;
using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Layui.HplusRazor.Controllers
{
    public class HomeController : Controller
    {
        public readonly IMenuRepository _menuRepository;
        public HomeController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Index()
        {
            // 左侧菜单
           List<Menus> onelevelMenus = _menuRepository.GetMenus()?.
                Where(t => t.Level == MenuLevel_Enum.一级菜单.GetHashCode() 
                && t.Status == Status_Enum.启用.GetHashCode())?.ToList();
            List<Menus> towlevelMenus = _menuRepository.GetMenus()?.
                Where(t => t.Level == MenuLevel_Enum.二级菜单.GetHashCode()
                && t.Status == Status_Enum.启用.GetHashCode())?.ToList();
            ViewBag.onelevelMenus = onelevelMenus;
            ViewBag.towlevelMenus = towlevelMenus;
            return View();
        }

        public IActionResult Index_Body()
        {
            return View();
        }
    }
}
