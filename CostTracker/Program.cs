using System;
using CostTracker.Models;

namespace CostTracker {
  class Program {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Welcome to Pierre Bakery Shop");
      Console.WriteLine("Bread is $5's each and Pastries are $2's each!");
      Console.WriteLine("We are currently running a special for bread where every 2 you get the third one free and for every 3 pastries you get one free!");
      Console.WriteLine("How many loafs of bread would you like?");
      string breadNumberStr = Console.ReadLine();
      Console.WriteLine("How many Pastries would you like?");
      string pastryNumberStr = Console.ReadLine();
      if (!int.TryParse(breadNumberStr, out int value) || !int.TryParse(pastryNumberStr, out int pastryValue)){
        CatchError();
      }
      int breadNumber = int.Parse(breadNumberStr);
      int pastryNumber = int.Parse(pastryNumberStr);
      ConfirmOrderOrChangeOrder(breadNumber, pastryNumber);
    }

    static void CatchError() {
      Console.WriteLine("You have entered an erronous order!");
      Console.WriteLine("Please enter a number, i.e '5' or '8'");
      Console.WriteLine("How many loafs of bread would you like?");
      string breadNumberStr = Console.ReadLine();
      Console.WriteLine("How many Pastries would you like");
      string pastryNumberStr = Console.ReadLine();
      if (!int.TryParse(breadNumberStr, out int value) || !int.TryParse(pastryNumberStr, out int pastryValue)){
        CatchError();
      }
      int breadNumber = int.Parse(breadNumberStr);
      int pastryNumber = int.Parse(pastryNumberStr);
      ConfirmOrderOrChangeOrder(breadNumber, pastryNumber);
    }

    static void ConfirmOrderOrChangeOrder(int amntOfBread, int amntOfPastry)
    {
      Console.WriteLine("Confirm the amount of Bread and Pastries you have in your basket:");
      Console.WriteLine($"Amount of Bread: {amntOfBread}.");
      Console.WriteLine($"Amount of Pastries: {amntOfPastry}.");
      Console.WriteLine("Is this what you want from Pierre's bakery? Enter 'yes' to proceed, or 'no' to re-renter the amount of bread and pastries!");
      string userInput = Console.ReadLine();
      if (userInput == "yes") 
      {
        TotalCost(amntOfBread, amntOfPastry);
      }
      else
      {
        Console.WriteLine("Oops! Lets change your order then. Please enter how many bread and pastries you want");
        Console.WriteLine("How many bread loafs do you want?");
        string redoBread = Console.ReadLine();
        Console.WriteLine("How many pastries would yhou like?");
        string redoPastries = Console.ReadLine();
      if (!int.TryParse(redoBread, out int value) || !int.TryParse(redoPastries, out int pastryValue)){
        CatchError();
      }
        int redoBreadToInt = int.Parse(redoBread);
        int redoPastriesToInt = int.Parse(redoPastries);
        ConfirmOrderOrChangeOrder(redoBreadToInt, redoPastriesToInt);
      }
    }

    static void TotalCost(int numberOfBreadPurchased, int numberOfPastriesPurchased)
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(numberOfBreadPurchased);
      newBread.MultiplyBread();
      newBread.SetDiscount();
      int breadCost = newBread.CalcualateCost();
      CalculatePastry newPastry = new CalculatePastry();
      newPastry.SetPastryBought(numberOfPastriesPurchased);
      newPastry.MultiplyPastry();
      newPastry.SetPastryDiscount();
      int pastryCost = newPastry.CalculateCost();
      int totalCost = pastryCost + breadCost;
      Console.WriteLine("-----------------------------");
      Console.WriteLine($"Your cost for bread is ${breadCost} and your pastries total to ${pastryCost}.");
      Console.WriteLine($"Your total cost is ${totalCost}.");
      Console.WriteLine("Would you like to place another order? Enter 'yes' to create a new order and to exit, press any key");
      string newOrder = Console.ReadLine();
      if (newOrder == "yes")
      {
        NewOrder();
      }
      else
      {
        Console.WriteLine("Thanks for shopping at Pierre's Bakery.");
      }
    }

    static void NewOrder()
    {
      Console.WriteLine("How many loafs of bread would you like?");
      string breadNumberStr = Console.ReadLine();
      Console.WriteLine("How many Pastries would you like?");
      string pastryNumberStr = Console.ReadLine();
      if (!int.TryParse(breadNumberStr, out int value) || !int.TryParse(pastryNumberStr, out int pastryValue)){
        CatchError();
      }
      int breadNumber = int.Parse(breadNumberStr);
      int pastryNumber = int.Parse(pastryNumberStr);
      ConfirmOrderOrChangeOrder(breadNumber, pastryNumber);
    }
  }
}