using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mozgva.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mozgva.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LichnKab()
        {
            return View();
        }
    }
}
