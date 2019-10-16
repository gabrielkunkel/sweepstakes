using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
  class MarketingFirm
  {

    public ISweepstakesManager sweepstakesManager;

    public MarketingFirm(ISweepstakesManager sweepstakesManager)
    {
      this.sweepstakesManager = sweepstakesManager;
    }

    public void CreateSweepStakes(string nameOfSweepstakes)
    {
      sweepstakesManager.InsertSweepStakes(SweepstakesFactory.CreateNewSweepStakes(nameOfSweepstakes));
    }

  }


}
