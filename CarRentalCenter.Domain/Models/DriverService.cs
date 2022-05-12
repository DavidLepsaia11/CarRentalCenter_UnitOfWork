using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class DriverService
    {
        [Key] public int ID { get; set; }
        [Required, Column(TypeName = "Date")] public DateTime? ServiceDate { get; set; }
        public double ServiceDuration { get; set; }
        [Required]  public double ServiceFee { get; set; }

        public int DriverID { get; set; }
        [Required] public Driver Driver { get; set; }

        public int CarID { get; set; }
        [Required] public Car Car { get; set; }
    }
}
