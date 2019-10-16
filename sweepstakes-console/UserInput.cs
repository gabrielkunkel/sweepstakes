using System;
using System.Text.RegularExpressions;

namespace sweepstakes_console
{
  public static class UserInput
  {
    public static string GetData(string infoRequested, Regex regex)
    {
      Match stillLoop;
      string input;

      do
      {
        Console.WriteLine(infoRequested);
        input = Console.ReadLine().Trim();
        stillLoop = regex.Match(input);

        if (!stillLoop.Success)
        {
          PrintErrorMessage(regex);
        }

      } while (!stillLoop.Success);

      return input;
    }


    private static void PrintErrorMessage(Regex regex)
    {

      if (regex.Match("89").Success)
      {
        Console.WriteLine("This field only accepts numbers. Try again.");
      }
      else if (regex.Match("yes").Success)
      {
        Console.WriteLine("This field only accepts a *yes* or *no*. Try again.");
      }
      else if (regex.Match("stack").Success)
      {
        Console.WriteLine("This field only accepts a *queue* or *stack*. Try again.");
      }
      else if (regex.Match("abcdefghi").Success)
      {
        Console.WriteLine("This field only accepts letters. Try again.");
      }
      else if (regex.Match("abc123_").Success)
      {
        Console.WriteLine("This field only accepts letters, numbers, or underscores. Try again.");
      }
      else
      {
        Console.WriteLine("That is invalid input. Try again.");
      }

    }

  }

}