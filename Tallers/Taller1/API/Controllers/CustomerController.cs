using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Models;

namespace Taller1.API.Controllers
{
	[Route("api/[controller]")]
	[Produces("application/json", "application/xml")]
	[ApiController]
	[FormatFilter]
	public class CustomerController : ControllerBase
	{
		// GET: api/Customer
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET: api/Customer/5
		[HttpGet("{id}", Name = "Get")]
		public string Get(int id)
		{
			return "value";
		}

		// POST: api/Customer
		[HttpPost]
		public object Post(Customer model)
		{
			if (ModelState.IsValid)
			{
				return Ok(new { Result = "Melo" });
			}
			else
			{
				return BadRequest(new { Result = "Paila" });
			}
		}

		// PUT: api/Customer/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
