using System.Collections;

namespace _13_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList koleksiyonu key,value mantığı ile çalışır. Bir değer arandığında key değeri üzerinden arama işlemi yapılır ve o key'e karşılık gelen valur değeri getirilir.
            SortedList sozluk = new SortedList()
            {
                {"Bugün","Today"},
                {"Yarın","Tomorrow" },
                {"Hava","Weather" },
                {"Gökyüzü","Sky" },
                {"Karlı","Snowy" },
                {"Güneşli","Sunny" },
                {"Bulutlu","Cloudy" },
                {"Açık","Clear" },
                {"Kapalı","Cloudy" },
                {"Üç","5" }
                //{"3","Three" }
            };

            //Console.WriteLine(sozluk["Bugün"]);

            //Console.WriteLine(sozluk["Today"]);

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //foreach (string item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}

            sozluk["Siyah"] = "Black"; //Yoksa yeni key ve value değereni ekler.
            sozluk["Siyah"] = "DarkBlack"; // Varsa o key'in value değerinin günceller.
        }
    }
}
