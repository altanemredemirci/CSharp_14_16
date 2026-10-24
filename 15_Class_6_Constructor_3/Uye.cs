using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_6_Constructor_3
{
    internal class Uye
    {
        internal int UyeNo;
        internal string AdSoyad;
        internal List<Kitap> AldigiKitaplar;

        internal static void Ekle(List<Uye> liste)
        {
            Uye uye = new Uye();
            Console.WriteLine("No:");
            uye.UyeNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad:");
            uye.AdSoyad = Console.ReadLine();

            uye.AldigiKitaplar = new List<Kitap>();

            liste.Add(uye);
        }

        internal static void Listele(List<Uye> liste)
        {
            foreach (Uye uye in liste)
            {
                Console.WriteLine("Üye No:"+uye.UyeNo);
                Console.WriteLine("Üye Ad Soyad:"+uye.AdSoyad);
                if (uye.AldigiKitaplar.Count > 0)
                {
                    foreach (Kitap kitap in uye.AldigiKitaplar)
                    {
                        Console.WriteLine("ISBN:" + kitap.ISBN);
                        Console.WriteLine("Kitap Adı:" + kitap.Ad);
                        Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                    }
                }
            }
        }
    }
}
