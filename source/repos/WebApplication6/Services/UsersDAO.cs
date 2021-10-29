using Microsoft.Data.SqlClient;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication6.Services
{
	public class UsersDAO
	{

		string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Admin; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public bool findUserByNameAndPass(AdminLogin user)
		{
			Boolean sucess = false;
			string sqlSTatement = "SELECT * FROM dbo.AdminTable Where username = @username AND password = @password";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(sqlSTatement, connection);

				command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.username;
				command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.password;
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						sucess = true;
					}
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return sucess;
		}
		public bool createAdmin(AdminRegModel adminreg)
		{
			Boolean registered = false;
			string _connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			string _query = "INSERT INTO dbo.AdminTable (username,password,email) values (@username,@password,@email)";
			using (SqlConnection conn = new SqlConnection(_connStr))
			{
				using (SqlCommand comm = new SqlCommand())
				{
					
					comm.Connection = conn;
					comm.CommandType = CommandType.Text;
					comm.CommandText = _query;
					comm.Parameters.AddWithValue("@username", adminreg.username);
					comm.Parameters.AddWithValue("@password", adminreg.password);
					comm.Parameters.AddWithValue("@email", adminreg.email);

					try
					{
						conn.Open();
						comm.ExecuteNonQuery();
						registered = true;
						Console.WriteLine("registered");
					}
					catch (SqlException ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine("not registered");

					}
				}
			}
			return registered;
		}

	}
}
