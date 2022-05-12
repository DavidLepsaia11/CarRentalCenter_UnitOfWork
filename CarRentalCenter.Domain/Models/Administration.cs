using CarRentalCenter_EnTFramework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class Administration : Employee
    {
        [Required] public AdministrationPosition Position { get; set; }

        [MaxLength(250), Required] public string Education { get; set; }

    }
}
