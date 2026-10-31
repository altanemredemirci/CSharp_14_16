using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Masa
    {
        public int No;
        public bool DoluMu=false;
        public double Hesap;

        internal static Masa MasaDoldur(List<Masa> liste)
        {
            foreach (Masa masa in liste)
            {
                if (!masa.DoluMu)
                {
                    masa.DoluMu = true;
                    return masa;
                }
            }
            return null;
        }

        internal static void MasaDurumu(List<Masa> liste)
        {
            foreach (Masa masa in liste)
            {
                Console.WriteLine(masa.No+"- Dolu Mu:"+(masa.DoluMu==false ? "Boş" : "Dolu"));
            }
        }

        //ref:metot dışarıda tanımlanmış bir değeri değiştirecek ise ref anahtarı kullanılır.
        public static int HesapOde(List<Siparis> siparisler, List<Masa> masalar, ref double kazanc)
        {
            Console.WriteLine("Masa No:");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            foreach (Siparis item in siparisler)
            {
                if (item.MasaNo == masaNo)
                {
                    double hesap = item.Siparisler.Select(i => i.Fiyat).Sum();

                    Console.WriteLine("Hesap:"+hesap);
                    Console.WriteLine("Ödendi Mi?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        kazanc = kazanc + hesap;
                        siparisler.Remove(item);
                        Masa masa = masalar.FirstOrDefault(i => i.No == masaNo);
                        masa.DoluMu = false;
                        return 1;
                    }

                    return -100;
                }
            }

            return -101;
        }
    }
}
