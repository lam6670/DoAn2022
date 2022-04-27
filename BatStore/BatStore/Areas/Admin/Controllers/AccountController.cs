using AspNetCoreHero.ToastNotification.Abstractions;
using BatStore.Areas.Admin.Models;
using BatStore.Extention;
using BatStore.Helper;
using BatStore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BatStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class AccountController : Controller
    {
        private readonly dbBatStoreContext _context;
        public INotyfService _notifyService { get; }
        public AccountController(dbBatStoreContext context, INotyfService notyfService)
        {
            _context = context;
            _notifyService = notyfService;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "Login")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanId = HttpContext.Session.GetString("AccountId");
            if (taikhoanId != null)
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "Login")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Account kh = _context.Accounts.Include(p => p.Role).SingleOrDefault(p => p.Email.ToLower() == model.Email.ToLower().Trim());

                    if (kh==null)
                    {
                        ViewBag.Error = "Thông tin đăng nhập không hợp lệ";
                        return View(model);
                    }
                    string pass = (model.Password.Trim());
                    if(kh.Password.Trim() !=pass)
                    {
                        ViewBag.Error = "Thông tin đăng nhập không hợp lệ";
                        return View(model);
                    }
                    //Đăng nhập thành công

                    //Cập nhật lần đăng nhập cuối
                    kh.LastLogin = DateTime.Now;
                    _context.Update(kh);
                    await _context.SaveChangesAsync();


                    var taikhoanID = HttpContext.Session.GetString("AccountId");
                    HttpContext.Session.SetString("AccountId", kh.AccountId.ToString());
                    //Identity
                    var userClaim = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, kh.FullName),
                            new Claim(ClaimTypes.Email, kh.Email),
                            new Claim("AccountId", kh.AccountId.ToString()),
                            new Claim("RoleId", kh.RoleId.ToString()),
                            new Claim(ClaimTypes.Role, kh.Role.RoleName),
                        };
                    var grandmaIdentity = new ClaimsIdentity(userClaim, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    await HttpContext.SignInAsync(userPrincipal);

                    //if(Url.IsLocalUrl(returnUrl))
                    //    {
                    //    return Redirect(returnUrl);
                    //}

                    _notifyService.Success("Đăng nhập thành công");
                    return RedirectToAction("Index", "Home",new { Area="Admin"});

                }
            }
            catch
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
            return RedirectToAction("Index", "Home", new { Area = "Admin" });
        }
    }
}
