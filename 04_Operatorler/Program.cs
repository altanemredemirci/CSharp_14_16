namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MATEMATİKSEL OPERATÖRLER

            //int sayi = 10;

            //double sayi2 = 3.0;

            //Console.WriteLine(sayi+sayi2);
            //Console.WriteLine(sayi2-sayi);
            //Console.WriteLine(sayi*sayi2);
            //Console.WriteLine(sayi/sayi2);


            //Mod Alma(%):Bölme işlemi sonucundaki kalan değeri verir.

            //double sonuc = sayi % sayi2;

            //Console.WriteLine(sonuc);


            #endregion

            #region KIYAS OPERATÖRÜ (? :)

            //Kullanıcıdan bir sayı alınız tek ise ekrana TEK çift ise ekrana ÇİFT yazdırınız

            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //== çift eşittir iki değerin aynı olup olmadığı kontrol eder.
            // Karşılaştırma sonucu true ise ? kısmı, false ise : kısmı çalışır.
            //string cevap = sayi % 2 == 0 ? "ÇİFT" : "TEK";

            //Console.WriteLine(cevap);



            #endregion

            #region ATAMA(=) VE İŞLEMLİ ATAMA OPERATÖRLERİ

            //int sayi = 5; //5 değerini sayı değişkenine atadık.

            //sayi = sayi + 5;  //sayi+=5;
            //sayi = sayi - 5;  //sayi-=5;
            //sayi = sayi * 5;  //sayi*=5;
            //sayi = sayi / 5;  //sayi/=5;

            #endregion

            #region BİR ARTTIRMA VE BİR AZALTMA OPERATÖRLERİ

            //int sayi = 5;
            //sayi++; //sayi=sayi+1;
            //sayi--; //sayi=sayi-1;

            //int a = 5;
            //int b = ++a;
            //int c = b++;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            #endregion

            #region KARŞILAŞTIRMA OPERATÖRLERİ

            //int a = 10;
            //int b = 5;

            //bool sonuc = a < b;
            //bool sonuc2 = a > b;
            //bool sonuc3 = a >= b;
            //bool sonuc4 = a <= b;
            //bool sonuc5 = a == b;
            //bool sonuc6 = a != b;


            //double bakiye = 10000;

            //Console.WriteLine("EFT miktarı:");
            //double miktar = Convert.ToDouble(Console.ReadLine());

            //string sonuc = bakiye >= miktar ? "EFT BAŞARILI" : "YETERSİZ BAKİYE";

            //Console.WriteLine(sonuc);

            #endregion

            #region ERİŞİM OPERATÖRÜ (.)

            //Console.WriteLine();

            //Convert.ToInt16();

            //Ogrenci.Yaz();

            #endregion

            #region MANTIKSAL OPERATÖRLER (&&-AND  ||-OR  !-NOT)

            #region AND OPERATÖRÜ &&
            //Birden fazla karşılaştırma durumundan hepsinin true olması gerekliyse AND operatörü kullanılır.

            //string username = "altanemre";
            //string password = "123";

            //Console.WriteLine("Kullanıcı Adınız:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifreniz:");
            //string sifre = Console.ReadLine();


            //bool cevap = username == kullaniciAdi && password == sifre;

            //Console.WriteLine("GİRİŞ DURUMU:"+cevap);
            #endregion

            #region OR OPERATÖRÜ ||
            //Birden fazla karşılaştırma durumundan birinin doğru olması yeterli ise OR operatörü kullanılır.

            //string username = "altanemre";
            //string email = "altanemre@gmail.com";
            //string password = "123";


            //Console.WriteLine("Kullanıcı Adı/Email:");
            //string kullanici = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();

            //bool sonuc = (kullanici == username || kullanici == email) && password==sifre;

            //Console.WriteLine(sonuc);

            #endregion

            #region NOT OPERATÖRÜ
            //Sonucu true olan işlemi false, false olan işlemi true ya çevirir.

            //bool sonuc = 5 > 3;

            //Console.WriteLine(!sonuc);


            #endregion

            #endregion

            #region Kullanıcıdan Cinsiyet ve Yaş bilgilerini alınız. Cinsiyeti kadın ise ehliyet almak için 25 ve üzeri yaş, erkek ise 16 ve üzeri yaşında olması yeterlidir. 

            //ToLower():string değeri küçük harfe çevirir.
            //ToUpper():string değeri büyük harfe çevirir.

            //Console.WriteLine("Cinsiyetiniz:");
            //string cinsiyet = Console.ReadLine().ToLower();

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //bool sonuc = (cinsiyet == "erkek" && yas > 15) || (cinsiyet == "kadın" && yas > 24);

            //Console.WriteLine("Ehliyet alabilir mi:"+sonuc);


            #endregion

        }
    }
}
