using System;
using BakeryOrders.Models;

namespace BakeryOrders
{
  public class Program
  {
    public static void Main()
    {
      Program.WelcomeMessage();
      int breadOrder = Program.OrderCollection("loaves of bread");
      int pastryOrder = Program.OrderCollection("pastries");
      Console.WriteLine($"You've ordered {breadOrder} loaves of bread and {pastryOrder} pastries.");
    }
    public static int OrderCollection(string productType)
    {
      int orderQty;
      while (true)
      {
        Console.WriteLine($"How many {productType} would you like to purchase?");
        string userOrderStr = Console.ReadLine();
        bool success = int.TryParse(userOrderStr, out orderQty);
        if (success) 
        {
          if (orderQty < 0)
          {
            Console.WriteLine($"Please select a number ranging from zero upward. Monsieur Pierre cannot buy {productType} back!");
            continue;
          }
          return orderQty;
        }
        else
        {
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("Please enter your order quantity as a numerical integer above 0.");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
          continue;
        }
      }
    }
    public static void WelcomeMessage()
    {
      Console.WriteLine(@"______ _                    _      ______       _                   ");
      Console.WriteLine(@"| ___ (_)                  ( )     | ___ \     | |                  ");
      Console.WriteLine(@"| |_/ /_  ___ _ __ _ __ ___|/ ___  | |_/ / __ _| | _____ _ __ _   _ ");
      Console.WriteLine(@"|  __/| |/ _ \ '__| '__/ _ \ / __| | ___ \/ _` | |/ / _ \ '__| | | |");
      Console.WriteLine(@"| |   | |  __/ |  | | |  __/ \__ \ | |_/ / (_| |   <  __/ |  | |_| |");
      Console.WriteLine(@"\_|   |_|\___|_|  |_|  \___| |___/ \____/ \__,_|_|\_\___|_|   \__, |");
      Console.WriteLine(@"                                                               __/ |");
      Console.WriteLine(@"                                                              |___/ ");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine
      ("|Welcome to Pierre's Bakery!|");
      Console.WriteLine
      ("|Delicacies include:        |");
      Console.WriteLine
      ("| Breads by the loaf        |");
      Console.WriteLine
      ("|   One loaf is $5          |");
      Console.WriteLine
      ("|   Two loaves for $10. Get |");
      Console.WriteLine
      ("|   a third for free when   |");
      Console.WriteLine
      ("|   you buy two!            |");
      Console.WriteLine
      ("| Pastries by the morsel    |");
      Console.WriteLine
      ("|   One for $2,             |");
      Console.WriteLine
      ("|   Two for $4              |");
      Console.WriteLine
      ("|   Three for $5            |");
      Console.WriteLine
      ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
  }
}