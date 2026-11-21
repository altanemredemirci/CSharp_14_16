namespace _18_Generic_2_Type_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tipini kullanan bir Ürün nesnesi
            Urun<int> urun = new Urun<int>(500,20);

            //double ve decimal ile overload edilmiş versiyonu kullanan bir Ürün nesnesi
            Urun<double, decimal> urun2 = new Urun<double, decimal>(1000.0, 18.0m);

            Urun<int, double> urun3 = new Urun<int, double>(1200, 18.0);
        }
    }
}
