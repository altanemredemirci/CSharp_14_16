namespace _12_Metotlar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı bir işlem bilgisi alan ve belirtilen işlemi sayılara uygulayarak sonucu ekrana yazdıran metodu yazınız

            #region 1.YOL
            //Console.WriteLine("1.Sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem(+,-,*,/):");
            //string islem = Console.ReadLine();

            //if (islem == "+")
            //{
            //    DortIslem.Toplama(sayi1, sayi2);
            //}
            //else if (islem == "-")
            //{
            //    DortIslem.Cikarma(sayi1, sayi2);
            //}
            //else if (islem == "*")
            //{
            //    DortIslem.Carpma(sayi1, sayi2);
            //}
            //else if (islem == "/")
            //{
            //    DortIslem.Bolme(sayi1, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı İşlem!!");
            //}
            #endregion

            #region 2.YOL
            //Hesapla();
            #endregion

            #region 3.YOL
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem(+,-,*,/):");
            string islem = Console.ReadLine();

            HesaplaParametreli(sayi1, sayi2, islem);
            #endregion

        }

        static void Hesapla()
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

        static void HesaplaParametreli(int sayi1,int sayi2,string islem)
        {
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
