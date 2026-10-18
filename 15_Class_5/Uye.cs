using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_5
{
    internal class Uye
    {
        public string AdSoyad;
        public string KullaniciAdi;
        public string Email;
        public string Sifre;


        public static void Kaydet(List<Uye> liste)
        {
            Uye uye = new Uye();
            Console.WriteLine("Ad Soyad:");
            uye.AdSoyad = Console.ReadLine();

            Console.WriteLine("Kullanici Adi:");
            uye.KullaniciAdi = Console.ReadLine();

            Console.WriteLine("Email:");
            uye.Email = Console.ReadLine();

            Console.WriteLine("Şifre:");
            uye.Sifre = Console.ReadLine();

            liste.Add(uye);
        }

        public static bool Sil(List<Uye> liste)
        {
            //foreach (Uye uye in liste)
            //{
            //    Console.WriteLine($"{uye.KullaniciAdi} - {uye.Email}");
            //}

            liste.ForEach(i => Console.WriteLine($"{i.KullaniciAdi} - {i.Email}"));

            Console.WriteLine("Silinecek Kullanıcı Adı:");
            string kullaniciAdi = Console.ReadLine();

            //foreach (Uye uye in liste)
            //{
            //    if (uye.KullaniciAdi == kullaniciAdi)
            //    {
            //        liste.Remove(uye);
            //        return true;
            //    }
            //}

           Uye silinecekUye =  liste.Where(i => i.KullaniciAdi == kullaniciAdi).FirstOrDefault();

            if (silinecekUye != null)
            {
                liste.Remove(silinecekUye);
                return true;
            }
            else
            {
                return false;
            }
           
           
        }

        public static bool Sil(List<Uye> liste, string kullaniciAdi)
        {
            foreach (Uye uye in liste)
            {
                if (uye.KullaniciAdi == kullaniciAdi)
                {
                    liste.Remove(uye);
                    return true;
                }
            }

            return false;
        }

        public static bool Guncelle(List<Uye> liste)
        {
        //    foreach (Uye uye in liste)
        //    {
        //        Console.WriteLine($"{uye.KullaniciAdi} - {uye.Email}");
        //    }

            liste.ForEach(i => Console.WriteLine($"{i.KullaniciAdi} - {i.Email}"));

            Console.WriteLine("Güncellenecek Kullanıcı Adı:");
            string kullaniciAdi = Console.ReadLine();

            foreach (Uye uye in liste)
            {
                if (uye.KullaniciAdi == kullaniciAdi)
                {
                    Console.WriteLine("Yeni AdSoyad:");
                    uye.AdSoyad = Console.ReadLine();

                    Console.WriteLine("Yeni Email:");
                    uye.Email = Console.ReadLine();

                    Console.WriteLine("Yeni Kullanıcı Adı:");
                    uye.KullaniciAdi = Console.ReadLine();

                    Console.WriteLine("Yeni Şifre:");
                    uye.Sifre = Console.ReadLine();

                    return true;
                }
            }

            Uye guncelenecekUye = liste.Where(i => i.KullaniciAdi == kullaniciAdi).FirstOrDefault();

            if (guncelenecekUye != null)
            {
                Console.WriteLine("Yeni AdSoyad:");
                guncelenecekUye.AdSoyad = Console.ReadLine();

                Console.WriteLine("Yeni Email:");
                guncelenecekUye.Email = Console.ReadLine();

                Console.WriteLine("Yeni Kullanıcı Adı:");
                guncelenecekUye.KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Yeni Şifre:");
                guncelenecekUye.Sifre = Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
