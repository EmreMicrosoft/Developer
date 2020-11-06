namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract
{
    // The Component interface declares an 'accept' method that 
    // should take the base visitor interface as an argument.

    // Bileşen arayüzü, temel ziyaretçi arayüzünü bağımsız değişken 
    // olarak alması gereken bir 'kabul' yöntemi bildirir.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}