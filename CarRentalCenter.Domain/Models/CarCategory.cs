using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class CarCategory
    {
        [Key] public int ID { get; set; }
        [MaxLength(30), Required]  public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
