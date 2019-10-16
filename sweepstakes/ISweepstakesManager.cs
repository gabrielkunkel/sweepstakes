namespace sweepstakes
{
  interface ISweepstakesManager
  {
    void InsertSweepStakes(Sweepstakes sweepstakes);

    Sweepstakes GetSweepstakes();

  }
}
