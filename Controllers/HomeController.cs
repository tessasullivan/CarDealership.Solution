using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public string Hello() { return "Hello friend!"; }

    // public ActionResult Index()
    // {

    //     return View();
    //     // return new EmptyResult();
    // }
  }
}