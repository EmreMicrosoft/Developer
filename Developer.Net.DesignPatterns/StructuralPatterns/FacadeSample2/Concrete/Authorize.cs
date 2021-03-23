using Developer.Net.CoreLibrary.DesignPatterns.Facade.Abstract;

namespace Developer.Net.CoreLibrary.DesignPatterns.Facade.Concrete
{
    internal class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            System.Console.WriteLine("User checked");
        }
    }
}