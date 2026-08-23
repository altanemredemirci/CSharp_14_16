namespace _06_DateTime_String_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATETIME TarihZaman

            //DateTime dateTime = DateTime.Now;

            //Console.WriteLine(dateTime);

            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.Month);
            //Console.WriteLine(dateTime.Day);
            //Console.WriteLine(dateTime.Hour);
            //Console.WriteLine(dateTime.Minute);
            //Console.WriteLine(dateTime.Second);
            //Console.WriteLine(dateTime.Millisecond);

            //Console.WriteLine(dateTime.DayOfYear);

            //Console.WriteLine(dateTime.AddMinutes(30));

            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToLongTimeString());
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());

            #endregion

            #region STRING METOTLAR

            //Length
            //string adSoyad = "Altan Emre Demirci";
            //Console.WriteLine(adSoyad.Length); //string datanın karakter sayısını verir.Boşluklarda sayılır.


            //IndexOf
            //string datalar Index adı verilen 0 dan başlayarak 1'er 1'er artan numalandırma sistemi ile karakterleri tutarlar.
            //IndexOf verilen karakterin string datada ilk kaçıncı indexte olduğunu döndüdür.
            //Console.WriteLine(adSoyad.IndexOf("a"));


            //LastIndexOf
            //LastIndexOf verilen karakterin string datada en son kaçıncı indexte olduğunu döndüdür.
            //Console.WriteLine(adSoyad.LastIndexOf("i"));


            //StartsWith()
            //string data verilen değerle mi başladı cevabını true veya false olarak döndürür.
            //Console.WriteLine(adSoyad.StartsWith("Al")); //True
            //Console.WriteLine(adSoyad.StartsWith("al")); //False


            //EndsWith()
            //string data verilen değerle mi bitiyor cevabını true veya false olarak döndürür.
            //Console.WriteLine(adSoyad.EndsWith("ci"));


            //Trim()
            //string datanın başında ve sonundaki boşlukları veya belirtilen karakteri siler.
            //string sehir = "   İSTANBUL     ";
            //Console.WriteLine(sehir);            
            //Console.WriteLine(sehir.Trim());


            //ToLower()
            //string sehir = "ARDAHAN";
            //Console.WriteLine(sehir.ToLower());


            //ToUpper()
            //string sehir = "ardahan";
            //Console.WriteLine(sehir.ToUpper());


            //Replace()
            //string adSoyad = "Altan Emre Demirci";
            //Console.WriteLine(adSoyad.Replace("e","a"));


            //Substring()
            //Başlangıç indexinden verilen uzunluk kadar karakteri böler.
            //string adSoyad = "Altan Emre Demirci";
            //string metin = adSoyad.Substring(2,3);
            //Console.WriteLine(metin);
            #endregion
        }
    }
}
