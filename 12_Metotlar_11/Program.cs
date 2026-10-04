namespace _12_Metotlar_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen değerler arasında rastgele sayı üreten ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdir() isimli bir daha yazarak elemaları listeleyin
            //Daha sonra bu dizi içerisinde EnBuyukDeger() ve EnKucukDeger() bulan metotları yazınız.
            //Kullanıcının bütün hatalarını öngörerek kodlayınız.

            int[] sayilar = new int[10];

            SayiUret(sayilar);

            DiziYazdir(sayilar);

            int enBuyukSayi = EnBuyukDeger(sayilar);
            int enKucukSayi = EnKucukDeger(sayilar);

            Console.WriteLine("En Büyük:"+enBuyukSayi);
            Console.WriteLine("En Küçük:"+enKucukSayi);
        }

        static void SayiUret(int[] sayilar)
        {
            Console.WriteLine("Başlangıç Sayısı:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısı:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = r.Next(basla, bitis);
                sayilar[i] = sayi;

            }
        }

        static void DiziYazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        static int EnBuyukDeger(int[] dizi)
        {
            int enBuyuk = dizi[0];

            foreach (int sayi in dizi)
            {
                if (enBuyuk < sayi)
                {
                    enBuyuk = sayi;
                }
            }

            return enBuyuk;
        }

        static int EnKucukDeger(int[] dizi)
        {
            int enKucuk = dizi[0];

            foreach (int sayi in dizi)
            {
                if (enKucuk > sayi)
                {
                    enKucuk = sayi;
                }
            }

            return enKucuk;
        }
    }
}
