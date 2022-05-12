using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class Car
    {
        [Key]  public int ID { get; set; }
        [MaxLength(30), Required]  public string Model { get; set; }
        [MaxLength(20), Required]  public string Brand { get; set; }
        [MaxLength(20)] public string Color { get; set; }
        [MaxLength(10)] public string StateNumber { get; set; }
        [Required] public double RentPrice { get; set; }
        [Column(TypeName = "Date")] public DateTime? ReleaseDate { get; set; }

        public int CategoryID { get; set; }
        [Required]  public CarCategory Category { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<DriverService> DriverService { get; set; }
    }
}
