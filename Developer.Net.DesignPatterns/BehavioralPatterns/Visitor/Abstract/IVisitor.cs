using Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Concrete;

namespace Developer.Net.DesignPatterns.BehavioralPatterns.Visitor.Abstract
{
    // The Visitor Interface declares a set of visiting methods that correspond
    // to component classes. The signature of a visiting method allows the visitor 
    // to identify the exact class of the component that it's dealing with.

    // Ziyaretçi Arayüzü, bileşen sınıflarına karşılık gelen bir dizi ziyaret 
    // yöntemi bildirir. Bir ziyaret yönteminin imzası, ziyaretçinin uğraştığı 
    // bileşenin tam sınıfını tanımlamasına olanak tanır.

    public interface IVisitor
    {
        void VisitComponentA(ComponentA element);

        void VisitComponentB(ComponentB element);
    }
}