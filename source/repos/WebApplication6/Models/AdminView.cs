
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
	public class AdminView
	{
		public int Id { get; set; }
		public string first_name { get; set; }
		public string second_name { get; set; }
		public string family_name { get; set; }
		public string type { get; set; }
		public DateTime date_landing { get; set; }
		public DateTime date_leaving { get; set; }
		public string dateLanding { get; set; }
		public string dateLeaving { get; set; }
		public List<AdminView> userinfo = new List<AdminView>();
	}
}