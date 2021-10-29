using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string locationFrom { get; set; }

        [DataType(DataType.Date)]
        public string locationTo { get; set; }
        public string dateAndTime { get; set; }
        public string typeOfPlane { get; set; }
        public string uniqueFlightNumber { get; set; }
        public int nameOfPlane { get; set; }
        public string capacity_passengers { get; set; }
        public int capacity_businnes_class { get; set; }
		

	}
}