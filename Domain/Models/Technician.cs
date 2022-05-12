using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public class Technician : Employee
    {
        [MaxLength(250), Required] public string Qualification { get; set; }
        [MaxLength(250), Required] public string Experience { get; set; }

        public int CArCategoryID { get; set; }
        [Required] public CarCategory ResponsibleForCarCategory { get; set; }
    }
}
