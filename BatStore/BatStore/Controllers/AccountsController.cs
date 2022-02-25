using BatStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using BatStore.Extention;
using BatStore.Helper;
using BatStore.ModelView;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BatStore.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {

        private readonly dbBatStoreContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(dbBatStoreContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [Route("my-account.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    var lsdonhang = _context.Orders.AsNoTracking().Include(x => x.TransactStatus)
                    .Where(x => x.CustomerId == khachhang.CustomerId).OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.lsDonhang = lsdonhang;
                    return View(khachhang);
                }

            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("register.html", Name = "Dangky")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("register.html", Name = "Dangky")]
        public async Task<IActionResult> Register(RegisterViewModel taikhoan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer customer = new Customer
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Password = taikhoan.Password.ToMD5(),
                        Active = true,
                        CreateDate = DateTime.Now
                    };
                    try
                    {
                        _context.Add(customer);
                        await _context.SaveChangesAsync();
                        HttpContext.Session.SetString("CustomerId", customer.CustomerId.ToString());
                        var taikhoanid = HttpContext.Session.GetString("CustomerId");
                        var claim = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, customer.FullName),
                            new Claim("CustomerId",customer.CustomerId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notyfService.Success("Đăng nhập thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch
                    {
                        return RedirectToAction("Register", "Accounts");
                    }
                }
                else
                {
                    return View(taikhoan);
                }

            }
            catch
            {
                return View(taikhoan);

            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string phone)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == phone.ToLower());
                if (customer != null)
                    return Json(data: "Số điện thoại : " + phone + "đã được sử dụng");
                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string email)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == email.ToLower());
                if (customer != null)
                    return Json(data: "Email : " + email + "đã được sử dụng");
                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("login.html", Name = "Dangnhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
            {

                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login.html", Name = "Dangnhap")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(model.UserName);
                    if (!isEmail) return View(model);

                    var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == model.UserName);
                    if (customer == null)
                        return RedirectToAction("Register");
                    string pass = model.Password.ToMD5();
                    if (customer.Password != pass)
                    {
                        _notyfService.Success("Thông tin đăng nhập không hợp lệ");
                        return View();
                    }
                    if (customer.Active == false)
                    {
                        return RedirectToAction("Thong bao", "Accounts");
                    }

                    HttpContext.Session.SetString("CustomerId", customer.CustomerId.ToString());
                    var taikhoanID = HttpContext.Session.GetString("CustomerId");
                    var claim = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, customer.FullName),
                            new Claim("CustomerId",customer.CustomerId.ToString())
                        };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Login Success");
                    return RedirectToAction("Dashboard", "Accounts");

                }
            }
            catch
            {
                return RedirectToAction("Register", "Accounts");
            }
            return View(model);
        }
        [HttpGet]
        [Route("logout.html", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanid = HttpContext.Session.GetString("CustomerId");
                if (taikhoanid == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var taikhoan = _context.Customers.Find(Convert.ToInt32(taikhoanid));
                    if (taikhoan == null) return RedirectToAction("Login", "Accounts");
                    var pass = model.PasswordNow.Trim().ToMD5();
                    if (pass == taikhoan.Password)
                    {
                        string newpass = (model.Password.Trim().ToMD5());
                        taikhoan.Password = newpass;
                        _context.Update(taikhoan);

                        _context.SaveChanges();
                        _notyfService.Success("Đổi mật khẩu thành công ");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notyfService.Success("Đổi mật khẩu thất bại ");
            return RedirectToAction("Dashboard", "Accounts");
        }
    }
}
