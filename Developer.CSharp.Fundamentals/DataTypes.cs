using System;

namespace Developer.CSharp.Fundamentals
{
    public class DataTypes
    {
        public static void Run()
        {
            //VERİ TİPLERİ

            // Tam Sayı Veri Tipleri

            byte birinciSayi = 255;          // 1 byte yer kaplar, 0-255 arası tam sayı değer alır.
            sbyte ikinciSayi = -128;         // 1 byte yer kaplar, -128 ile +127 arasında tam sayı değer alır.
            short ucuncuSayi = -32768;       // 2 byte yer kaplar, -32768 ile + 32767 arasında tam sayı değer alır.
            ushort dorduncuSayi = 65535;     // 2 bayt yer kaplar, 0 ile 65535 arası tam sayı değer alır.
            int integerSayi = -1400000000;   // 4 byte yer kaplar, -1.4 milyar ile + 1.4 milyar arasında tam sayı değer alır.
            uint uIntegerSayi = 2800000000;  // 4 byte yer kaplar, 0 ile 2.8 milyar arasında tam sayı değer alır.
            long longSayi = 0;               // 8 byte yer kaplar, -çok +çok arasında değer alır.
            ulong uLongSayi = 0;             // 8 byte yer kaplar, 0 ile +çoook arasında tam sayı değer alır.

            // Ondalıklı (Reel) Veri Tipleri
            float dortByte;
            double sekizByte;
            decimal onAltiByte;



            // Metin taşıyan veri tipleri
            char karakter = 'a'; // 2 byte yer kaplar, içine 1 karakter alabilir.
            string yazi = "Batuhan"; // Sınırsız uzunlukta metin alır, her bir karakteri 2 byte yer kaplar.



            // OBJECT
            object nesne = "herhangi bir veri tipini içine alır"; // gelen verinin tipi bilinmiyorsa 'var' ile karşılanır.


            //byte ikinciSayi = birinciSayi;
            //Console.WriteLine(ikinciSayi);
            //Console.Read();

            int value1 = 125;
            int value2 = 110;

            string text1 = "125";
            string text2 = "110";

            Console.Write(text1 + text2);
            Console.Read();
        }

        // *** INTEGRAL TYPES *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      byte            Byte                                    1 byte          0 to 255                                Unsigned integer
         *      sbyte           SByte                                   1 byte          -128 to +127                            Signed integer
         *      short           Int16                                   2 byte          -32,768 to 32,767                       Signed integer
         *      ushort          UInt16                                  2 byte          0 to 65,535                             Unsigned integer
         *      int             Int32                                   4 byte          -2,147,483,648 to 2,147,483,647         Signed integer
         *      uint            UInt32                                  4 byte          0 to 4294967295                         Unsigned integer
         *      long            Int64                                   8 byte          -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  Signed integer
         *      ulong           UInt64                                  8 byte          0 to 18,446,744,073,709,551,615         Unsigned integer
         *      char            Char                                    2 byte          Unicode symbols used in text            A single Unicode character
         */


        // ***  FLOATING POINT TYPES *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      float           Single                                  4 byte          -3.402823e38 to 3.402823e38             Single-precision floating point type
         *      double          Double                                  8 byte          -1.79769313486232e308 to 1.79769313486232e308  Double-precision floating point type
         */


        // ***  DECIMAL TYPES *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      decimal         Decimal                                 16 byte         (+ or -)1.0 x 10e-28 to 7.9 x 10e28     Precise fractional or integral type that can represent decimal numbers with 29 significant digits
         */


        // ***  BOOLEAN TYPES *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      bool            Boolean                                 1 byte          True or False                           Logical Boolean type
         */


        // ***  REFERENCE TYPES *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      string          String                                  ------          ------                                  A sequence of characters
         *      object          Object                                  ------          ------                                  Base type of all other types
         */


        // *** IMPLICITLY DATA TYPE *** //

        /*      ALIAS           .NET TYPE           T-SQL TYPE          SIZE            RANGE (VALUES)                          TYPE
         *      var             var                                     ------          ------                                  Data type is derived (implied) from the context
         */


        // ***  NULLABLE DATA TYPES *** //

        /*
                using System;
					
                public class Program
                {
	                public static void Main()
	                {
		                Nullable<int> i = null;
   		                Console.WriteLine(i.GetValueOrDefault()); 
	                }
                }
         */


        // ***  POINTER TYPE *** //

        /*
            Pointer Type variables store the memory address of another type.
            Pointers in C# have the same capabilities as the pointers in C or C++.

                Syntax for declaring a pointer type is  −---->   type* identifier;

                For example,

                char* cptr;
                int*  iptr;

            Look for 'Unsafe Codes' for more information.
        */
    }
}