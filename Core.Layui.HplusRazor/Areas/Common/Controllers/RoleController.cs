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
    public class RoleController : BaseController
    {
        public readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IActionResult List()
        {
            return View();
        }

        public JsonResult GetList(int pageIndex, int pageSize, string name)
        {
            List<Roles> roles = _roleRepository.GetRoles(1, int.MaxValue, name);
            if (roles != null && roles.Count > 0)
            {
                foreach (var item in roles)
                {
                    item.StatusStr = item.Status == Status_Enum.启用.GetHashCode() ? "启用" : "禁用";
                }
            }
            var response = new
            {
                code = 0,
                data = roles,
                msg = "",
                count = roles.Count
            };
            return Json(response);
        }

        public IActionResult Save(string uniqueId)
        {
            Roles role = new Roles();
            if (!string.IsNullOrEmpty(uniqueId))
            {
                role = _roleRepository.GetRole(uniqueId);
            }
            return View(role);
        }

        [HttpPost]
        public IActionResult Save(Roles role)
        {
            role.UpdateTime = DateTime.Now;
            role.UpdateName = UserName;
            if (string.IsNullOrEmpty(role.UniqueId))
            {
                role.CreateTime = DateTime.Now;
                role.CreateName = UserName;
            }
            int count = _roleRepository.Save(role);
            if (count > 0)
            {
                role.SuccessCode = 200;
            }
            return View(role);
        }
    }
}
