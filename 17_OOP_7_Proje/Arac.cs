using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_7_Proje
{
    abstract internal class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Plaka { get; set; }
        public double GunlukKiralamaBedeli { get; set; }

        public Arac(string marka, string model, int yil, string plaka, double gunlukKiralamaBedeli)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Plaka = plaka;
            GunlukKiralamaBedeli = gunlukKiralamaBedeli;
        }

        abstract public double KiraUcretiHesapla(int gun);
        abstract public void AracBilgileriniGoster();
        abstract public string AracTipiGetir();

        public virtual void GenelBilgi()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Plaka);
            Console.WriteLine(Yil);
            Console.WriteLine(GunlukKiralamaBedeli);
        }
    }
}
