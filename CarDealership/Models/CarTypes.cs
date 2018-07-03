using System.Collections.Generic;
namespace CarDealerShip.Models
{
public class Car
{
  private string _makeModel;
  private string _price;
  private string _miles;
  private string _color;

  // public Car(string makeModel = "", string price = "", string miles = "", string color = "")
  // {
  //   _makeModel = makeModel;
  //   _price = price;
  //   _miles = miles;
  //   _color = color;
  // }

  public void SetModel(string NewMakeModel)
  {
    _makeModel = NewMakeModel;
  }

  public string GetModel()
  {
    return _makeModel;
  }

  public void SetPrice(string NewPrice)
  {
    _price = NewPrice;
  }

  public string GetPrice()
  {
    return _price;
  }

  public void SetMiles(string NewMiles)
  {
    _miles = NewMiles;
  }

  public string GetMiles()
  {
    return _miles;
  }

  public void SetColor(string NewColor)
  {
    _color = NewColor;
  }

  public string GetColor()
  {
    return _color;
  }

  // public bool WorthBuying(int maxPrice, int maxMiles)
  // {
  //   return (_price < maxPrice && _miles < maxMiles);
  // }
  // public void CarInfo()
  // {
  //   Console.WriteLine("Model: "+_makeModel);
  //   Console.WriteLine("Price: "+_price.ToString());
  //   Console.WriteLine("Miles: "+_miles.ToString());
  //   Console.WriteLine("Color: "+_color);
  // }
}


// public class Program
// {
//   public static void Main()
//   {
//     Car porsche = new Car("2014 Porsche 911",114991,7864);
//     Car ford = new Car("2011 Ford F450",55995,14241,"Black");
//     Car lexus = new Car("2013 Lexus RX 350",44700,20000,"Red");
//     Car mercedes = new Car("Mercedes Benz CLS550",39900,37979,"Green");
//
//     List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//     List<Car> MatchingCars = new List<Car>(0);
//
//     Console.WriteLine("Enter Maximum Price:");
//     int maxPrice = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter Maximum Mileage:");
//     int maxMiles = int.Parse(Console.ReadLine());
//
//     foreach(Car automobile in Cars)
//     {
//       if(automobile.WorthBuying(maxPrice,maxMiles))
//       {
//         MatchingCars.Add(automobile);
//       }
//     }
//
//     if(MatchingCars.Count != 0)
//     {
//       foreach(Car automobile in MatchingCars)
//       {
//         automobile.CarInfo();
//       }
//     }
//     else
//     {
//       Console.WriteLine("No Cars Found");
//     }
//
//   }
// }
}
