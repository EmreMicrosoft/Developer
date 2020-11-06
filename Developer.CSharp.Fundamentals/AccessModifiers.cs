namespace Developer.CSharp.Fundamentals
{
    public class AccessModifiers
    {
        /*

        Erişim Belirleyiciler (Access Modifiers)

        1 - public
        2 - private
        3 - protected
        4 - internal
        5 - protected internal

        Erişim izni;

        * public (genel) olan değere hiçbir erişim kısıtlaması yoktur. Bu kod bloğunun içeriğine her yerden erişilebilir.

        * private (gizli) olan değere yalnızca tanımlandığı class'ın içinden erişilebilir. private, erişimi en çok kısıtlayan erişim belirleyicidir.

        * protected (korunan) olan değere sadece tanımlandığı class’ın içinden ve o class’tan türetilmiş diğer class’ların içinden erişilebilir. Varsayılan erişim belirleyicidir. Değiştirilmemesi gereken kritik kodlarda kullanılır. Kısıtlama derecelendirmesi bakımından public ve private arasında düşünülebilir.

        * internal (içsel, dahili) olarak tanımlanan değere, bulunduğu assembly’nin (.dll veya .exe) içinden erişilebilir. Değeri barındıran assembly pakedinin (programın) içinden erişim için kısıtlama yoktur fakat başka bir programdan bu değere erişilemez.

        * protected internal olan değerin eriþim belirleyicisini "protected OR internal" olarak da düþünebiliriz. Yani bu değere, kendisini barındıran assembly'nin içinde herhangi bir yerden ya da assembly'nin dışında da olsa tanımlandığı class'tan türetilmiş diğer class'ların içinden erişilebilir.
        ____________________________________________

            Diğer Notlar:

            * const (sabit): Class seviyesinde tanımlanır ve tanımlanma anında değeri verilmek zorundadır. Sonradan değeri değiştirilemez.

            * readonly (salt okunur): Class seviyesinde tanımlanır. Tanımlandığı anda değeri verilebilir ya da Class Constructor’ında değeri verilebilir. Sonradan değeri değiştirilemez.

            Örnekler:

            public class Math
            {
                 private const double pi = 3.14159;
            }

            public class Math
            {
                 private readonly int pi;

                 public Matematik()
                 {
                      pi = 22 / 7;
                 }
            }

        */
    }
}