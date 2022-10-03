using CarRentalManagment.Models;
using CarRentalManagment.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalManagment.Controllers
{
    public class AdminController : Controller
    {
        IAccountServices _services;
        public AdminController(IAccountServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id, string password)
        {
            if (!(id == 0) || !(password == "1234"))
            {
                ViewBag.error = "Wrong Credentials";
                return View();
            }
            return RedirectToAction("GetAllAccounts");

        }
        public IActionResult GetAllAccounts()
        {
            var accounts=_services.GetAllAccounts();
            return View(accounts);
        }
        public IActionResult DeleteById(int id)
        {
            int result = _services.DeleteById(id);
            return RedirectToAction("GetAllAccounts");
        }
       public IActionResult GetAllCars()
        {
            return RedirectToAction("GetAllcars","Car");
        }

    }
}
