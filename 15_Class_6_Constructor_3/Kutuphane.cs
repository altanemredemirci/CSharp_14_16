using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_6_Constructor_3
{
    internal class Kutuphane
    {
        internal static List<Kitap> Kitaplar = new List<Kitap>();
        internal static List<Uye> Uyeler = new List<Uye>();

        public static void OduncAl()
        {
            Kitap.Listele(Kitaplar);

            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();

            Kitap oduncVerilecekKitap = Kitaplar.FirstOrDefault(i => i.ISBN == isbn && i.Durum == true);

            if (oduncVerilecekKitap != null)
            {
                Console.WriteLine("Üye Numarası:");
                int no = Convert.ToInt32(Console.ReadLine());

                Uye uye = Uyeler.FirstOrDefault(i => i.UyeNo == no);

                if(uye != null)
                {
                    oduncVerilecekKitap.Durum = false;
                    uye.AldigiKitaplar.Add(oduncVerilecekKitap);
                }
                else
                {
                    Console.WriteLine("Üye Bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }
        }

        public static void OduncListele()
        {
            foreach (Kitap kitap in Kitaplar)
            {
                if (kitap.Durum == false)
                {
                    Console.WriteLine("ISBN:" + kitap.ISBN);
                    Console.WriteLine("Kitap Adı:" + kitap.Ad);
                    Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                }
            }
        }
    }
}
