using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
  static class SweepstakesFactory
  {

    public static MarketingFirm CreateSweepstakesStackManager()
    {
      return new MarketingFirm(new SweepstakesStackManager());
    }

    public static MarketingFirm CreateSweepstakesQueueManager()
    {
      return new MarketingFirm(new SweepstakesQueueManager());
    }

    public static Sweepstakes CreateNewSweepStakes(string nameOfSweepstakes)
    {
      return new Sweepstakes(nameOfSweepstakes);
    }



  }
}
