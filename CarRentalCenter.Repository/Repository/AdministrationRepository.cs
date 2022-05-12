using CarRentalCenter_EnTFramework.Models;

namespace Repository.Repository
{
    public class AdministrationRepository : BaseRepository<Administration>
    {
        internal AdministrationRepository(CarRentalCentarDbContext context) : base(context)
        {
        }
    }
}
