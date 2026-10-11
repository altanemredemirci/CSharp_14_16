using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_3
{
    internal class Kitap
    {
        public int BarkodNo;
        public string KitapAdi;
        public string YazarAdi;

        //public static void Kaydet(List<Kitap> kitaplar)
        //{
        //    Kitap kitap = new Kitap();

        //    Console.WriteLine("Barkod No:");
        //    kitap.BarkodNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Kitap Adı:");
        //    kitap.KitapAdi = Console.ReadLine();
        //    Console.WriteLine("Yazar Adı:");
        //    kitap.YazarAdi = Console.ReadLine();

        //    kitaplar.Add(kitap);
        //}

        //public void KaydetNonStatic()
        //{
        //    Console.WriteLine("Barkod No:");
        //    BarkodNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Kitap Adı:");
        //    KitapAdi = Console.ReadLine();
        //    Console.WriteLine("Yazar Adı:");            
        //    YazarAdi = Console.ReadLine();
        //}

        public static Kitap Kaydet()
        {
            Kitap kitap = new Kitap();

            Console.WriteLine("Barkod No:");
            kitap.BarkodNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitap Adı:");
            kitap.KitapAdi = Console.ReadLine();
            Console.WriteLine("Yazar Adı:");
            kitap.YazarAdi = Console.ReadLine();

            return kitap;
        }

    }


}
