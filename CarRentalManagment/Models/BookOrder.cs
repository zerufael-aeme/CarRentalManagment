using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagment.Models
{
    public class BookOrder
    {
        [Key]
        public int bookId { get; set; }
        public int accId { get; set; }
        public int carId { get; set; }
        public DateTime bookDate { get; set; }
        public bool isActive { get; set; }
    }
}
