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

    public static void PrintContestant(Contestant contestant)
    {
      Sweepstakes.PrintContestantInfo(contestant);
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
