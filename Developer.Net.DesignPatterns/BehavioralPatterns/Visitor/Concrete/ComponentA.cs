using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete
{
    public class ComponentA : IComponent
    {
        // Note that we're calling 'VisitComponentA', which matches
        // the current class name. This way we let the visitor know 
        // the class of the component it works with.

        // Mevcut sınıf adıyla eşleşen 'VisitComponentA'yı 
        // çağırdığımızı unutmayın. Bu şekilde ziyaretçinin 
        // çalıştığı bileşenin sınıfını bilmesini sağlarız.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentA(this);
        }

        // Concrete Components may have special methods that don't exist in
        // their base class or interface. The Visitor is still able to use these
        // methods since it's aware of the component's concrete class.

        // Somut Bileşenler, temel sınıflarında veya arayüzlerinde bulunmayan 
        // özel yöntemlere sahip olabilir. Ziyaretçi, bileşenin somut sınıfının 
        // farkında olduğu için bu yöntemleri kullanmaya devam edebilir.
        public string ExclusiveMethodOfComponentA()
        {
            return "A";
        }
    }
}