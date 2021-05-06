using Core.Layui.HplusRazor.Areas.User.Enum;
using Core.Layui.HplusRazor.Kit;
using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Core.Layui.Razor.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.HplusRazor.Areas.Common.Controllers
{
    [Area("Common")]
    public class UserController : BaseController
    {
        public readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult List()
        {
            return View();
        }

        public JsonResult GetList(int pageIndex, int pageSize, string name)
        {
            List<Users> users = _userRepository.GetUsers(1, int.MaxValue, name);
            if (users != null && users.Count > 0)
            {
                foreach (var item in users)
                {
                    item.StatusStr = item.Status == Status_Enum.启用.GetHashCode() ? "启用" : "禁用";
                }
            }
            var response = new
            {
                code = 0,
                data = users,
                msg = "",
                count = users.Count
            };
            return Json(response);
        }

        public IActionResult Save(string uniqueId)
        {
            Users user = new Users();
            if (!string.IsNullOrEmpty(uniqueId))
            {
                user = _userRepository.GetUser(new Users { UniqueId = uniqueId });
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Save(Users user)
        {
            user.UpdateTime = DateTime.Now;
            user.UpdateName = UserName;
            if (string.IsNullOrEmpty(user.UniqueId))
            {
                string xmlPrivateKey, xmlPublicKey;
                RSAKit rSAKit = new RSAKit();
                rSAKit.RSAKey(out xmlPrivateKey, out xmlPublicKey);
                string pwd = rSAKit.RSAEncrypt(xmlPublicKey, user.Password);
                user.Password = pwd;
                user.PrivateKey = xmlPrivateKey;
                user.CreateTime = DateTime.Now;
                user.CreateName = UserName;
            }
            bool isSave = _userRepository.Save(user);
            if (isSave)
            {
                user.SuccessCode = 200;
            }
            return View(user);
        }
    }
}
