using System;
using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete
{
    public class Visitor2 : IVisitor
    {
        public void VisitComponentA(ComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfComponentA() + " + Visitor2");
        }

        public void VisitComponentB(ComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfComponentB() + " + Visitor2");
        }
    }
}