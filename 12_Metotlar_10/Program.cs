namespace _12_Metotlar_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEFAULT DEĞER
            //Metotlara parametre olarak default bir değer atanabilir. Bu atama işlemi parametre gödnerilmezse verilen default değeri kullanması içindir.

            //Yaz("Altan Emre");

            //Yaz();

            //Topla(1, 2);

            //Topla();
            #endregion

            #region OUT KEYWORD
            //Metoda gönderilen parametredeki değişkenin metot işlemi sonucunda değiştirilmesini istiyorum. Metot kendisine gönderilen değeri manipüle etsin.
            //out kelimesi ile gönderilen parametreye ilk değer atama zorunluluğu yoktur.



            //int sayi = 10;

            //Arttir(out sayi);
            //Console.WriteLine("Gerçek sayı:" + sayi);

            //Console.WriteLine("Bir Sayı:");
            //string s = Console.ReadLine();
            //int sayi;
            //if(int.TryParse(s, out sayi))
            //{
            //    Console.WriteLine(sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen rakam giriniz!!");
            //}


            //int deger;
            //Arttir(out deger);
            //Console.WriteLine(deger);




            #endregion

            #region REF KEYWORD

            //Parametre olan gönderilen değişkenin metot içerisinde değiştirilme ihtimali vardır. Değişmesi halinde dışarıdaki tanımlı değişkene durumu yansıtmamızı sağlar.
            // out komutundan farklı olarak ilk değer vermek zorundayız. Çünkü metot içerisinde bir manipülasyon olmayabilir.

            //int sayi=10;
            //Degistir(ref sayi);

            //Console.WriteLine(sayi);

            //int[] sayilar = { 1, 2, 3, 4 };

            //Array.Resize(ref sayilar, 5);

            //sayilar[4] = 5;



            #endregion

            #region PARAMS KEYWORD

            //Bir metoda belirsiz sayıda parametre vermemizi sağlar.

            Topla(1, 2);
            Topla(1, 2,3);
            Topla(1, 2, 3, 4);
            Topla(1, 2, 3, 4,5);


            #endregion
        }

        #region DEFAULT DEĞER
        static void Yaz(string ad = "Ömer") //string bir parametre gelmezse default olarak Ömer değeri parametre olarak al
        {
            Console.WriteLine(ad);
        }

        static void Topla(int sayi1 = 10, double sayi2 = 5.5)
        {
            Console.WriteLine(sayi2 + sayi1);
        }
        #endregion

        #region OUT KEYWORD

        static void Arttir(out int sayi)
        {
            sayi = 20;

            Console.WriteLine("Metotdaki sayı:"+sayi);
        }


        #endregion

        #region REF KEYWORD

        static void Degistir(ref int sayi)
        {
            sayi = 20;
            Console.WriteLine(sayi);           
        }

        #endregion

        #region PARAMS KEYWORD
        //static void Topla(int s1, int s2)
        //{
        //    Console.WriteLine(s1 + s2);
        //}
        //static void Topla(int s1, int s2, int s3)
        //{
        //    Console.WriteLine(s1 + s2 + s3);
        //}

        //static void Topla(int s1, int s2, int s3, int s4)
        //{
        //    Console.WriteLine(s1 + s2 + s3 + s4);
        //}

        static void Topla(params int[] sayi)
        {
            int toplam = 0;

            foreach (var item in sayi)
            {
                toplam += item;
            }

            Console.WriteLine("Toplam:"+toplam);
        }
        #endregion

    }
}
