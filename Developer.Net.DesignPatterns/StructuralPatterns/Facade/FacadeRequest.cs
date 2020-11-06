// Facade Design Pattern

// Intent: Provides a simplified interface to a library, 
// a framework, or any other complex set of classes.

// Amaç: Bir kitaplığa, çerçeveye veya diğer karmaşık sınıf 
// kümelerine basitleştirilmiş bir arabirim sağlar.

using System;

namespace Developer.Net.DesignPatterns.StructuralPatterns.Facade
{
    public class FacadeRequest
    {
        public void Run()
        {
            // The facade method may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.

            // Facade metodunda alt sistemin bazı nesneleri önceden oluşturulmuş olabilir. 
            // Bu durumda, Facade'ın yeni örnekler oluşturmasına izin vermek yerine 
            // Facade'ı bu nesnelerle başlatmak faydalı olabilir.

            var subsystem1 = new SubSystem1();
            var subsystem2 = new SubSystem2();
            var facade = new Facade(subsystem1, subsystem2);
            FacadeMethod(facade);
        }


        // The facade method works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.

        // Facade metodu, Facade (cephe) tarafından sağlanan basit bir arabirim 
        // aracılığıyla karmaşık alt sistemlerle çalışır.Bir cephe, alt sistemin 
        // yaşam döngüsünü yönettiğinde, istemci alt sistemin varlığından haberdar 
        // bile olmayabilir.Bu yaklaşım, karmaşıklığı kontrol altında tutmanızı sağlar.
        public static void FacadeMethod(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}