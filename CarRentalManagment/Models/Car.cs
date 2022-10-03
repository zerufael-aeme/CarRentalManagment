using System.ComponentModel.DataAnnotations;

namespace CarRentalManagment.Models
{
    public class Car
    {
        [Key]
        public int carId { get; set; }
        [Required(ErrorMessage ="Catagory is Required")]
        public int catagory { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string name { get; set; }
        [Required(ErrorMessage = "License No is Required")]
        public long licNo { get; set; }
        public bool isRented { get; set; }
        public bool isBooked { get; set; }
    }
}
