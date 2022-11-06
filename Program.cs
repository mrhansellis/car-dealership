using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 1955, true);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 1819, true);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 3935, true);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 3000, true);
      Car rabbit = new Car("1977 Volkwagen Rabbit", 2300, 420420, 1946, false);
      Car lada = new Car("1984 Lada VAZ-2103", 800, 230400, 1962, false);
      Car hudson = new Car("1933 Hudson Terraplane", 10000, 350781, 2670, true);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc, rabbit, lada, hudson };

      Console.WriteLine("Would you like to hear about our sales event? [Y or N]");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        //Console.WriteLine("Your new price is: " + yugo.GetPrice());
      }
      
      Console.WriteLine("Enter a maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("In the Dakar rally the " + automobile.GetMakeModel() + " has a quality score of: " + automobile.Rally() + " out of 10");
        if (automobile.MakeModel == "1974 Volkswagen Thing" || automobile.MakeModel == "1980 Yugo Koral" || automobile.MakeModel == "1984 Lada VAZ-2103") 
        {
          automobile.SalesPrice();
        }
        Console.WriteLine("$" + automobile.GetPrice());
      }    
    }
  }
}