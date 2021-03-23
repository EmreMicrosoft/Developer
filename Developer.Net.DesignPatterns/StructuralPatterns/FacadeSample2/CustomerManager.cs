namespace Developer.Net.CoreLibrary.DesignPatterns.Facade
{
    public class CustomerManager
    {
        private readonly CrossCuttingConcerns _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcerns();
        }

        public void Save()
        {
            _concerns.Authorize.CheckUser();
            _concerns.Caching.Cache();
            _concerns.Logging.Log();

            System.Console.WriteLine("Facade pattern saved all");
        }
    }
}