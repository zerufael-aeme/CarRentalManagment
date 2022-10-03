
using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagment.Models
{
    public class RentOrder
    {
        [Key]
        public int orderId { get; set; }
        public int carId { get; set; }
        public int accountId { get; set; }
        public bool isActive { get; set; }
        public DateTime? rentDate { get; set; }
        public DateTime? returnDate { get; set; }
    }
}
