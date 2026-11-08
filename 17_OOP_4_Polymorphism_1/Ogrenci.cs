using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_4_Polymorphism_1
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;

        public virtual void Kaydet() //İstenilen yerde yeniden yazılabilir.
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }

    internal class IlkOkul : Ogrenci
    {

    }

    internal class OrtaOkul : Ogrenci
    {
        public int Not { get; set; }

        //virtual tanımlı metodu override ile ezerek yeniden metot tanımladık.
        public override void Kaydet() 
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("Not:");
            Not = Convert.ToInt32(Console.ReadLine());
        }
    }


}
