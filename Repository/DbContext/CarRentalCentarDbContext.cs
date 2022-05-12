using CarRentalCenter_EnTFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class CarRentalCentarDbContext : DbContext
    {
        public DbSet<Administration> Administrations { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverService> DriverServices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Technician> Technicians { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = DESKTOP-TEPR7CC; database = RentalCarCenterEntityFr ; integrated security = true");
        }
    }
}
