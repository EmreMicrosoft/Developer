using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Concrete
{
    public class ProductB2 : IProductB
    {
        public string FunctionB()
        {
            return "The result of the product B2.";
        }

        // Ürün B2 varyantı, yalnızca Ürün A2 varyantıyla doğru şekilde çalışabilir.
        // Bununla birlikte, ProductA'nın herhangi bir örneğini bir argüman olarak kabul eder.
        public string AnotherFunctionB(IProductA collaborator)
        {
            var result = collaborator.FunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}