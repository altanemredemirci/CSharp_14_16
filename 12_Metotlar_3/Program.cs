
using _12_Metotlar_4;

namespace _12_Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //METOT İMZASI:Aynı isimle birden fazla metot tanımlamayı sağlar. Metot imzası, parametre sayısı veya parametrenin veri tipi farklı olmasıyla sağlanır.

            //Aynı isimli metotlar farklı parametreler ile tanımlanabilir. Buna metot overloading denir.

            //Topla(10, 10);


            Matematik.Toplama();
        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void Topla(double sayi1, int sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void Topla(int sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void Topla(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
