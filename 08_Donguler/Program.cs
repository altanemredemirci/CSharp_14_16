namespace _08_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *** DÖNGÜLER ***
            *While
            *For
            *Do While
            *Foreach             
             */

            //Döngüler: Tekrarlı çalışan kod bloklarını belirli bir koşula bağlı olarak tekrarlayan yazılım yapılarıdır.

            #region WHILE

            //1-10 aralığında sayıları ekrana yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //int i = 1;

            //int dongu = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //    if (i == 11 && dongu == 1)
            //    {
            //        i = 1;
            //        dongu++;
            //    }
            //}


            #region 250-50 aralığındaki sayıları ekrana yazdırınız

            //int i = 250;

            //while (i > 50)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            #endregion

            #region 250-50 aralığındaki 3'ün katı olan sayıları ekrana yazdırınız

            //int i = 250;

            //while (i > 50)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }              
            //    i--;
            //}

            #endregion

            #region 250-50 aralığındaki 3'ün katı kaç adet sayı olduğunu ekrana yazdırınız
            //int i = 250;
            //int sayac = 0;
            //while (i > 50)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sayac++;
            //    }
            //    i--;
            //}

            //Console.WriteLine("Sayaç:"+sayac);


            #endregion

            #region 1-10 aralığındakis sayıları toplamını ekrana yazdırınız

            //int toplam = 0;
            //int i = 1;
            //while (i < 11)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region 1-100 aralığındaki tek sayıları ayrı çift sayıları ayrı toplayarak sonuçları ekrana yazdırınız

            //int tekToplam = 0;
            //int ciftToplam = 0;
            //int i = 1;

            //while (i < 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }
            //    i++;
            //}

            //Console.WriteLine("Çift Toplam:"+ciftToplam);
            //Console.WriteLine("Tek Toplam:"+tekToplam);

            #endregion

            #region BREAK ve CONTINUE

            //break: İçinde bulunduğu döngüyü kırar(bitirir).

            //int i = 1;
            //while (i < 10)
            //{
            //    if (i == 7) //i 7 olduğunda döngü bitsin
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}


            //continue: Döngü içerisinde okunduğunda tekrar döngü koşuluna geri döner.


            //int i = 1;
            //while (i < 10)
            //{
            //    if (i == 7) //i 7 olduğunda döngü bitsin
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}


            #endregion

            #region WHILE(true)

            //Kullanıcı 0 girene kadar girilen sayıları toplayınız.0 girildiğinde sonucu ekrana yazdırınız
            //int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı Giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}

            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            

            #endregion


        }
    }
}
