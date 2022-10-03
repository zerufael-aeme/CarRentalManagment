using System.Collections.Generic;
using System.Linq;

namespace CarRentalManagment.Models.Services
{
    public class CarServices : ICarServices
    {
        CarManagementDbContext _context;
        public CarServices(CarManagementDbContext context)
        {
            _context = context;
        }
        public void AddCar(Car car)
        {
            car.isRented = false;
            car.isBooked = false;
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public List<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        

        public Car GetCarById(int id)
        {
            return _context.Cars.Find(id);
        }

        public int RemoveCar(int id)
        {
            Car car = _context.Cars.Find(id);
            if ((car.isRented==true) || (car.isBooked == true))
            {
                return -1;
            }
            else
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
                return 1;
            }
            
        }
        
    }
}
