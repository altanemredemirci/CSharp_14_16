namespace _09_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

               **** ARRAYS - Diziler ****
            *Değişkenler tek bir veri tutarken, diziler aynı veri tipinde birden fazla veri tutabilirler.
            *Index adı verilen 0'dan başlayarak 1'er 1'er artan numalandırma yöntemi ile verileri tutarlar.
            *[] dizi tanımlarken kullanılır.

             */

            //int sayi = 10;

            //int[] sayilar = { 11, 22, 33, 44, 55 }; // Dolu Dizi Tanımlama

            //string[] isimler = new string[10]; //10 elemanlı boş dizi tanımlama

            //isimler[3] = "Altan Emre"; //Index numarası üzerinden değer eklendi.

            //Console.WriteLine(sayilar[2]); //index numarası üzerinden değer okundu.

            //Console.WriteLine("Adınız:");
            //isimler[0] = Console.ReadLine();


            //string[] isimler = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Adınız:");
            //    isimler[i] = Console.ReadLine();
            //}


            #region Kullanıcıdan alınan 5 adet sayı bir diziye atayınız ve bu diziyi ekrana yazdırınız.

            int[] sayilar = new int[5];

            //Dizi doldurma alanı
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayı:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Dizi yazdırma alanı
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            #endregion
        }
    }
}
