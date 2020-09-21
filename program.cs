using System;
using PingPong.Game;

namespace PingPong {

  public class Program
  {
    public static void Main()
    {
      Text something = new Text();

      Console.WriteLine("Enter a number: ");
      string stringUserInput = Console.ReadLine();
      int userInput = int.Parse(stringUserInput);


      Console.WriteLine(something.GetResult(userInput));
    }
  }
}
