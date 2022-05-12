using CarRentalCenter_EnTFramework.Enums;
using CarRentalCenter_EnTFramework.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Models
{
    public abstract class Employee : IPersonalInfo
    {
        [Key]  public int ID { get; set; }
        [MaxLength(30), Required]  public string FirstName { get; set; }
        [MaxLength(30), Required] public string LastName { get; set; }
        [Required] public GenderType Gender { get; set; }
        [MaxLength(9), Required] public string PhoneNumber { get; set; }
        [MaxLength(35)] public string Email { get; set; }
        [MaxLength(50)] public string Address { get; set; }
        [Required, Column(TypeName = "Date")] public DateTime? BirthDate { get; set; }
    }
}
