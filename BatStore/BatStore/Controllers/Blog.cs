﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatStore.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
