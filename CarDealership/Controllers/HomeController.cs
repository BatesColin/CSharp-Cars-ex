using Microsoft.AspNetCore.Mvc;
using CarDealerShip.Models;


namespace CarDealerShip.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Form()
    // {
    //   return View();
    // }
    // [Route("/CarDealerShip")]
    // public ActionResult CarDealerShip()
    // {
    //   return View();
    // }


    [HttpGet("/Cars")]
    public ActionResult CarDealerShip()
    {
      Car newCar = new Car();
      newCar.SetModel(Request.Query["makeModel"]);
      newCar.SetMiles(Request.Query["miles"]);
      newCar.SetColor(Request.Query["color"]);
      newCar.SetPrice(Request.Query["price"]);
      return View(newCar);
    }

    [HttpGet("/")]
    public ActionResult Form()
    {
      return View();
    }


  }
}
