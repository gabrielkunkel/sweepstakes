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
    private string regexLettersNumbersUnderscore = @"^[a-zA-Z0-9_.-]+$";
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

    public void RunPrimaryLoop(MarketingFirm marketingFirm)
    {
      do
      {
        string input = UserInput.GetData("Do you want to add a new sweepstakes OR add a contestant or pick a winner on the current sweepstakes, removing that sweepstakes? (sweepstakes/contestant/winner)", new Regex(regexLetters)).ToLower();
        DetermineSweepstakesContestantWinnerChoice(input, marketingFirm); 
      } while (true);
    }

    private void DetermineSweepstakesContestantWinnerChoice(String input, MarketingFirm marketingFirm)
    {
      switch (input)
      {
        case "sweepstakes":
          AddSweepstakes(marketingFirm);
          break;
        case "contestant":
          RegisterContestant(marketingFirm);
          break;
        case "winner":
          GetCurrentSweepstakesWinner(marketingFirm);
          break;
        default:
          break;
      }
    }

    private void AddSweepstakes(MarketingFirm marketing)
    {
      string input = UserInput.GetData("What is the name of the new sweepstakes?", new Regex(regexLetters));
      marketing.CreateSweepStakes(input);
      Messages.PrintSweepstakesAdded(input);
    }

    private void GetCurrentSweepstakesWinner(MarketingFirm marketingFirm)
    {
      Sweepstakes workingSweepstakes = marketingFirm.sweepstakesManager.GetSweepstakes();
      Contestant contestant = workingSweepstakes.PickWinner();
      Messages.PrintWinner(contestant, workingSweepstakes.sweepstakesName);
    }

    private void RegisterContestant(MarketingFirm marketingFirm)
    {
      Sweepstakes workingSweepstakes = marketingFirm.sweepstakesManager.GetSweepstakes();
      Contestant contestant = CreateContestant();
      workingSweepstakes.RegisterContestant(contestant);
      Messages.PrintContestantAdded(contestant, workingSweepstakes.sweepstakesName);
      marketingFirm.sweepstakesManager.InsertSweepStakes(workingSweepstakes);
    }

    private Contestant CreateContestant()
    {
      Contestant contestant = SweepstakesFactory.CreateContestant();
      contestant.registrationNumber = UserInput.GetData("Enter new contenstant registration number", new Regex(regexLettersNumbersUnderscore));
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
