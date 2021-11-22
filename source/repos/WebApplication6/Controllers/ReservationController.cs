using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
	public class ReservationController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}

		public IActionResult ProcessReserve(UserReserve flight)
		{
			SecurityService security = new SecurityService();
			if (security.FlightIsRegged(flight))
			{
				return View("ReserveSucess", flight);
			}
			else
			{
				Console.WriteLine("Fuck you");
				return View("Бум");

			}
		}
	}
}
	
