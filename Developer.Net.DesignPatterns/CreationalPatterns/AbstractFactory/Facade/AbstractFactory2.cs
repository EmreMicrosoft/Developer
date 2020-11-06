using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract;
using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Concrete;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Facade
{
    // Each Concrete Factory has a corresponding product variant.
    // Her Somut Factory'e karşılık gelen bir ürün çeşidi vardır.
    public class AbstractFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}