namespace sweepstakes_console
{
  class Program
  {
    static void Main(string[] args)
    {
      UserInterface userInterface = new UserInterface(UIProviderFactory.CreateUI());
      userInterface.Run();
    }
  }
}
