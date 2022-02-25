using BatStore.Models;
using BatStore.ModelView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbBatStoreContext _context;

        public HomeController(ILogger<HomeController> logger, dbBatStoreContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            HomeView model = new HomeView();
            var lsProducts = _context.Products.AsNoTracking().Where(x => x.Active == true)
                .OrderByDescending(x => x.DateCreated).ToList();
            List<ProductHomeView> lsProductViews = new List<ProductHomeView>();

            var lsCats = _context.Categories.AsNoTracking().Where(x => x.Published == true)
                .OrderByDescending(x => x.CatId).ToList();

            foreach(var item in lsCats)
            {
                ProductHomeView productHome = new ProductHomeView();
                productHome.category = item;
                productHome.lsProducts = lsProducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);
            }
            model.Products = lsProductViews;
            ViewBag.AllProducts = lsProducts;
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
