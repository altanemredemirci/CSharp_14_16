using System.Globalization;

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

            #region FOR 

            //int i = 0;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i=0; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #region Kullanıcıdan başlangıç ve bitiş değerlerini alınız. Bu aralıktaki sayıları ekrana yazdırınız.

            //Console.WriteLine("Başlangıç değeri:");
            //int basla = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitiş değeri:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //if (basla > bitis) 
            //{
            //    Console.WriteLine("Başlangıç değeri Bitiş değerinden küçük olmalıdır.");
            //}
            //else
            //{
            //    for (int i = basla; i < bitis; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //2. Yol
            //if (basla > bitis)
            //{
            //    //basla ile bitis takas etmek
            //    int temp = basla;
            //    basla = bitis;
            //    bitis = temp;
            //}

            //for (int i = basla; i < bitis; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Kullanıcıdan alınan bir sayının faktöriyelini hesaplayınız.
            //5 => 1*2*3*4*5 = 120

            //Console.WriteLine("Faktöriyel hesaplanacak sayı?");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int faktoriyel = 1;

            //for (int i = sayi; i >= 1; i--)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine(faktoriyel);
            #endregion

            #region 1-500 arasındaki sayıların içinde 13. katlarının kaç adet olduğunu ve toplamlarını hesaplayınız.

            //int adet = 0;
            //int toplam = 0;

            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        adet++;
            //        toplam += i;
            //    }
            //}

            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Adet:"+adet);

            #endregion

            #region RANDOM

            //Belirlenen aralıkta rastgele bir int-tamsayı oluşturur.

            //Random r = new Random(); //Instance - Random classından bir örnek alma denir.

            //Console.WriteLine(r.Next(1, 100));


            //while (true)
            //{
            //    int rastgele = r.Next(1, 10);

            //    Console.WriteLine(rastgele);
            //    Thread.Sleep(1000);
            //}


            #endregion

            #region Bilgisayar 1-100 aralığında bir rastgele sayı tutsun. Kullanıcı 5 hakkında bu rastgele sayıyı tahmin etmeye çalışsın. her tahmin sonra Tahmininizi Küçültünüz veya Büyültünüz gibi yönlendirmeler yapalım

            //Random r = new Random();

            //int rastgele = r.Next(1, 100);
            //Console.WriteLine(rastgele);
            //int hak = 5;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    hak--;

            //    if (tahmin == rastgele)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        break;
            //    }

            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Bitti.");
            //    }

            //    else if (tahmin > rastgele)
            //    {
            //        Console.WriteLine("Tahmininizi Küçültünüz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tahmininizi Büyültünüz.");
            //    }
            //}



            // Random r = new Random();

            // int rastgele = r.Next(1, 100);
            // //Console.WriteLine(rastgele);


            //for(int i=8; i>0; i--)
            // {
            //     Console.WriteLine("Tahmininiz:");
            //     int tahmin = Convert.ToInt32(Console.ReadLine());


            //     if (tahmin == rastgele)
            //     {
            //         Console.WriteLine("Tebrikler");
            //         break;
            //     }

            //     else if (i == 1)
            //     {
            //         Console.WriteLine("Sayı:"+rastgele);
            //         Console.WriteLine("Hakkınız Bitti.");
            //     }

            //     else if (tahmin > rastgele)
            //     {
            //         Console.WriteLine("Tahmininizi Küçültünüz.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Tahmininizi Büyültünüz.");
            //     }
            // }



            #endregion
            #region Aşağıdaki şekilleri for döngüsü ile oluşturunuz

            /*
              
             *
             **
             ***
             ****
             *****
             ******
             *******             
             
             */

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            /*
             **********************
             *                    *
             *                    *
             *                    *
             *                    *
             *                    *
             *                    *
             *                    *
             **********************
             */

            //for (int i = 0; i < 10; i++)
            //{
            //    if(i==0 || i == 9)
            //    {
            //        Console.Write("*******************");
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //        for (int j = 0; j < 17; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            /*
                *
               ***
              *****
             *******
            *********
           ***********

             */

            //int bosluk = 10;

            //for (int i = 1; i < 19; i+=2) 
            //{
            //    for (int k = 0; k < bosluk; k++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    bosluk--;

            //    Console.WriteLine();
            //}

            /*
             1*1=1    2*1=2    3*1=3
             1*2=2    2*2=4
             1*3=3    2*3=6
             
             
             */

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write(j+"x"+i+"="+(i*j)+"\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Kullanıcıdan alınan sayının asal olup olmadığını ekrana yazdıralım
            //Asal Sayı kendisi ve 1 haricinde hiç bir sayıya bölünmeyen sayıdır.
            //2,3,5,7,11,13,17

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi < 2)
            //{
            //    Console.WriteLine("Asal Değildir.");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("Asaldır.");
            //}
            //else
            //{
            //    bool AsalMi = true;
            //    for (int bolen = 2; bolen < sayi; bolen++)
            //    {
            //        if (sayi % bolen == 0)
            //        {
            //            AsalMi = false;
            //            break;
            //        }
            //    }
            //    if (AsalMi) //ASalMi==true
            //    {
            //        Console.WriteLine("Asaldır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Asal Değildir.");
            //    }

            //}
            #endregion

            #region 1000000 a kadar asal olan sayıları ekrana yazdırınız

            //for (int sayi = 2; sayi < 10000; sayi++)
            //{
            //    if (sayi == 2)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    else
            //    {
            //        bool AsalMi = true;
            //        for (int bolen = 2; bolen < sayi; bolen++)
            //        {
            //            if (sayi % bolen == 0)
            //            {
            //                AsalMi = false;
            //                break;
            //            }
            //        }
            //        if (AsalMi) //ASalMi==true
            //        {
            //            Console.WriteLine(sayi);
            //        }                  

            //    }
            //}




            #endregion

            #endregion

            #region DO WHILE
            //Do While döngüsü diğer döngülerin aksine önce işlemi yapar sonra koşul kontrolü sağlar.
            //do
            //{

            //} while (true);

            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i<11);


            #region Kullanıcı 0 girene kadar girilen sayıları toplayınız

            int toplam = 0;
            int sayi;
            do
            {
                Console.WriteLine("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi;

            } while (sayi!=0);

            Console.WriteLine("Sonuç:"+toplam);
            #endregion


            #endregion




        }
    }
}
