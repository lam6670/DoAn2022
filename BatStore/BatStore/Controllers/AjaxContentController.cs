using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class AjaxContentController : Controller
    {
        public IActionResult HearderCart()
        {
            return ViewComponent("HeaderCart");
        }
        public IActionResult NumberCart()
        {
            return ViewComponent("NumberCart");
        }
    }
}
