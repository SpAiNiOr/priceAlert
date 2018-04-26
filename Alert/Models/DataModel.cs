using System;
using System.ComponentModel.DataAnnotations;

namespace Alert.Models
{
    public class DataModel
    {
        // primary key
        public int id { get; set; }

        public string Price { get; set; }

        [Display(Name = "Logged Date")]
        [DataType(DataType.Date)]
        public DateTime Time { get; set; }
    }
}
