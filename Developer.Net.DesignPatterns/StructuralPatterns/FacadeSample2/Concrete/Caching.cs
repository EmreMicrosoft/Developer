using Developer.Net.CoreLibrary.DesignPatterns.Facade.Abstract;

namespace Developer.Net.CoreLibrary.DesignPatterns.Facade.Concrete
{
    internal class Caching : ICaching
    {
        public void Cache()
        {
            System.Console.WriteLine("Cached");
        }
    }
}