using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class LayUIController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
