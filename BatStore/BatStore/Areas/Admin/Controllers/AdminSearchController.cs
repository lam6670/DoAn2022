using BatStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSearchController : Controller
    {
        
        private readonly dbBatStoreContext _context;

        public AdminSearchController(dbBatStoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SearchProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if(string.IsNullOrEmpty(keyword) || keyword.Length<1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking().Include(x => x.Cat).Where(y => y.ProductName.Contains(keyword)).OrderByDescending(y => y.ProductName)
                .Take(10).ToList();
            if(ls==null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }
    }
}
