namespace _12_Metotlar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topla();

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
    }
}
