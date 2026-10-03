using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Metotlar_4
{
    public class Matematik //Default internal erişim özelliği alır. 
    {
        //DATA ACCESS MODIFIER (Erişişm Belirteci)
        /*
         public: Bütün solution tarafından erişilebilir.
         internal: Kendi projesi içerisinde erişilebilir.
         protected:
         private: Kendi classı içerisinde erişilebilir.
         internal protected:
         
         */
        internal static void Toplama() //Default private erişim özelliği alır.
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void Yaz()
        {
            Toplama();
        }
    }    
}
