using System.Collections.Generic;

namespace sweepstakes
{
  public class SweepstakesStackManager : ISweepstakesManager
  {
    private Stack<Sweepstakes> stack;

    public SweepstakesStackManager()
    {
      stack = new Stack<Sweepstakes>();
    }
    public Sweepstakes GetSweepstakes()
    {
      return stack.Pop();
    }

    public void InsertSweepStakes(Sweepstakes sweepstakes)
    {
      stack.Push(sweepstakes);
    }

    public bool IsSweepstakes()
    {
      if (stack.Count == 0)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public bool IsContestant()
    {
      Sweepstakes sweepstakes = stack.Peek();

      if (sweepstakes.dictionary.Count == 0)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

  }
}
