using CarRentalManagment.Models;
using CarRentalManagment.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalManagment.Controllers
{
    public class BookOrderController : Controller
    {
        IBookOrderServices _services;
        IRentOrderServices _rentServices;
        ICarServices _carServices;
        public BookOrderController(IBookOrderServices services, IRentOrderServices rentServices, ICarServices carServices)
        {
            _services = services;
            _rentServices = rentServices;
            _carServices= carServices;
        }

        public IActionResult GetAllBookOrders()
        {
            
            return View(_services.GetAllBookOrders());
        }
        public IActionResult RentBookOrder(int id)
        {
            BookOrder bo = _services.GetBookOrder(id);
            _services.RentBookOrder(bo);
            return RedirectToAction("GetAllBookOrders");
        }
        public IActionResult UnBookOrder(int id)
        {
            _services.UnBookOrder(id);
            return RedirectToAction("GetAllBookOrders");
        }
    }
}
