using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_18_CoffeeShopFun.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_18_CoffeeShopFun.Controllers
{
    public class RegistrationController : Controller
    {
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Index(RegisterUser user)
        {
			//Doing stuff here
            return View(user);
        }

		[HttpPost]
		public IActionResult RegisterSummary(RegisterUser user)
		{
			if (!ModelState.IsValid)
			{
				return RedirectToAction("Index", user);
			}
			return View(user);
		}
    }
}