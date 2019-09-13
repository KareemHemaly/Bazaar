using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BazzarManagment.UI.MVC.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}