namespace _12_Metotlar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static : Bir class altında tanımlı bir yapıya direk class ismi üzerinden erişim yapmamı sağlar.

            //Static Metot kullanımı
            Matematik.Hesapla();

            //NonStatic Metot Kullanımı
            //Matematik matematik = new Matematik(); //Nesne Oluşturma işlemi Instance
            //matematik.Hesapla();
        }
    }

    class Matematik //Erişim belirteci vermezsek default olarak internal alır.
    {
        internal static void Hesapla() //Erişim belirteci vermezsek default olarak private alır.
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem(+,-,*,/):");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(sayi1 - sayi2);
            }
            else if (islem == "*")
            {
                Console.WriteLine(sayi1 * sayi2);
            }
            else if (islem == "/")
            {
                Console.WriteLine(sayi1 / sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı İşlem!!");
            }
        }
    }

}
