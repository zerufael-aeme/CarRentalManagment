using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagment.Models

{
    public class Account
    {
        [Key]
        public int accountId { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string password { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "Father`s name is required")]
        public string fatherName { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int age { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public long phone { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string address { get; set; }
        public bool activeOrder { get; set; }
        public string email { get; set; }
      
    }
}
