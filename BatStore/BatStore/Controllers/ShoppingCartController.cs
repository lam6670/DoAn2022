using AspNetCoreHero.ToastNotification.Abstractions;
using BatStore.Extention;
using BatStore.Models;
using BatStore.ModelView;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly dbBatStoreContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(dbBatStoreContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> Cart
        {
            get
            {
                var giohang = HttpContext.Session.Get<List<CartItem>>("Cart");
                if (giohang == default(List<CartItem>))
                {
                    giohang = new List<CartItem>();
                }
                return giohang;

            }
        }


        [HttpPost]
        [Route("api/cart/add-to-cart")]
        public IActionResult AddtoCart(int productID, int? amount)
        {
            List<CartItem> gioHang = Cart;
            try
            {
                //Thêm sản phẩm vào giỏ hàng
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)
                {
                        item.amount = item.amount+ amount.Value;
                        HttpContext.Session.Set<List<CartItem>>("Cart", gioHang);
                }
                else
                {
                    Product sanpham = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = sanpham
                    };
                    gioHang.Add(item);

                }

                //Lưu session
                HttpContext.Session.Set<List<CartItem>>("Cart", gioHang);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch(Exception ex)
            {
                _notyfService.Success("Thêm vào giỏ hàng thất bại");
                return Json(new { success = false });
            }

        }

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            //Xử lý giỏ hàng
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null && amount.HasValue)
                    {
                        item.amount = amount.Value;

                    }
                    HttpContext.Session.Set<List<CartItem>>("Cart", cart);
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }

        [HttpPost]
        [Route("api/cart/remove-from-cart")]
        public IActionResult Remove(int productID)
        {
            try
            {
                List<CartItem> gioHang = Cart;
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)
                {
                    gioHang.Remove(item);
                }
                HttpContext.Session.Set<List<CartItem>>("Cart", gioHang);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }


        }

        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
               List<int> lsproducts = new List<int>();
                        var lsgiohang = Cart;
            return View(Cart);
        }
    }
}
