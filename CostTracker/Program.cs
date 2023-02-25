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
      int breadNumber = int.Parse(breadNumberStr);
      int pastryNumber = int.Parse(pastryNumberStr);
      ConfirmOrderOrChangeOrder(breadNumber, pastryNumber);
    }

    static void ConfirmOrderOrChangeOrder(int amntOfBread, int amntOfPastry)
    {
      Console.WriteLine("Confirm the amount of Bread and Pastries you have in your basket:");
      Console.WriteLine($"Amount of Bread: {amntOfBread}.");
      Console.WriteLine($"Amount of Pastries; {amntOfPastry}.");
    }
  }
}