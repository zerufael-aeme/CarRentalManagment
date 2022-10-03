using System;
using System.Collections.Generic;

namespace CarRentalManagment.Models.Services
{
    public interface IRentOrderServices
    {
        public void RentCar(Car car, DateTime returnDate, int accId);
        public List<RentOrder> GetAllOrders();
        public void ReturnCar(Car car,RentOrder ro);
        public List<RentOrder> GetOrderById(int accId);
    }
}
