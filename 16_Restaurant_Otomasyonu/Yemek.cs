using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Yemek
    {
        public int No;
        public string Ad;
        public double Fiyat;

        internal static void Ekle(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            if (secilenMenu == null)
            {
                Console.WriteLine("Hatalı Menü Seçimi!!");
                return;
            }

            Console.WriteLine("Yemek Adı:");
            string yemekAdi = Console.ReadLine();

            bool varMi = secilenMenu.Yemekler.Any(i => i.Ad == yemekAdi);

            if (varMi)
            {
                Console.WriteLine("Kayıtlı Yemek!!");
                return;
            }

            Yemek yemek = new Yemek();
            
            int no=0;
            secilenMenu.Yemekler.ForEach(i => no = i.No);

            yemek.No = no + 1;
            yemek.Ad = yemekAdi;

            Console.WriteLine("Fiyatı:");
            yemek.Fiyat = Convert.ToDouble(Console.ReadLine());

            secilenMenu.Yemekler.Add(yemek);

            Console.WriteLine($"{secilenMenu.Ad} menüsüne {yemek.Ad} yemeği eklendi.");
        }

        internal static void Sil(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            if (secilenMenu == null)
            {
                Console.WriteLine("Hatalı Menü Seçimi!!");
                return;
            }

            Yemek secilenYemek = Siparis.YemekSec(secilenMenu);

            if (secilenYemek == null)
            {
                Console.WriteLine("Hatalı Yemek Seçimi!!");
                return;
            }

            secilenMenu.Yemekler.Remove(secilenYemek);
            Console.WriteLine($"{secilenMenu.Ad} menüsüne {secilenYemek.Ad} yemeği silindi.");
        }

        internal static void Guncelle(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            if (secilenMenu == null)
            {
                Console.WriteLine("Hatalı Menü Seçimi!!");
                return;
            }

            Yemek secilenYemek = Siparis.YemekSec(secilenMenu);
            
            if (secilenYemek == null)
            {
                Console.WriteLine("Hatalı Yemek Seçimi!!");
                return;
            }

            Console.WriteLine("Yeni Fiyat:");
            secilenYemek.Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{secilenMenu.Ad} menüsüne {secilenYemek.Ad} yemeği güncellendi.");
        }
    }
}
