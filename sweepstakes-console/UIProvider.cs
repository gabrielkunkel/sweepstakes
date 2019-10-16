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
    private string regexEmail = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

    public UIProvider()
    {
    }

    public MarketingFirm CreateStackOrQueueManager()
    {
      Messages.Introduction();
      string input = UserInput.GetData("Do you want to create a Queue or Stack based sweepstakes manager? (queue/stack)", new Regex(regexQueueOrStack)).ToLower();
      return DetermineMarketingFirmManager(input);
    }

    public string AddSweepstakesContestantOrPickWinner(MarketingFirm marketing)
    {
      return UserInput.GetData("Do you want to add a new sweepstakes OR add a contestant or pick a winner on the current sweepstakes, removing that sweepstakes? (sweepstakes/contestant/winner)", new Regex(regexQueueOrStack)).ToLower();
    }

    private Contestant AddContestantToCurrentSweepstakes()
    {
      Contestant contestant = SweepstakesFactory.CreateContestant();
      contestant.registrationNumber = UserInput.GetData("Enter new contenstant registration number", new Regex (regexLettersNumbersUnderscore));
      contestant.firstName = UserInput.GetData("Contestant First Name: ", new Regex(regexLetters));
      contestant.lastName = UserInput.GetData("Contestant Last Name: ", new Regex(regexLetters));
      contestant.email = UserInput.GetData("Contestant Email: ", new Regex(regexEmail));
      return contestant;
    }

    private MarketingFirm DetermineMarketingFirmManager(string choice)
    {
      if (choice == "queue")
      {
        return SweepstakesFactory.CreateSweepstakesQueueManager();
      }
      else
      {
        return SweepstakesFactory.CreateSweepstakesStackManager();
      }
    }

  }
}
