using System;
using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete
{
    // Concrete Visitors implement several versions of the same algorithm, which
    // can work with all concrete component classes.
    //
    // You can experience the biggest benefit of the Visitor pattern when using
    // it with a complex object structure, such as a Composite tree. In this
    // case, it might be helpful to store some intermediate state of the
    // algorithm while executing visitor's methods over various objects of the
    // structure.

    // Somut Ziyaretçiler, aynı algoritmanın tüm somut bileşen sınıflarıyla 
    // çalışabilen birkaç sürümünü uygular. Ziyaretçi modelinin en büyük faydasını, 
    // onu Bileşik bir ağaç gibi karmaşık bir nesne yapısıyla kullanırken yaşayabilirsiniz. 
    // Bu durumda, ziyaretçinin yöntemlerini yapının çeşitli nesneleri üzerinde 
    // çalıştırırken algoritmanın bazı ara durumlarını saklamak yararlı olabilir.

    public class Visitor1 : IVisitor
    {
        public void VisitComponentA(ComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfComponentA() + " + Visitor1");
        }

        public void VisitComponentB(ComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfComponentB() + " + Visitor1");
        }
    }
}