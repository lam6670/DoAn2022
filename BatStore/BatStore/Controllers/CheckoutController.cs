using AspNetCoreHero.ToastNotification.Abstractions;
using BatStore.Extention;
using BatStore.Helper;
using BatStore.Models;
using BatStore.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly dbBatStoreContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(dbBatStoreContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("Cart");
                if(gh == default(List<CartItem>))
                    {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }


        [Route ("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrk = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
            var IdTaikhoan = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if(IdTaikhoan != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(IdTaikhoan));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

            }
            //ViewData["lsTinhThanh"]
            ViewBag.GioHang = cart;
            return View(model);
        }

        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
            var IdTaikhoan = HttpContext.Session.GetString("CustomerId");
            MuaHangVM model = new MuaHangVM();
            if (IdTaikhoan != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(IdTaikhoan));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

                khachhang.Address = muaHang.Address;
                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    Order donhang = new Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;
                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);
                    donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(donhang);
                    _context.SaveChanges();


                    foreach(var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderDetailId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Amount = item.amount;
                        orderDetail.TotalMoney = donhang.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);


                    }
                    _context.SaveChanges();
                    HttpContext.Session.Remove("Cart");
                    _notyfService.Success("Đặt hàng thành công");
                    return RedirectToAction("Success");
                }
            }
            catch(Exception ex)
            {
                ViewBag.GioHang = cart;
                return View(model);
            }
            ViewBag.GioHang = cart;
            return View(model);
        }
        [Route("Order-success.html", Name = "Success")]
        public IActionResult Success()
        {
            try
            {
                var IdTaikhoan = HttpContext.Session.GetString("CustomerId");
                if(string.IsNullOrEmpty(IdTaikhoan))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "Order-success.html" });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(IdTaikhoan));
                var donhang = _context.Orders.Where(x => x.CustomerId == Convert.ToInt32(IdTaikhoan)).OrderByDescending(x => x.OrderDate).FirstOrDefault();
               
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = donhang.OrderId;
                successVM.Phone = khachhang.Phone;
                successVM.Address = khachhang.Address;

                return View(successVM);
            }
            catch
            {
                return View();
            }
        }
    }
}
