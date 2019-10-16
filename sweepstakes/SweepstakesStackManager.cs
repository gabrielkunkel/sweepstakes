using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
  }
}
