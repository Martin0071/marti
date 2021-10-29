using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using RazorPagesMovie.Models;


namespace WebApplication6.Services
{
	public class SecurityService
	{
		UsersDAO UsersDAO = new UsersDAO();
		public SecurityService()
		{
			
		}
		public bool isValid(AdminLogin user)
		{
			return UsersDAO.findUserByNameAndPass(user);
		}
		public bool isRegged(AdminRegModel adminreg)
		{
			return UsersDAO.createAdmin(adminreg);
		}

	}
}
