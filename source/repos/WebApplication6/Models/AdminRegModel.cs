using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class AdminRegModel
    {
        public int ID { get; set; }
        public string username { get; set; }

        [DataType(DataType.Date)]
        public string password { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int EGN { get; set; }
        public string addres { get; set; }
        public int phone { get; set; }
        public string role { get; set; }
		

	}
}