using System;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int Weight { get; set; } // Weight in lbs.
    public bool FuelType { get; set; } // True would mean fuel is gasoline, False would mean fuel is diesel.

    public Car(string makeModel, int price, int miles, int weight, bool fuelType)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Weight = weight;
      FuelType = fuelType;
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
    public int GetWeight()
    {
      return Weight;
    }
    public bool GetFuelType()
    {
      return FuelType;
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

    public void SalesPrice()
    {
      Price = Convert.ToInt32(GetPrice() / 1.25);
    }

      public int Rally()
    {
      int quality = 10;

      if (Miles > 100000)
      {
        quality -= 4;
      }
      else if (Miles > 50000)
      {
         quality -= 2;
      }
      else if (Miles > 10000)
      {
         quality -= 1;
      }

      if (Weight > 4000)
      {
        quality -= 4;
      }
      else if (Weight > 3000)
      {
         quality -= 2;
      }
      else if (Weight > 2000)
      {
         quality -= 1;
      }

      if(FuelType){quality -= 1;}

      return quality;
    }
  }
}