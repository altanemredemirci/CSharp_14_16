using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_2
{
    internal class Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

        public static void Kayit(List<Ogrenci> liste)
        {
            Ogrenci ogrenci = new Ogrenci();
            
            Console.WriteLine("Numara:");
            ogrenci.Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();

            liste.Add(ogrenci);
        }
    }
}
