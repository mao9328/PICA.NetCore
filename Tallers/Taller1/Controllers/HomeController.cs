using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Models;

namespace Taller1.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(Login model)
		{
			if (ModelState.IsValid)
			{
				HttpContext.Session.SetString("Autenticated", "True");

				return RedirectToAction("Create", "Customer");
			}
			else
			{
				return View();
			}
		}


		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
