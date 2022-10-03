using System.Collections.Generic;

namespace CarRentalManagment.Models.Services
{
    public interface ICarServices
    {
        public void AddCar(Car car);
        public int RemoveCar(int id);
        public List<Car> GetAllCars();
        public Car GetCarById(int id);
       
    }
}
