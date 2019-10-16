using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sweepstakes;

namespace sweepstakes_console
{
  class UserInterface
  {
    UIProvider ui;
    MarketingFirm marketingFirm;

    public UserInterface(UIProvider ui)
    {
      this.ui = ui;
    }

    public void Run()
    {
      marketingFirm = ui.CreateStackOrQueueManager();
      ui.RunPrimaryLoop(marketingFirm);
    }

  }
}
