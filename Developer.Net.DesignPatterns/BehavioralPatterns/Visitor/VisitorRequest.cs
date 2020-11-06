using System;
using System.Collections.Generic;
using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract;
using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor
{
    public class VisitorRequest
    {
        public void Run()
        {
            var components = new List<IComponent>
            {
                new ComponentA(),
                new ComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new Visitor1();
            RequestMethod(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new Visitor2();
            RequestMethod(components, visitor2);
        }


        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.

        // İstemci kodu, somut sınıflarını anlamadan herhangi bir öğe kümesi üzerinde 
        // ziyaretçi işlemlerini çalıştırabilir. Kabul işlemi, ziyaretçi nesnesindeki 
        // uygun işleme bir çağrı yönlendirir.
        public static void RequestMethod(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}