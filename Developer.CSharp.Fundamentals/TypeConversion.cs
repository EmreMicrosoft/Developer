using System;

namespace Developer.CSharp.Fundamentals
{
    public class TypeConversion
    {
        // Type conversion is converting one type of data to another type. 
        // It is also known as Type Casting. In C#, type casting has two forms:

        // I - Implicit Type Conversion:
        //      These conversions are performed by C# in a type-safe manner. 
        //      For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.

        // Long can hold any value an int can hold, and more!
        private const int Number = 2147483647;
        private long _bigNumber = Number;

        // II - Explicit Type Conversion: These conversions are done explicitly by users using the pre-defined functions.
        //      Explicit conversions require a cast operator.
        public static void ExplicitConversion()
        {
            const double d = 5673.74;

            // cast double to int.
            const int i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}