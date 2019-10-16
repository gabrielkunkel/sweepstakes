using System.Collections.Generic;

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
