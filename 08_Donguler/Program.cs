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
            int i = 250;
            int sayac = 0;
            while (i > 50)
            {
                if (i % 3 == 0)
                {
                    sayac++;
                }
                i--;
            }

            Console.WriteLine("Sayaç:"+sayac);


            #endregion
            #endregion


        }
    }
}
