using Microsoft.AspNetCore.Mvc;
using CarRentalManagment.Models;
using CarRentalManagment.Models.Services;
using System.Collections.Generic;
using System;

namespace CarRentalManagment.Controllers
{
    public class AccountController : Controller
    {
        IAccountServices _services;
        ICarServices _carServices;
        IBookOrderServices _bookServices;
        IRentOrderServices _rentServices;
        public static int logId;
        public static int bookCarId;
        public AccountController(IAccountServices services, ICarServices carServices, IBookOrderServices bookServices, IRentOrderServices rentServices)
        {
            _services = services;
            _carServices = carServices;
            _bookServices = bookServices;
            _rentServices = rentServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id, string password)
        {
            if(password == null)
            {
                ViewBag.error = "Enter the required fields";
                return View();
            }
            int result = _services.CheckCredentials(id, password);
           
            if(result == 0)
            {
                ViewBag.error = "No account with Id: "+id+" found";
                return View();
            }
            else if(result == -1)
            {
                ViewBag.error = "Password incorrect";
                return View();
            }
            else if(result == 1)
            {
                logId = id;
                return RedirectToAction("About");
            }
            else
            {
                ViewBag.error = "Error occured while trying to login";
                return View(); ;
            }
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View(account);
            }
            _services.AddAccount(account);
            return RedirectToAction("Index");
        }
        public IActionResult Home()
        {
            Account account = _services.GetAccount(logId);
            List<BookOrder> bo = _bookServices.GetAllBookOrders();
            foreach(var book in bo)
            {
                
                if ((logId == book.accId) && (book.isActive==true)) {
                    return RedirectToAction("AlreadyBooked");
                }else if (account.activeOrder == true)
                    return RedirectToAction("AlreadyBooked");
            }
            List<Car> cars=_carServices.GetAllCars();
            List<Car> availCars=new List<Car>();
            foreach(var car in cars)
            {
                if((car.isRented == false) && (car.isBooked == false))
                {
                    availCars.Add(car);
                }
            }
            
            
            return View(availCars);
        }
        public IActionResult AlreadyBooked()
        {
            
            return View();
        }
         public IActionResult BookCar(int id)
        {
            Car car = _carServices.GetCarById(id);
            bookCarId = id;
            return View(car);
        }
        [HttpPost]
        public IActionResult BookCar( DateTime returnDate)
        {

            _bookServices.BookCar(bookCarId, logId, returnDate);
            return RedirectToAction("Home");
        }
        public IActionResult ShowRentHistory()
        {
            return View(_rentServices.GetOrderById(logId));
        }
        public IActionResult UnBookOrder()
        {
            _bookServices.UnBookOrder(logId);
            return RedirectToAction("Home");
        }
        
       public IActionResult About()
        {
            return View();
        }
    }
}
