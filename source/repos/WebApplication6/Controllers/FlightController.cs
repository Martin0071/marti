﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
	public class FlightController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}
	}
}
