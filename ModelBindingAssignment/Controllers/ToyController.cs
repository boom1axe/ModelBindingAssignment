using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModelBindingAssignment.Controllers
{
    public class ToyController : Controller
    {
        [HttpGet]
        public IActionResult Catalog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Catalog(IFormCollection data)
        {
            Toy t = new Toy()
        }
    }
}