using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_6_Constructor_3
{
    internal class Kitap
    {
        internal string ISBN;
        internal string Ad;
        internal string Yazar;
        internal bool Durum;


        internal static void Ekle(List<Kitap> liste)
        {
            Kitap kitap = new Kitap();
            Console.WriteLine("ISBN:");
            kitap.ISBN = Console.ReadLine();

            Console.WriteLine("Ad:");
            kitap.Ad = Console.ReadLine();

            Console.WriteLine("Yazar:");
            kitap.Yazar = Console.ReadLine();

            kitap.Durum = true;

            liste.Add(kitap);
        }

        internal static bool Sil(List<Kitap> liste)
        {
            Listele(liste);

            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            Kitap silinen = liste.FirstOrDefault(i => i.ISBN == ISBN);

            if (silinen != null)
            {
                liste.Remove(silinen);
                return true;
            }

            return false;
        }


        internal static void KitapAra(List<Kitap> liste)
        {
            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            Kitap aranan = liste.FirstOrDefault(i => i.ISBN == ISBN);

            if (aranan != null)
            {
                Console.WriteLine("ISBN:"+aranan.ISBN);
                Console.WriteLine("Kitap Adı:"+aranan.Ad);
                Console.WriteLine("Yazar Adı:"+aranan.Yazar);
                Console.WriteLine("Durum:"+(aranan.Durum==true ? "Ödünç Verilebilir" : "Ödünç Verilemez"));
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }
        }

        internal static void Listele(List<Kitap> liste)
        {
            foreach (Kitap item in liste)
            {
                Console.WriteLine($"{item.ISBN}-{item.Ad}");
            }
        }

    }
}
