// Abstract Factory Design Pattern

// Intent: Lets you produce families of related objects without 
//specifying their concrete classes.

// Amaç: Somut sınıflarını belirtmeden ilgili 
// nesnelerin ailelerini oluşturmanıza izin verir.



using System;
using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Facade;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.

    // İstemci kodu, fabrikalar ve ürünlerle yalnızca soyut türler 
    // aracılığıyla çalışır: AbstractFactory ve AbstractProduct. 
    // Bu, herhangi bir fabrika veya ürün alt sınıfını müşteri koduna 
    // onu kırmadan (sorunsuz) geçirmenize olanak tanır.
    public class AbstractFactoryRequest
    {
        public void Run()
        {
            // The client code can work with any concrete factory class.
            // İstemci kodu herhangi bir somut factory sınıfı ile çalışabilir.

            Console.WriteLine("Client: Testing client code with the first factory type...");
            RequestMethod(new AbstractFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            RequestMethod(new AbstractFactory2());
        }

        public void RequestMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.FunctionB());
            Console.WriteLine(productB.AnotherFunctionB(productA));
        }
    }
}