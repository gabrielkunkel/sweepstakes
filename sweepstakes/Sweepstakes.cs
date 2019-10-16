using System;
using System.Collections.Generic;
using System.Linq;

namespace sweepstakes
{
  public class Sweepstakes
  { 
    string sweepstakesName;
    Dictionary<string, Contestant> dictionary;

    public Sweepstakes(string name)
    {
      this.dictionary = new Dictionary<string, Contestant>();
      this.sweepstakesName = name;
    }

    public void RegisterContestant(Contestant contestant)
    {
      dictionary.Add(contestant.registrationNumber, contestant);
    }

    public Contestant PickWinner()
    {
      Random rng = new Random(Guid.NewGuid().GetHashCode());
      int chosenContestant = rng.Next(0, dictionary.Count - 1);
      return dictionary.ElementAt(chosenContestant).Value;
    }

    public static void PrintContestantInfo(Contestant contestant)
    {
      Console.WriteLine($"Contestant registration number: {contestant.registrationNumber}");
      Console.WriteLine($"First Name: {contestant.firstName}");
      Console.WriteLine($"Last Name: {contestant.lastName}");
      Console.WriteLine($"Email: {contestant.email}");
    }
  }
}
