using Developer.Net.CoreLibrary.DesignPatterns.Facade.Abstract;

namespace Developer.Net.CoreLibrary.DesignPatterns.Facade.Concrete
{
    internal class Logging : ILogging
    {
        public void Log()
        {
            System.Console.WriteLine("Logged");
        }
    }
}