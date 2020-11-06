using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract;
using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Concrete;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Facade
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.

    // Concrete Factory'ler, tek bir varyanta ait bir ürün ailesi üretir. 
    // Fabrika, ortaya çıkan ürünlerin uyumlu olduğunu garanti eder. 
    // Concrete Factory'nin yöntemlerinin imzalarının soyut bir ürün döndürdüğünü, 
    // yöntemin içinde somut bir ürünün örneklendiğini unutmayın.
    public class AbstractFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}