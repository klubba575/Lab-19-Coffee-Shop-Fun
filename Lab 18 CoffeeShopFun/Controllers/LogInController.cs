using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_18_CoffeeShopFun.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab_18_CoffeeShopFun.Controllers
{
    public class LogInController : Controller
    {
		public IActionResult Index(RegisterUser newUser)
		{
			PopulateFromSession();
			return View(newUser);
		}
		public IActionResult AddUser(RegisterUser newUser)
		{
			PopulateFromSession();
			HttpContext.Session.SetString("NewUserSession", JsonConvert.SerializeObject("newUser"));
			return RedirectToAction("Index");
		}
		public IActionResult RegisterSummary(RegisterUser newUser)
		{
			if (!ModelState.IsValid)
			{
				return RedirectToAction("Index", newUser);
			}
			return View(newUser);
		}
		public RegisterUser PopulateFromSession()
		{
			string userJson = HttpContext.Session.GetString("NewUserSession");
			if (userJson != null)
			{
				RegisterUser returningUser = (RegisterUser)JsonConvert.DeserializeObject(userJson);
				return returningUser;
			}
			return PopulateFromSession();
		}
	}
}