using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Layui.HplusRazor.Areas.Common.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        /// <summary>
        /// 登录的用户Id
        /// </summary>
        protected string UserId
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
        }

        /// <summary>
        /// 登录的用户名称
        /// </summary>
        protected string UserName
        {
            get
            {
                return User.Identity.Name;
            }
        }
    }
}
