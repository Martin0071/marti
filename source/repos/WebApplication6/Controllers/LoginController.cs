using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{

			return View();
		}
		public IActionResult ProcessLogin(AdminLogin person)
		{
			SecurityService security = new SecurityService();
			if(security.isValid(person))
			{
				return View("LoginSucess", person);

			}
			else {
				return View("LoginFailure", person);
			}

			
		}

		
	}
}
