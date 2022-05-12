using Repository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCenter.Repository.Repository
{
    public class UnitOfWork : IDisposable
    {
        private CarRentalCentarDbContext _context;

        private Lazy<AdministrationRepository> _AdministrationRepository;
        private Lazy<CarCategoryRepository> _carCategoryRepository;
        private Lazy<CarRepository> _carRepository;
        private Lazy<ClientRepository> _clientRepository;
        private Lazy<DriverRepository> _driverRepository;
        private Lazy<DriverServiceRepository> _driverServiceRepository;
        private Lazy<EmployeeRepository> _employeeRepository;
        private Lazy<OrderRepository> _orderRepository;
        private Lazy<TechnicianRepository> _technicianRepository;

        public UnitOfWork()
        {
            _context = new CarRentalCentarDbContext();

            _AdministrationRepository = new (()=> new AdministrationRepository(_context));
            _carCategoryRepository = new(() => new CarCategoryRepository(_context));
            _carRepository = new(() => new CarRepository(_context));
            _clientRepository = new (()=> new ClientRepository(_context));
            _driverRepository = new (()=> new DriverRepository(_context));
            _driverServiceRepository = new(() => new DriverServiceRepository(_context));
            _employeeRepository = new(()=> new EmployeeRepository(_context));
            _orderRepository = new(()=> new OrderRepository(_context));
            _technicianRepository = new(() => new TechnicianRepository(_context));
        }

        public AdministrationRepository AdministrationRepository => _AdministrationRepository.Value;
        public CarCategoryRepository CarCategoryRepository => _carCategoryRepository.Value;
        public CarRepository CarRepository => _carRepository.Value;
        public ClientRepository ClientRepository => _clientRepository.Value;
        public DriverRepository DriverRepository => _driverRepository.Value;
        public EmployeeRepository EmployeeRepository => _employeeRepository.Value;
        public OrderRepository OrderRepository => _orderRepository.Value;
        public TechnicianRepository TechnicianRepository => _technicianRepository.Value;


        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // ლოგირება
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
