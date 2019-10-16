using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
  class MarketingFirm
  {
    // todo: has the functionality to create a sweepstakes

    ISweepstakesManager sweepstakesManager;

    public MarketingFirm(ISweepstakesManager sweepstakesManager)
    {
      this.sweepstakesManager = sweepstakesManager
    }

  }


}
