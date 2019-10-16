using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes_console
{
  public static class UIProviderFactory
  {

    public static UIProvider CreateUI()
    {
      return new UIProvider();
    }

  }
}
