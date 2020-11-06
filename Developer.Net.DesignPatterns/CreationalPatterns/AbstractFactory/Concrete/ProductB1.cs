using Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Abstract;

namespace Developer.Net.DesignPatterns.CreationalPatterns.AbstractFactory.Concrete
{
    public class ProductB1 : IProductB
    {
        public string FunctionB()
        {
            return "The result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.

        // Ürün B1 varyantı, yalnızca Ürün A1 varyantıyla doğru şekilde çalışabilir. 
        // Bununla birlikte, AbstractProductA'nın herhangi bir örneğini bir argüman olarak kabul eder.

        public string AnotherFunctionB(IProductA collaborator)
        {
            var result = collaborator.FunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}