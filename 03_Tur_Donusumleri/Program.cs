namespace _03_Tur_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dışarıdan - Kullanıcıdan değer alma
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine(); //Kullanıcının girmiş olduğu değeri okur.

            //Console.WriteLine(ad);

            //*** Dışarıdan alınan her değer MUTLAKA STRING gelir.


            #region STRING TO INTEGER (INTEGER:SAYISAL KÜTÜPHANE)

            //** BİLİNÇLİ TÜR DÖNÜŞÜMÜ
            //Özellikle kod yazarak bir veri tipinden diğerine dönüştürme işlemine denir.


            //Console.WriteLine("Yaşınız:"); //36
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Maaş:");
            //double maas= Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine("Yaşınız:");
            //int yas2=int.Parse(Console.ReadLine());


            //** BİLİNÇSİZ TÜR DÖNÜŞÜMÜ
            //Özellikle bir kod yazılmadan yapılan dönüşümdür.

            //int sayi = 10;
            //long sayi2 = sayi;


            //** BOXING
            //Büyükm veri tipinde tanımlanan ama içindeki değer küçük olan bir datayı farklı bir veri tipine atama işlemine denir.

            //double s = 10;
            //int s2 = (int)s;

            //Console.WriteLine(s2);


            //long sayi = 121212121213112;
            //int sayi2 = (int)sayi;

            //Console.WriteLine(sayi2);

            #endregion

            #region Üç kardeşin yaşlarını kullanıcında alarak toplamlarını ekrana yazdırınız.

            //Console.WriteLine("1.Kardeş Yaşı:");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Kardeş Yaşı:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3.Kardeş Yaşı:");
            //int yas3 = Convert.ToInt32(Console.ReadLine());

            //int toplam = yas1 + yas2 + yas3;

            //Console.WriteLine(toplam);
            //Console.WriteLine("Toplam Yaş:"+toplam);
            //Console.WriteLine($"Toplam Yaş:{toplam}");
            //Console.WriteLine("Toplam Yaş:{0}",toplam);

            #endregion

            #region Öğrenciden vize ve final notlarını isteyiniz. Alınan vize ve final notu üzerinden ortalamayı hesaplayınız. Ortalama = vize*0.4 + final*0.6

            Console.WriteLine("Vize Notu:");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Notu:");
            int final = Convert.ToInt32(Console.ReadLine());


            double ortalama = vize * 0.40 + final * 0.60;

            Console.WriteLine("Ortalama:"+ortalama);

            #endregion
        }
    }
}
