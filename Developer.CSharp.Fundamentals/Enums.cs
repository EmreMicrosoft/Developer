using System;

namespace Developer.CSharp.Fundamentals
{
    public class Enums
    {
        public enum CarType
        {
            Toyota = 1,
            Honda = 2,
            Hyundai = 3
        }

        public static CarType GetCarType()
        {
            const CarType myCarType = CarType.Hyundai;
            return myCarType;
        }

        public static void Sample1()
        {
            var myCarType = GetCarType();
            Console.Write(myCarType);
            Console.ReadKey();
        }

        public static void Sample2()
        {
            // ... Two enum variables.
            B b1 = B.Dog;
            V v1 = V.Hidden;

            // ... Print out their values.
            Console.WriteLine(b1);
            Console.WriteLine(v1);
        }

        public enum V
        {
            None,
            Hidden = 2,
            Visible = 4
        }

        public enum B
        {
            None,
            Cat = 1,
            Dog = 2
        }
    }
}