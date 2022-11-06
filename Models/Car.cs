using System;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public void SetModel(string newModel)
    {
      MakeModel = newModel;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "our cars sound like " + sound;
    }
  }
}