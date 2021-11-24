using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication6.Models;
using Microsoft.Data.SqlClient;
namespace WebApplication6.Controllers
{
    public class AdminViewController : Controller
    {
        private List<AdminView> adminViews = new List<AdminView>();
        private int _nextId = 1;
        public ActionResult Index()

        {

            string _connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Flights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string _querry = "select * from dbo.Flights";
            


                return View(adminViews);

            }

        }

    }