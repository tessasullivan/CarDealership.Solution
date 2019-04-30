using System;
using System.Collections.Generic;

namespace CarDealership.Models 
{
  public class Car
  {
    private static List<Car> _instances = new List<Car>{};
    private string _MakeModel;
    private int _Price;
    private int _Miles;
    public Car(string makeModel, int price, int miles)
    {
      _MakeModel = makeModel;
      _Price = price;
      _Miles = miles;
      _instances.Add(this);
    }
    public string GetMakeModel()
    {
      return _MakeModel;
    }
    public int GetPrice ()
    {
      return _Price;
    }
    public int GetMiles()
    {
      return _Miles;
    }
    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_Price < maxPrice);
    }
    public static List<Car> GetAll()
    {
       return _instances;
    }
  }
}