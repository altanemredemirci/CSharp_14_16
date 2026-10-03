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

            //Console.WriteLine("Sayi:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Arttir(out sayi);
            //Console.WriteLine("Gerçek sayı:" + sayi);
            
            
            int deger;
            Arttir(out deger);
            Console.WriteLine(deger);

           


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
    }
}
