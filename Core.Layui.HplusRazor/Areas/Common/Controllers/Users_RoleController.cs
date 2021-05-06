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
    public class Users_RoleController : Controller
    {
        public readonly IUsers_RoleRepository _users_RoleRepository;
        public Users_RoleController(IUsers_RoleRepository users_RoleRepository)
        {
            _users_RoleRepository = users_RoleRepository;
        }

        public IActionResult List(string role_uniqueId)
        {
            ViewBag.Role_UniqueId = role_uniqueId;
            return View();
        }

        public JsonResult GetList(int pageIndex, int pageSize, string userName, string role_UniqueId)
        {
            List<Users_Role> users_Role = _users_RoleRepository.GetUsers_Role(1, int.MaxValue,
                userName, role_UniqueId);

            var response = new
            {
                code = 0,
                data = users_Role,
                msg = "",
                count = users_Role.Count
            };
            return Json(response);
        }
    }
}
