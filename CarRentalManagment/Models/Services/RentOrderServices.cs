using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalManagment.Models;

namespace CarRentalManagment.Models.Services
{
    public class RentOrderServices : IRentOrderServices
    {
        CarManagementDbContext _context;
        public RentOrderServices(CarManagementDbContext context)
        {
            _context=context;
        }
        public void RentCar(Car car, DateTime returnDate, int accId)
        {
            RentOrder ro=new RentOrder();
            ro.carId = car.carId;
            ro.accountId = accId;
            ro.returnDate= returnDate;
            ro.rentDate = DateTime.Now;
            ro.isActive = true;
            Account account = _context.Accounts.Find(accId);
            account.activeOrder = true;
            _context.Accounts.Update(account);
            Car rcar=_context.Cars.Find(car.carId);
            rcar.isRented = true;
            rcar.isBooked = false;
            _context.Cars.Update (rcar);
            _context.RentOrders.Add(ro);
            _context.SaveChanges();
        }
        public List<RentOrder> GetAllOrders()
        {
            return _context.RentOrders.ToList();
        }
        public void ReturnCar(Car car,RentOrder ro)
        {
            Account account = _context.Accounts.Find(ro.accountId);
            account.activeOrder = false;
            _context.Accounts.Update(account);
            Car rcar = _context.Cars.Find(car.carId);
            car.isRented = false;
            car.isBooked = false;
            rcar = car;
            _context.Cars.Update(rcar);
            ro = _context.RentOrders.Find(ro.orderId);
            ro.isActive=false;
            ro.returnDate = DateTime.Now;            
            _context.RentOrders.Update(ro);
            _context.SaveChanges();
        }

        public List<RentOrder> GetOrderById(int accId)
        {
            return _context.RentOrders.Where(o => o.accountId == accId).ToList(); 
        }
    }
}
