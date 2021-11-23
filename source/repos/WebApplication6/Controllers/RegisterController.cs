using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
	public class RegisterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ProcessRegister(AdminRegModel adminreg)
		{
			SecurityService security = new SecurityService();
			if (security.isRegged(adminreg)) { 
			return View("RegisterSucess", adminreg);
		}
			else
			{
				return View("RegisterFailure", adminreg);
			}
		}
	}
}
