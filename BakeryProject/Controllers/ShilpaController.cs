﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class ShilpaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
