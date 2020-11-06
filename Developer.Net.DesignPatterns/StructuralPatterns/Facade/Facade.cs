namespace Developer.Net.DesignPatterns.StructuralPatterns.Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.

    // Facade sınıfı, bir veya birkaç alt sistemin karmaşık mantığına basit bir 
    // arayüz sağlar. Facade, istemci isteklerini alt sistemdeki uygun nesnelere 
    // devreder. Facade ayrıca yaşam döngülerini yönetmekten de sorumludur. 
    // Tüm bunlar müşteriyi alt sistemin istenmeyen karmaşıklığından korur.

    public class Facade
    {
        protected SubSystem1 SubSystem1;
        protected SubSystem2 SubSystem2;

        public Facade(SubSystem1 subSystem1, SubSystem2 subSystem2)
        {
            SubSystem1 = subSystem1;
            SubSystem2 = subSystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to
        // a fraction of a subsystem's capabilities.

        // Facade'ın metodları, alt sistemlerin gelişmiş işlevselliği için uygun kısayollardır. 
        // Ancak, istemciler bir alt sistemin yeteneklerinin yalnızca bir kısmına ulaşır.
        public string Operation()
        {
            var result = "Facade initializes subsystems:\n";
            result += SubSystem1.Operation1();
            result += SubSystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += SubSystem1.OperationN();
            result += SubSystem2.OperationZ();
            return result;
        }
    }
}