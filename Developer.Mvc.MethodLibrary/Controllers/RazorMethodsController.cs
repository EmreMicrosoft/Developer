using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Developer.Mvc.MethodLibrary.Controllers
{
    public class RazorMethodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult RequestUrlSyntax()
        {
            return View();
        }
    }
}