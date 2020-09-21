using System;

namespace PingPong {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringUserInput = Console.ReadLine();
      int userInput = int.Parse(stringUserInput);

      string result = PingPong(userInput);

      Console.WriteLine(result);
    }
  }
}
