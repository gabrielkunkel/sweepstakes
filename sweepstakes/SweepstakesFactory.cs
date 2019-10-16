namespace sweepstakes
{
  public static class SweepstakesFactory
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

    public static Contestant CreateContestant()
    {
      return new Contestant();
    }



  }
}
