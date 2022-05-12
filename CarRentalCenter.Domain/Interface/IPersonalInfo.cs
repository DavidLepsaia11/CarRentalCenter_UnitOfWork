using CarRentalCenter_EnTFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter_EnTFramework.Interface
{
    public interface IPersonalInfo
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        GenderType Gender { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
    }
}
