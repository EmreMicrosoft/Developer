using System;

namespace FacadePatternSample
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main(string[] args)
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
