using System;

namespace PingPong {

  public class Game
  {
    string resultText;
    public GetResult(int userInput)
    {
      for (int index = 1; index < userInput; index++)
      {
        if ( index%3 == 0 && index%5 == 0 )
        {
          string resultText = resultTest + ", Ping-Pong";
        } 
        else if ( index%3 == 0 )
        {
          string resultText = resultTest + ", Ping";
        }
        else if ( index%5 == 0 )
        {
          string resultText = resultTest + ", Pong";
        }
        else
        {
          if ( index == 1 )
          {
            string resultText = index.ToString();
          }
          else
          {
            string resultText = ", " + index.ToString();
          }
          
        }
      }

      return resultText;
      
    }
  }
}

