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
using System.Configuration;
using System.IO;
using WebGridMvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Controllers

{

    public class AdminViewController : Controller
    {
        public ActionResult Index(AdminView dr)
        {
            string mainconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Flights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string s1 = "select * from dbo.FlightBase;";
            SqlCommand sqlcomm = new SqlCommand(s1);
            sqlcomm.Connection = sqlconn;
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            List<AdminView> objmodel = new List<AdminView>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    var details = new AdminView();
                    details.first_name = sdr["first_name"].ToString();
                    details.second_name = sdr["second_name"].ToString();
                    details.family_name = sdr["family_name"].ToString();
                    details.type = sdr["type"].ToString();
                    string dateLanding = sdr["date_landing"].ToString();
                    string dateLeaving = sdr["date_leaving"].ToString();
                    details.dateLanding = dateLanding;
                    details.dateLeaving = dateLeaving;
                    objmodel.Add(details);
                }
                dr.userinfo = objmodel;

            }
            return View("Index", dr);
        }
       
        }

    }

 