using System;
using System.Collections.Generic;

namespace CarRentalManagment.Models.Services
{
    public interface IBookOrderServices
    {
        public void BookCar(int carId, int accId, DateTime returnDate);
        public List<BookOrder> GetAllBookOrders();
        public BookOrder GetBookOrder(int id);
        public void RentBookOrder(BookOrder bo);
        public void UnBookOrder(int id);
    }
}
