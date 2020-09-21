using System;

namespace PingPong.Game {

  public class Text
  {
    public string resultText;
    public string GetResult(int userInput)
    {
      for (int index = 1; index <= userInput; index++)
      {
        if ( index%3 == 0 && index%5 == 0 )
        {
          resultText = resultText + ", Ping-Pong";
        } 
        else if ( index%3 == 0 )
        {
          resultText = resultText + ", Ping";
        }
        else if ( index%5 == 0 )
        {
          resultText = resultText + ", Pong";
        }
        else
        {
          if ( index == 1 )
          {
            resultText = index.ToString();
          }
          else
          {
            resultText = resultText + ", " + index.ToString();
          }
          
        }
      }

      return resultText;
      
    }
  }
}

