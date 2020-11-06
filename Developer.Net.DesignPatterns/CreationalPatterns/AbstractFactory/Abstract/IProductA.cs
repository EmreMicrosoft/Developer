namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.

    // Bir ürün ailesinin her farklı ürünü bir temel arayüze sahip olmalıdır.
    // Ürünün tüm çeşitleri bu arayüzü uygulamalıdır.
    public interface IProductA
    {
        string FunctionA();
    }
}