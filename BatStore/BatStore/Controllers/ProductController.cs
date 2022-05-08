using BatStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbBatStoreContext _context;
        public ProductController(dbBatStoreContext context)
        {
            _context = context;
        }
        [Route("/shop.html", Name = "ShopProduct")]
        public IActionResult Index(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 9;
                var lsTinDangs = _context.Products.AsNoTracking().OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [Route("/{CatID}", Name = "ListProducts")]
        public IActionResult List(string CatID, int page =1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x=>x.CatName == CatID);
                var lsTinDangs = _context.Products.AsNoTracking().Where(x => x.CatId == danhmuc.CatId).OrderByDescending(x => x.DateCreated);
                PagedList<Product> model = new PagedList<Product>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCate = danhmuc;
                return View(model);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [Route("/{Title}-{id}.html", Name ="productDetails")]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products.AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true).OrderBy(x=>x.DateCreated).Take(4).ToList();
                ViewBag.SanPham = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
