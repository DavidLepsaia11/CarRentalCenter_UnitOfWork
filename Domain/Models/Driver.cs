using CarRentalCenter_EnTFramework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
   public class Driver : Employee
    {
        [MaxLength(25), Required] public string DrvingLicenceNumber { get; set; }
        [Required] public DrivingLicenceCategory LicenceCategory { get; set; }

        public ICollection<DriverService> DriverService { get; set; }
    }
}
