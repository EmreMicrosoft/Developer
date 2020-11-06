namespace Developer.Net.DesignPatterns.StructuralPatterns.Facade
{
    // Alt Sistem, cepheden (facade) veya istemciden (client) gelen istekleri doğrudan kabul edebilir. 
    // Her durumda, alt sistem için cephe yine başka bir istemcidir ve alt sistemin bir parçası değildir.

    public class SubSystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}