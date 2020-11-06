namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract
{
    public interface IProductB
    {
        // Product B is able to do its own thing...
        // Ürün B kendi işini yapabilir...
        string FunctionB();

        // ... but it also can collaborate with the ProductA.
        // The Abstract Factory makes sure that all products it creates are of the same variant and thus, compatible.

        // ... ama aynı zamanda ProductA ile de işbirliği yapabilir.
        // Abstract Factory, yarattığı tüm ürünlerin aynı varyantta ve dolayısıyla uyumlu olmasını sağlar.
        string AnotherFunctionB(IProductA collaborator); // collaborator: işbirlikçi
    }
}