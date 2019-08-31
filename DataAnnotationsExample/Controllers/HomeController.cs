using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAnnotationsValidationExample.Models;

namespace DataAnnotationsValidationExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", person);
            }
            return View(person);
        }
    }
}