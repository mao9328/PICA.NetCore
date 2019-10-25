using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Filters;
using Taller1.Models;

namespace Taller1.Controllers
{
	[CustomExceptionFilter]
	public class CustomerController : Controller
	{
		// GET: Customer
		public ActionResult Index()
		{
			return View();
		}

		// GET: Customer/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		[CustomAuthFilter]
		// GET: Customer/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Customer/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Customer model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}

		// GET: Customer/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Customer/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Customer/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Customer/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}