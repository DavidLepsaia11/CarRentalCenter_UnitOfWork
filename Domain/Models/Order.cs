using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class Order
    {
        [Key] public int ID { get; set; }
        [Required, Column(TypeName = "Date")] public DateTime? OrderDate { get; set; }
        public double OrderDuration { get; set; }
        [Required] public Client Client { get; set; }
        [Required] public double ServicePrice { get; set; }


        public int DriverServiceID { get; set; }
        [Required]  public DriverService DriverService { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
