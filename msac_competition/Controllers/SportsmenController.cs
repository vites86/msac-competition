﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace msac_competition.Controllers
{
    public class SportsmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}