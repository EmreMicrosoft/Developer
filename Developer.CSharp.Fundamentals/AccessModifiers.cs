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

* internal (içsel, dahili) olarak tanımlanan değere, bulunduðu assembly’nin (.dll veya .exe) içinden eriþilebilir. Deðeri barýndýran assembly pakedinin (programýn) içinden eriþim için kýsýtlama yoktur fakat baþka bir programdan bu deðere eriþilemez.

* protected internal olan deðerin eriþim belirleyicisini "protected OR internal" olarak da düþünebiliriz. Yani bu deðere, kendisini barýndýran assembly'nin içinde herhangi bir yerden ya da assembly'nin dýþýnda da olsa tanýmlandýðý class'tan türetilmiþ diðer class'larýn içinden eriþilebilir.
____________________________________________

Diðer Notlar:

* const (sabit): Class seviyesinde tanýmlanýr ve tanýmlanma anýnda deðeri verilmek zorundadýr. Sonradan deðeri deðiþtirilemez.

* readonly (salt okunur): Class seviyesinde tanýmlanýr. Tanýmlandýðý anda deðeri verilebilir ya da Class Constructor’ýnda deðeri verilebilir. Sonradan deðeri deðiþtirilemez.

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