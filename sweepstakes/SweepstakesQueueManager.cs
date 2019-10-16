using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
  public class SweepstakesQueueManager : ISweepstakesManager
  {
    private Queue<Sweepstakes> queue;

    public SweepstakesQueueManager()
    {
      queue = new Queue<Sweepstakes>();
    }
    public Sweepstakes GetSweepstakes()
    {
      return queue.Dequeue();
    }

    public void InsertSweepStakes(Sweepstakes sweepstakes)
    {
      queue.Enqueue(sweepstakes);
    }
  }
}
