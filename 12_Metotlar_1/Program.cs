namespace _12_Metotlar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ***** METOTLAR *****
             *  Metotlar () parantezleri ile tanımlanan {} içerisinde yazılan kod bloğunun ihtiyaç duyulduğu zaman çalıştıran bir yazılım yapısıdır.
             
             Belirli bir işin kodunu bir başlık altında tanımlamayarak o işe ihtiyaç duyulduğu her zaman başlığı yazarak kodu çalıştırdığımız bir yazılım yapısıdır.

            * Metotlar iç içe tanımlanamaz.
            * Metotlar tanımlandıktan sonra çağrılmadıkları(adları yazılmadığı) takdirde çalışmazlar.
            
             * Metotlar 2'ye ayrılır.
             * 1.Değer Döndürmeyen Metot (parametreli/parametresiz)
             * 2.Değer Döndüren Metot (parametreli/parametresiz)
             
             */

            //Yaz();
            //Oku();

            //AdYaz("Altan Emre");

            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();

            //AdYaz(ad);


            //Topla();



            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Topla(sayi1, sayi2);
        }

        static void Yaz()
        {
            Console.WriteLine("Ben bir metodum.");
            //Oku();
        }

        static void AdYaz(string isim)
        {
            Console.WriteLine(isim);
        }

        static void Oku()
        {
            Console.WriteLine("Metot Okundu.");
        }

        //Parametresiz Metot
        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2+sayi1);
        }

        //Parametreli Metot
        static void Topla(int s1, int s2)
        {
            Console.WriteLine(s1+s2);
        }
    }
}
