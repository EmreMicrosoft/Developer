using Developer.Net.CoreLibrary.DesignPatterns.Facade.Abstract;
using Developer.Net.CoreLibrary.DesignPatterns.Facade.Concrete;

namespace Developer.Net.CoreLibrary.DesignPatterns.Facade
{
    internal class CrossCuttingConcerns
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttingConcerns()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}