using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
	public class UserReserve
	{
		public int Id { get; set; }
		public string first_name { get; set; }
		public string second_name { get; set; }
		public string last_name { get; set; }
		public int EGN { get; set; }
		public int phone { get; set; }
		public string nationality { get; set; }
		public string type { get; set; }
		public string location_from { get; set; }
		public string location_to { get; set; }
		public DateTime date_and_time_taking_off { get; set; }
		public DateTime date_and_time_landing { get; set; }
		public string type_of_plane { get; set; }
		public string unique { get; set; }
		public string pilot_name { get; set; }
		public string pass_cap { get; set; }
		public string buss_pass_cap { get; set; }

	}
}