using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete
{
    public class ComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponentB(this);
        }

        public string SpecialMethodOfComponentB()
        {
            return "B";
        }
    }
}