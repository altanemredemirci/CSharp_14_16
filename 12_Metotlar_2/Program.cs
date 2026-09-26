namespace _12_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı alan ve büyük olan sayıyı ekrana yazdıran metodu tanımlayınız.

            BuyukBul();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //BuyukBul();



            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            BuyukBul(sayi1, sayi2);
        }

        static void BuyukBul()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }
        }

        static void BuyukBul(int sayi1,int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }
        }
    }
}
