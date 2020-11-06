using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Facade
{
    // The Abstract Factory interface declares a set of methods that return
    // different abstract products. These products are called a family and are
    // related by a high-level theme or concept. Products of one family are
    // usually able to collaborate among themselves. A family of products may
    // have several variants, but the products of one variant are incompatible
    // with products of another.

    // Abstract Factory arayüzü, farklı soyut ürünleri döndüren bir dizi yöntem bildirir. 
    // Bu ürünlere aile adı verilir ve üst düzey bir tema veya konsept ile ilişkilendirilir. 
    // Bir ailenin ürünleri genellikle kendi aralarında işbirliği yapabilir. 
    // Bir ürün ailesinin birkaç çeşidi olabilir, 
    // ancak bir varyantın ürünleri diğerinin ürünleriyle uyumlu değildir.

    public interface IAbstractFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}