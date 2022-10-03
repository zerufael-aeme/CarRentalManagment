using CarRentalManagment.Models;
using CarRentalManagment.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarRentalManagment.Controllers
{
    public class CarController : Controller
    {
        ICarServices _services;
        public CarController(ICarServices services)
        {
            _services=services;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllCars()
        {
            List<Car> cars = _services.GetAllCars();
            return View(cars);
        }
        public IActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "Enter all required fields";
                return View(car);
            } else if (!(car.licNo.ToString().Length == 6))
            {
                ViewBag.error = "Invalid Licence No";
                return View(car);
            }
            var checkIfExists = _services.GetAllCars();
            foreach(var check in checkIfExists)
            {
                if (car.licNo == check.licNo)
                {
                    ViewBag.error = "A car with License: " + check.licNo + " aleardy exists.";
                    return View(car);
                }
            }
            _services.AddCar(car);
            return RedirectToAction("GetAllCars");
        }
        public IActionResult DeleteById(int id)
        {
            int result = _services.RemoveCar(id);
            if(result == 1)
            {
                return RedirectToAction("GetAllCars");
            }
            else
            {
                return RedirectToAction("GetAllCars");
            }
        }
        
    }
}
