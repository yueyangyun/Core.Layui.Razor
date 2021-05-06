using Core.Layui.HplusRazor.Kit;
using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Layui.HplusRazor.Controllers
{
    public class LoginController : Controller
    {
        public readonly IUserRepository _userRepository;
        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(int statuCode = 200)
        {
            ViewBag.StatuCode = statuCode;
            return View();
        }

        /// <summary>
        /// 颁发证书
        /// </summary>
        /// <remarks>
        /// <para/>Author   :  Dick
        /// <para/>Date     :  2021-04-28
        /// </remarks>
        /// <returns></returns>
        public async Task<IActionResult> Authenticate(LoginModel login)
        {
            Users user = _userRepository.GetUser(new Users
            {
                Name_Cn = login.UserName,
                Name_En = login.UserName,
                //Password = login.PassWord
            });
            if (user == null)
            {
                return Redirect("/Login/Index?statuCode=404");
            }
            if (string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.PrivateKey))
            {
                return Redirect("/Login/Index?statuCode=500");
            }
            string pwd = new RSAKit().RSADecrypt(user.PrivateKey, user.Password);
            if (!pwd.Equals(login.PassWord))
            {
                return Redirect("/Login/Index?statuCode=500");
            }

            // Dick 2021-04-29 [ 生成个人信息 ]
            var userClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.UniqueId),
                new Claim(ClaimTypes.Name,user.Name_Cn)
            };
            // Dick 2021-04-29 [  ClaimsIdentity，产生了一张证书 ]
            var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
            // Dick 2021-04-29 [ ClaimsPrincipal，管理证书 ]
            var userPrincipa = new ClaimsPrincipal(userIdentity);
            // Dick 2021-04-29 [ 产生证书并且输入到前台Cookie,CookieAuth ]
            await HttpContext.SignInAsync("CookieAuth", userPrincipa,
                new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30), // 半小时有效期
                    IsPersistent = true  // 持久化
                });
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync("CookieAuth");
            return Redirect("/");
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public IActionResult UpdatePassWord()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }

        /// <summary>
        /// 修改密码，不放到用户详情页修改是因为列表选择用户时，可操作其他用户，而非当前用户
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdatePassWord(LoginModel login)
        {
            login.SuccessCode = 200;
            RSAKit rSAKit = new RSAKit();
            Users user = _userRepository.GetUser(new Users
            {
                UniqueId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            });
            if (user == null || string.IsNullOrEmpty(user.Name_Cn))
            {
                login.SuccessCode = 500;
                login.Msg = "登录状态失效，请退出重新登录！";
            }
            if (login.SuccessCode == 200)
            {
                // Dick 2021-04-30 [ 验证历史密码是否正确 ]
                user.Password = rSAKit.RSADecrypt(user.PrivateKey, user.Password);
                if (!user.Password.Equals(login.OldPassWord))
                {
                    login.SuccessCode = 500;
                    login.Msg = "密码错误，操作失败！";
                }
            }
            if (login.SuccessCode == 200)
            {
                // Dick 2021-04-30 [ 验证两次密码输入是否一致 ]
                if (!login.PassWord.Equals(login.VerifyPassword))
                {
                    login.SuccessCode = 500;
                    login.Msg = "两次密码输入不一致，操作失败！";
                }
            }
            if (login.SuccessCode == 200)
            {
                // Dick 2021-04-30 [ 加密密码，Save ]
                string xmlPrivateKey, xmlPublicKey;
                rSAKit.RSAKey(out xmlPrivateKey, out xmlPublicKey);
                string pwd = rSAKit.RSAEncrypt(xmlPublicKey, login.PassWord);
                user.Password = pwd;
                user.PrivateKey = xmlPrivateKey;
                user.UpdateTime = DateTime.Now;
                user.UpdateName = User.Identity.Name;
                _userRepository.UpdatePassWord(user);
            }
            ViewBag.HttpContext = HttpContext;
            return View(login);
        }
    }
}
