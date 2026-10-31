using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Menu
    {
        public int No;
        public string Ad;
        public List<Yemek> Yemekler;

        public static Menu MenuSec(List<Menu> Menuler)
        {
            foreach (Menu menu in Menuler)
            {
                Console.WriteLine(menu.No+"-"+menu.Ad);
            }

            Console.WriteLine("Menu No:");
            int menuNo = Convert.ToInt32(Console.ReadLine());

            return Menuler.FirstOrDefault(i => i.No == menuNo);
        }
    }
}
