using CarRentalCenter_EnTFramework.Models;
using Repository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter.Repository.Repository
{
    public class CarRepository : BaseRepository<Car>
    {
        internal CarRepository(CarRentalCentarDbContext context) : base(context)
        {
        }
    }
}
