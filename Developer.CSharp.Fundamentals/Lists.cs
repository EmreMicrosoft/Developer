using System;
using System.Collections.Generic;

namespace Developer.CSharp.Fundamentals
{
    public class Lists
    {
        private readonly List<int> _numbers = new List<int>();

        public void AddToList()
        {
            _numbers.Add(1);
            _numbers.Add(2);
            _numbers.Add(3);
        }

        public void AddRangeToList()
        {
            var array = new int[] { 1, 2, 3 };
            // int[] array = new int[] { 1, 2, 3 };
            _numbers.AddRange(array);
        }

        public List<string> RemoveFromList()
        {
            var fruits = new List<string>
                // var ---> List<string> fruits = new List<string>
                {
                    // add fruits
                    "apple",
                    "banana",
                    "orange"
                };

            // now remove the banana
            fruits.Remove("banana");
            Console.WriteLine(fruits.Count);
            Console.ReadKey();

            return fruits;

            //private static void Main(string[] args)
            //{
            //    var pa = new Stage06Lists();
            //    var pb = pa.RemoveFromList();
            //    // List<string> pb = pa.RemoveFromList();
            //    Console.Write(pb);
            //    Console.ReadKey();
            //}
        }
    }
}