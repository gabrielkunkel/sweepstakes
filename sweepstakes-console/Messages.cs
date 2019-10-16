using sweepstakes;
using System;

namespace sweepstakes_console
{
  public class Messages
  {

    public static void Introduction()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Print("Welcome to Sweepstakes Manager!");
      Console.ResetColor();
    }

    public static void PrintWinner(Contestant contestant, string sweepstakesName)
    {
      Print($"{sweepstakesName} Sweepstakes winner!");
      PrintDashedLine();
      PrintContestant(contestant);
      Print($"{sweepstakesName} sweepstakes is now over.");
    }

    public static void PrintSweepstakesAdded(string sweepstakesName)
    {
      Print($"{sweepstakesName} sweepstakes added.");
    }

    public static void PrintContestantAdded(Contestant contestant, string sweepstakesName)
    {
      Print($"Contestant {contestant.firstName} {contestant.lastName} added to {sweepstakesName}.");
    }

    public static void PrintContestant(Contestant contestant)
    {
      Sweepstakes.PrintContestantInfo(contestant);
    }

    public static void PrintNoSweepstakes()
    {
      Print("Currently there is no sweepestakes. You must add one first.");
    }

    public static void PrintNoContestant()
    {
      Print("Currently there is no contestant. You must add one first.");
    }

    public static void PrintEmptyLine()
    {
      Print("                    ");
    }

    public static void PrintDashedLine()
    {
      Print("---------------------------");
    }

    public static void PrintExit()
    {
      Print("Goodbye.");
      Console.ReadLine();
    }

    public static void ResetConsole()
    {
      Console.Clear();
    }

    private static void Print(string stringToPrint)
    {
      Console.WriteLine(stringToPrint);
    }

  }


}
