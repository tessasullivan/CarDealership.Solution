using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
        List<Car> allCars = Car.GetAll();
        return View(allCars);
    }
    [HttpGet("/cars/new")]
    public ActionResult form()
    {
        return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
        Car myCar = new Car(makeModel, price, miles);
        return RedirectToAction("Index");
    }
    // public ActionResult Create(string description)
    // {
    //     Item myItem = new Item(description);
    //     return RedirectToAction("Index");
    // }
  }
}