namespace Developer.CSharp.Fundamentals.Notes
{
    public class OldNotes
    {
        /*

        DERS 1: 

Cache (L1, L2, L3) - İşlemci Önbelleği: İşlemciye en yakın depolama birimidir.
L1: Çekirdekler kullanır.
L2, L3: Çalışan programlar kullanır.
Header (computing) ? ::: https://tr.wikipedia.org/wiki/%C3%9Cstbilgi

Multitasking: Aynı anda birden fazla işlemin gerçekleşmesidir.

Binary: 1011001001010011000


CPU'ya bağlı 2 köprü vardır:
Kuzey Köprüsü: GPU ile haberleşmeyi sağlar.
Güney Köprüsü: Diğer tüm donanım (RAM, HDD, WiFi vs.) ile haberleşmeyi sağlar.

____________________________________________________________________

DERS 2:

# Value Types (Stack) : Sayısal veriler.

İSİM		ARALIK			KAPLADIĞI ALAN
bool		true/false		1 Byte
byte		0-255			1 Byte
sbyte		-128 +127		1 Byte
ushort		0-65535			2 Byte
short		–32,768 to 32,767	2 Byte
uint		0-4294967295		4 Byte
int		-/+ 2.1... milyar	4 Byte
ulong		0-18 trilyon		8 Byte
long		-/+ 9 trilyon		8 Byte

# Floating Types
float 		,7 (virgülden sonra)	4 Byte
double		,21-22			8 Byte
decimal		,27-28			16 Byte

# Reference Types
char		tek karakter		Karakter başına 2 Byte
string		çok karakter		Karakter başına 2 Byte

NOT: s: signed, u: unsigned
DateTime tipi 16 Byte yer kaplar

____________________________________________________________________

// Value Types (Stack)
bool    isActive      = true;             // 1 Byte    true-false
byte    age           =  255;             // 1 Byte    0 - 255
sbyte   degree        = -35;              // 1 Byte   -128 +127

ushort  ushortNumber  =  65535;           // 2 Byte    0 - 65535
short   shortNumber   = -32768;           // 2 Byte   -32768+32767

uint    uintNumber    =  4294967295;      // 4 Byte    0 - 4,294,967,295
int     intNumber     = -2147483648;      // 4 Byte   -2,147,483,648 +2,147,483,647

ulong   ulongNumber   =  3581000;         // 8 Byte    0 - 18,446,744,073,709,551,615
long    longNumber    = -3581000;         // 8 Byte   –9,223,372,036,854,775,808 +9,223,372,036,854,775,807

// Floating Types (Stack)
float floatNumber   = 100.1234567f;       //     7 digits,               -3.4 × 10^38 to +3.4 × 10^38
double  doubleNumber  = 100.1230000000d;  // 15-16 digits,               ±5.0 × 10^−324 to ±1.7 × 10^308
decimal decimalNumber = 100.12300000m;    // 28-29 significant digits,  (-7.9 x 10^28 to 7.9 x 10^28) / (10^0 to 10^28)

// Reference Types (Heap)
char characterA    = 'A';                 // 2 Byte
string  textAsdf      = "AsdfAsdf";       // 2 Byte per character

____________________________________________________________________


if (!string.IsNullOrEmpty(TextBox.Text)) // Eğer TextBox.Text geçersiz ya da boş değilse.


____________________________________________________________________


textBox’a sadece harf girişi için:

private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{
     e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) 
                 && !char.IsSeparator(e.KeyChar);
}


textBox’a sadece rakam girişi için:

private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
{
     e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
}

____________________________________________________________________


DERS 3:

Algoritmalar
Akış Diyagramı
Kontrol Mekanizmalarına Giriş

Ödev:::

GAO - Genel akademik ortalama (0-4)
0-49 arası FD ile kaldı
50-54 arası DD 
55-59 arası DC

(50-59 arası ve GAO 2'den küçükse 
büt ile şartlı geçti, 
GAO 2'den büyükse kaldı)

60-69 arası CC
70-74 arası CB
75-84 arası BB
85-89 arası BA
90-100 arası AA

____________________________________________________________________

DERS 4:

Kod yazarken yazım kurallarına ve evrensel Clean Code etiğine uygun yazmaya özen gösterilmeli.

Camel Casing
Pascal Casing

A#, C#, F# araştır.
Dünyadaki en akıllı arama motoru Wolfram Alpha

CMS Nedir? Program üreten program..(!)


LightSwitch: HTML ve CSS ile masaüstü uygulama geliştirme.
Visual Studio > Menu > Window > Reset Window Layer
AssemblyInfo.cs







TURKISH CI_AS







____________________________________________________________________

NOTLAR:

Meta keyword, SEO..
WPF nedir?
GoTo Defination

Cross-cutting concern
https://en.wikipedia.org/wiki/Cross-cutting_concern
Asenkron, await..
Kod yazan kodu yazmak..
Core code...
Tasking

        */
    }
}