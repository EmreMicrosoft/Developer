using System;

namespace Developer.CSharp.Fundamentals.Notes
{
    public class DefiningConstants
    {
        public static void Run()
        {
            const double pi = 3.14159;

            // constant declaration 
            Console.WriteLine("Enter Radius: ");
            var r = Convert.ToDouble(Console.ReadLine());

            var areaCircle = pi * r * r;  // var --> double
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}