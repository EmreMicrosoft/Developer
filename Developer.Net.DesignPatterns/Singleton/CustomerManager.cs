namespace Developer.Net.CoreLibrary.DesignPatterns.Singleton
{
    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static readonly object LockObject = new object();

        private CustomerManager()
        {
        }

        public static CustomerManager CreateAsSingleton()
        {
            // Thread Safe
            lock (LockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }

            return _customerManager;
        }

        public void Save()
        {
            System.Console.WriteLine("Singleton is working");
        }
    }
}
