using CarRentalManagment.Models;
using CarRentalManagment.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CarRentalManagment.Controllers
{
    public class RentOrderController : Controller
    {

        IRentOrderServices _services;
        IAccountServices _accountServices;
        ICarServices _carServices;
        public static int rentCarId;
        public static int returnCarId;
        public RentOrderController(IRentOrderServices services, IAccountServices accountServices, ICarServices carServices)
        {
            _services = services;
            _accountServices = accountServices;
            _carServices = carServices;
        }
        public IActionResult RentCar(int id)
        {
            rentCarId = id;
            Car car=_carServices.GetCarById(id);
            return View(car);
        }
        [HttpPost]
        public IActionResult RentCar(string accId, DateTime returnDate)
        {
            TimeSpan dif=DateTime.Now - returnDate;
            Car car = _carServices.GetCarById(rentCarId);
            
            if (accId==null || !(int.TryParse(accId.ToString(), out int id)) || returnDate<=DateTime.Now)
            {
                ViewBag.error = "Enter the proper information";
                return View(car);
            }else if(dif.Days > 365)
            {
                ViewBag.error = "Cant rent a car for more than a year";
                return View(car);
            }else if (_accountServices.GetAccount(id) == null)
            {
                ViewBag.error = "No account with ID: " + id;
                return View(car);
            }else if (_accountServices.GetAccount(id).activeOrder == true)
            {
                ViewBag.error = "This account already has an active order at the moment. To rent a new car customer must first close previous order";
                return View(car);
            }
            else
            {
                _services.RentCar(car,returnDate,id);
                return RedirectToAction("GetAllCars", "Admin");
            }
        }
        public IActionResult ReturnCar(int id)
        {
            returnCarId = id;
            Car car=_carServices.GetCarById(id);
            return View(car);
        }
        [HttpPost]
        public IActionResult ReturnCar()
        {
            Car car=_carServices.GetCarById(returnCarId);
            List<RentOrder> ro=_services.GetAllOrders();
            RentOrder r=new RentOrder();
            foreach(var order in ro)
            {
                if (order.isActive == true)
                {
                    if (order.carId == returnCarId)
                    {
                        r = order;
                        _services.ReturnCar(car, r);
                        return RedirectToAction("GetAllCars", "Admin");
                    }

                }           
            }

            
            return View(returnCarId);
        }
        public IActionResult GetOrderById(int id)
        {
            Account account=_accountServices.GetAccount(id);
            ViewBag.acc =account.name+" "+account.fatherName+"`s Order History.        Account Id: "+ id.ToString();
            List<RentOrder> ro = _services.GetOrderById(id);
            List<Car> cars = _carServices.GetAllCars();
            foreach (var order in ro)
            {
                foreach (var car in cars)
                {
                    if (car.carId == order.carId)
                    {
                        order.carId = Convert.ToInt32(car.licNo);
                        break;
                    }
                }
            }
            return View(ro);
        }
        public IActionResult GetAllOrders()
        {
            List<RentOrder> ro = _services.GetAllOrders();
            List<Car> cars = _carServices.GetAllCars();
            foreach(var order in ro)
            {
                foreach(var car in cars)
                {
                    if(car.carId == order.carId)
                    {
                        order.carId = Convert.ToInt32(car.licNo);
                        break;
                    }
                }
            }
            return View(ro);
        }
    }
}
