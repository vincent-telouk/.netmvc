using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3MVC.Models;

namespace WebApplication3MVC.Controllers
{
    public class TotoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "TEST TITLE SUPER";
            return View();
        }

        public IActionResult Autre()
        {
            ViewData["Title"] = "TEST Autre SUPER";
            return View("Index");
        }

        public IActionResult Employee()

        {
            Employee emp1 = new()
            {
                nom = "telouk",
                prenom = "Vincent"
            };

            return View(emp1);
        }
    }
}
