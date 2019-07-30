using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingAssignment.Models;

namespace ModelBindingAssignment.Controllers
{
    public class ToyController : Controller
    {
        [HttpGet]
        public IActionResult Catalog()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Catalog(Toy t)
        {
            if (ModelState.IsValid)
            {
                ToyDb.Catalog(t);

                ViewData["Success"] = "Toy ready for play";
                return View();
            }

            return View();
        }
    }
}