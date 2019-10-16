using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using sweepstakes;

namespace sweepstakes_console
{
  public class UIProvider
  {
    private string regexDecimalNumbersString = @"^-?\d*(\.\d+)?$";
    private string regexYesOrNo = @"(\byes\b)|(\bno\b)";
    private string regexQueueOrStack = @"(\bstack\b)|(\bqueue\b)";
    private string regexLetters = @"(?i)^[a-z]+";
    private string regexLettersNumbersUnderscore = @"^[a-zA-Z0-9\_]+$";

    public UIProvider()
    {
    }

    public string CreateStackOrQueueManager()
    {
      Messages.Introduction();
      return UserInput.GetData("Do you want to create a Queue or Stack based sweepstakes manager? (queue/stack)", new Regex(regexQueueOrStack));
    }

  }
}
