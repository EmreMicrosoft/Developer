namespace Developer.Net.DesignPatterns.StructuralPatterns.Facade
{
    // Some facades can work with multiple subsystems at the same time.
    // Bazı cepheler aynı anda birden fazla alt sistemle çalışabilir.

    public class SubSystem2
    {
        public string Operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string OperationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}