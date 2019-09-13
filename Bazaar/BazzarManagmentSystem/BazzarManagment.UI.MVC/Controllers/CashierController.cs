using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace BazzarManagment.UI.MVC.Controllers
{
    public class CashierController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }

        //protected void HandleUnknownAction(string actionName)
        //{
        //    this.View(actionName).ExecuteResult(this.ControllerContext);
        //}
    }
}