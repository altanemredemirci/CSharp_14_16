using System.Security.Cryptography;

namespace _12_Metotlar_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün ister misiniz? sorusunu soran Evet cevabında 3. ürünün fiyatını alarak %50 indirim uygulayan metodu yazınız.
            #endregion

            Indirim2();
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
                //Console.WriteLine("3.Ürün Fiyatı:");
                //double fiyat3 = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2+(fiyat3/2)));

                Indirim3(fiyat1, fiyat2);
            }
            else
            {
                Console.WriteLine("Ödeme:"+(fiyat1+fiyat2));
            }

        }

        static void Indirim3(double f1, double f2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ödeme:" + (f1 + f2 + (f3 / 2)));
        }


    }
}
