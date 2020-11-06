using System;
using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor;
using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory;
using Developer.Net.DesignPatterns.StructuralPatterns.Facade;

namespace Developer.Net.DesignPatterns
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Developer.Net.DesignPatterns");
            Console.WriteLine();

            // BEHAVIORAL DESIGN PATTERNS
            Console.WriteLine("VISITOR");
            new VisitorRequest().Run();
            Console.WriteLine();

            // CREATIONAL DESIGN PATTERNS
            Console.WriteLine("ABSTRACT FACTORY");
            new AbstractFactoryRequest().Run();
            Console.WriteLine();

            // STRUCTURAL DESIGN PATTERNS
            Console.WriteLine("FACADE");
            new FacadeRequest().Run();
            Console.WriteLine();



        }
    }
}