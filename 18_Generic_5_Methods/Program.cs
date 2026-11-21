namespace _18_Generic_5_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] metinler = { "Kaan", "Efe", "Ege", "Buse" };
            bool[] durumlar = { true, false, true, false };
            int[] sayilar = { 1, 2, 3 };
            char[] karakterler = { 'a', 'b', 'c', };

            GenericDiziBoyutlandir(ref metinler, 10);
            GenericDiziBoyutlandir(ref durumlar, 10);
            GenericDiziBoyutlandir(ref sayilar, 10);
            GenericDiziBoyutlandir(ref karakterler, 10);
        }

        static void GenericDiziBoyutlandir<T>(ref T[] dizi, int yeniBoyut)
        {
            T[] yeniDizi = new T[yeniBoyut];
            dizi.CopyTo(yeniDizi, 0);
            dizi = yeniDizi;
        }
    }
}
