using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalManagment.Models.Services
{
    public class BookOrderServices : IBookOrderServices
    {
        CarManagementDbContext _context;
        public BookOrderServices(CarManagementDbContext context)
        {
            _context = context;
        }
        public void BookCar(int carId,int accId , DateTime returnDate)
        {
            BookOrder bookOrder = new BookOrder();
            bookOrder.accId = accId;
            bookOrder.carId=carId;
            bookOrder.bookDate=returnDate;
            bookOrder.isActive = true;
            Car car = _context.Cars.Find(carId);
            car.isBooked=true;
            _context.Cars.Update(car);
            _context.BookOrders.Add(bookOrder);
            Account account = _context.Accounts.Find(accId);
            account.activeOrder = true;
            _context.Accounts.Update(account);
            _context.SaveChanges();
            
        }
        public List<BookOrder> GetAllBookOrders()
        {
            return _context.BookOrders.ToList();
        }
        public BookOrder GetBookOrder(int id)
        {
            return (_context.BookOrders.Find(id));
        }

        public void RentBookOrder(BookOrder bo)
        {
            Account account = _context.Accounts.Find(bo.accId);
            Car car = _context.Cars.Find(bo.carId);
            BookOrder rbo= _context.BookOrders.Find(bo.bookId);
            account.activeOrder = true;
            car.isBooked = false;
            car.isRented = true;
            rbo.isActive = false;
            RentOrder ro = new RentOrder();
            ro.carId = bo.carId;
            ro.accountId = bo.accId;
            ro.isActive = true;
            ro.rentDate = DateTime.Now;
            ro.returnDate = bo.bookDate;
            _context.Accounts.Update(account);
            _context.Cars.Update(car);
            _context.BookOrders.Update(rbo);
            _context.RentOrders.Add(ro);
            _context.SaveChanges();
        }
        public void UnBookOrder(int id)
        {
            Account account = _context.Accounts.Find(id);
            List<BookOrder> allBook = _context.BookOrders.ToList();
            foreach(var order in allBook)
            {
                if((order.accId==id) && (order.isActive == true))
                {
                    _context.BookOrders.Remove(order);
                    Car car = _context.Cars.Find(order.carId);
                    account.activeOrder = false;
                    car.isBooked = false;
                    _context.Accounts.Update(account);
                    _context.Cars.Update(car);

                }
            }
            _context.SaveChanges();
        }
    }
}
