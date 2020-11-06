namespace Developer.MsSql.Fundamentals.Basics
{
    public class Notes
    {
        /*

        
           TURKISH CI_AS
           
           SQL SERVER’ da VERİ TİPLERİ
           
           Sql Server verileri çeşitli türleri ile saklamak için, çeşitli veri tipleri sunmaktadır.Bu veriler metinsel, tarihsel, sayısal ve parasal tipte olacağı gibi görüntü, XML tabanlı ve kullanıcı tarafından oluşturulmuþ tipte de olabilmektedir.
           
           – Kesin Sayısal Değişkenleri ( Exact Numerics) = bigint, bit, decimal, int, money, numeric, smallint, smallmoney, tinyint
           
           – Yaklaşık Sayısal Değişkenleri ( Approximate Numerics ) = float, real
           
           – Tarih ve Zaman Deðişkenleri ( Date and Time ) = date, datetime, datetime2, datetimeoffset, smalldatetime, time
           
           – Karakter Değiþkenleri ( Character Strings ) = char, varchar, text
           
           – Unicode Karakter Değiþkenleri ( Unicode Character Strings ) = nchar, nvarchar, ntext
           
           – Binary Değişkenleri ( Binary Strings ) = binary, varbinary, image
           
           – Diğer Sql Değişkenleri ( Other Data Types ) = cursor, hierarchyid, sql_variant, table, timestamp, uniqueidentifier, xml
           
           Şimdi sırasıyla bu değişkenlere ve özelliklerine bakalım, böylelikle hangi değiþken hangi aralıkta ve ne değerleri alıyor bellekte kendine ne kadar yer açıyor bunları öğrenmiş olacağız.
           
           
           
           Kesin Sayýısal Değişkenleri ( Exact Numerics)
           
           bit : 1 bayt yer tutar. Alacağı değer 1 ya da 0 ‘dır. Yani true ya da false. C# ‘ta ki bool veri tipine karşılık gelir.
           
           tinyint : 1 bayt yer tutar. 0 ile 255 arasında ki tam sayıları tutar. C# ‘ta ki byte veri tipine karşılık gelir.
           
           smallint : 2 bayt yer tutar. -32.768 ile 32.767 arasında ki tam sayıları tutar. C# ‘ ta ki short tipine karşılık gelir.
           
           int : 4 bayt yer tutar. -2.147.483.648 ile 2.147.483.647 arasında ki tam sayıları tutar. C# ‘ta ki kullanımında değişkenin adı gene aynıdır.
           
           bigint : 8 bayt yer tutar. -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 arasında ki tam sayıları tutar. C# ‘ ta ki long tipine karşılık gelir.
           
           smallmoney : 4 bayt yer tutar. -214.748,3648 ile 214.748,3647 arasında ki ondalık sayıları tutar. Virgülden sonrasında 4 basamak daha yer alır. Ücret ile ilgili değişken tiplerinde bu türü kullanabilirsiniz. C# ‘ta temel olarak karşılığı yoktur ama aynı işlemleri decimal ile yapabilirsiniz.
           
           money : 8 bayt yer tutar -922.337.203.685.477,5808 ile 922.337.203.685.477,5807 arasında ki ondalık sayıları tutar. smallmoney veri tipinde ki gibi virgül sonrasında 4 basamak daha alır. Ücret ile ilgili değişken tiplerinde bu türü kullanabilirsiniz. C# ‘ta temel olarak karşılığı yoktur ama aynı işlemleri decimal ile yapabilirsiniz.
           
           Yaklaşık Sayısal Değişkenleri ( Approximate Numerics )
           
           float : ihtiyacınız olan alana göre bayt olarak kendi değer alır. Yani kaplayacağı alanı siz belirlersiniz. Kullanımı : float(N) burada ki N size ihtiyacınız olacak bayt boyutunu belli eder. float(5) derseniz 5 baytlık bir alan kaplar. Bu değiþken içine aldığı sayıyı otomatik olarak yuvarlar böylece yaklaşık bir sayısal veri tutmuş olur. C# ‘ta ki kullanımı double ‘ dir.
           
           real : 4 bayt yer tutar. Aynı zamanda float(24) ile aynı değerleri tutabilir. Dolayısıyla bazı yerlerde float olarak tanımlanması bellekte boş yer tutulmasının önüne geçebilir. 3.40E+38 ile -1.18E-38, 0 ve 1.18E-38 ile 3.40E+38 arası ondalık sayıları tutabilirsiniz. C# ‘ta ki eşdeğeri Single ‘dır.
           
           Tarih ve Zaman Değişkenleri ( Date and Time )
           
           date : 3 bayt yer tutar. YYYY-MM-DD yani YIL – AY – GÜN þeklinde tarihi tutar. 0001-01-01 ile 9999-12-31 arasında ki tarih bilgilerinizi sorunsuzca bu veri tipinde verebilirsiniz.
           
           datetime : 8 bayt yer tutar. YYYY-MM-DD hh:mm:ss[.mmm] yani YIL – AY – GÜN SAAT:SANİYE:SALİSE.MİLİSALİSE şeklinde tarihi tutar.
           
           datetime2 : DateTime veri tipinden tek farkı daha hassas veri tiplerini tutmasıdır. Yani bu tip ile daha detaylı veri tutarsınız. YYYY-MM-DD hh:mm:ss[.nnnnnnn]
           
           time : Sadece saat bilgisini hh:mm:ss[.nnnnnnn] þeklinde tutar. 00:00:00.0000000 ile 23:59:59.9999999 arası değer alır.
           
           datetimeoffset : datetime2 ile yapısı aynıdır, tek farkı bu veri tipinin diğerinden farklı olarak ülkelere göre tarihi tutmasıdır. (bakınız GMT) YYYY-MM-DD hh:mm:ss[. nnnnnnn] [{+|-}hh:mm] şeklinde tarihi tutar
           Karakter Değişkenleri ( Character Strings )
           
           char : char(n) şeklinde kullanılır. N baytı temsil eder ve ihtiyacımıza göre genişletebiliriz. 1 ile 8000 arasında ki değerleri tutar.
           varchar : char ile aynı yapıdadır. varchar(MAX) þeklinde tanımlanırsa maksimum 8000 karakter değil maksimum değer olan 2,147,483,647 karakter veri girilebilir.
           
           text : varchar(MAX) ile aynı görevdedir. Uzun yazılarınızı bu veri tipinde barındırabilirsiniz.
           
           Unicode Karakter Değişkenleri ( Unicode Character Strings )
           
           nchar : char ile aynı yapıdadır. Tek farkı ise , char’ın aksine UniCode karakterleri dediğimiz karakteri de üzerinde barındırabilmesidir. (Unicode Karakterler) . 1-4000 arası değer tutar.
           
           nvarchar : varchar ile kullanımı aynıdır. Tek farkı UniCode karakterleri dediğimiz karakteri de üzerinde barındırabilmesidir. (Unicode Karakterler) . 1-4000 arası değer tutar.
           
           ----------------------------------------------------------------------------------
           
           Delete Rules
           
           Cascade, Default, Set Null vs..
           
           ----------------------------------------------------------------------------------
           
           Primary Key, Foreign Key, Unique Key
           

        */
    }
}