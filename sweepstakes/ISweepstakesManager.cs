namespace sweepstakes
{
  public interface ISweepstakesManager
  {
    void InsertSweepStakes(Sweepstakes sweepstakes);

    Sweepstakes GetSweepstakes();

    bool IsSweepstakes();

    bool IsContestant();

  }
}
