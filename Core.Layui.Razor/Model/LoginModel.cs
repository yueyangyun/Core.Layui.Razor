using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Layui.Razor.Model
{
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name = "请输入新密码")]
        public string PassWord { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        [Display(Name = "请确认新密码")]
        public string VerifyPassword { get; set; }

        /// <summary>
        /// 历史密码
        /// </summary>
        [Display(Name = "请输入密码")]
        public string OldPassWord { get; set; }

        public int SuccessCode { get; set; }

        public string Msg { get; set; }
    }
}
