namespace _12_Metotlar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer Dönren metotlarda metot tanımlanırken döndüreceği veri tipi yazılır. Metot bitişinde ise return ile sonuc çağrıldığı yere geri taşınır.


            //Topla();

            //int sonuc = Topla2();

            //Console.WriteLine(sonuc);

            #region Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün ister misiniz? sorusunu soran Evet cevabında 3. ürünün fiyatını alarak %50 indirim uygulayan metodu yazınız.

            #endregion

            Indirim2();

        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1+sayi2);
        }


        static int Topla2()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = 13;
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi2 + sayi1;
            return toplam;
        }

        static void Indirim2()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat1 > fiyat2)
            {
                fiyat1 = fiyat1 * 0.7;
            }
            else
            {
                fiyat2 = fiyat2 * 0.7;
            }

            Console.WriteLine("3.ürün ister misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                double fiyat3 = Indirim3();

                Console.WriteLine(fiyat3+fiyat2+fiyat1);
            }
            else
            {
                Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2));
            }

        }

        static double Indirim3()
        {
            Console.WriteLine("3.ürün fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            return f3 / 2;
        }
    }
}
