namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konsol ekranına birşe yazdırmak için Console.WriteLine() komutu kullanılır.

            //**Yazılım dillerinde küçük harf BÜYÜK harf duyarlılığı vardır.

            //Console.WriteLine(12);
            //Console.WriteLine("ALTAN EMRE DEMİRCİ");

            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();

            /*
             *** DEĞİŞKENLER 
             *Değişkenler yazılım içerisinde bir datayı saklamak,taşımak ve kullanmak için tanımlanan yazılım yapılarıdır.
             *Değişkenler tek bir adet data tutabilirler.
             *Tutacakları datanın veri tipinin mutlaka belirtmek gereklidir.
             *Değişken isimi benzersiz(unique) olmalıdır. 
             
                ** Değişken İsimlendirme Kuralları
                *yanlışlar: ?sayi, sayi?, ad!soyad, 5sayi, ad soyad
                *doğrular : sayi_, _sayi, ad_soyad, sayi2, adsoyad
                **_ alt çizgi bütün yazılım dillerinde geçerli tek özel karakterdir.
             */

            //int sayi = 10;
            //Console.WriteLine(sayi);

            //sayi = 15; //sayi değişkeni revize edildi.

            //Console.WriteLine(sayi);


            //string isim = "";

            //string Ad = "";

            //**Değişken tanımlama 
            // veriTipi degiskenAdi = değer

            /*
         ** CASE SENSITIVE
         *SnakeCase = ad_soyad
         *KebabCase = ad-soyad
         *UpperCase = ADSOYAD
         *LowerCase = adsoyad
         *CamelCase = adSoyad
         *PascalCase= AdSoyad
           */


            /*
             **** VERİ TİPLERİ ****
             *Veri tipleri tanımlanan yapının içerisinde hangi türde(sözel,sayısal,mantıksal) data tutacağını belirlememizi sağlar.
             
             ** SAYISAL VERİ TİPLERİ: Tamsayı,Ondalıklı
                *Tam Sayı Veri Tipleri:byte,sbyte,short,ushort,int,uint,long,ulong
                    long sayi = 12345678901;
                    Console.WriteLine(sayi);    

                *Ondalıklı Sayı Veri Tipleri:float,double
                    double sayi = 15.5;
                    float sayi2 = 15.5F;
                    Console.WriteLine(sayi2);
                
                *Decimal Veri Tipi:decimal
                    *Tanımlı bütün sayıları kapsayan en geniş sayısal veri tipidir.
                    decimal sayi = 100;
                    decimal sayi2 = 100.5m;  
            
             ** SÖZEL VERİ TİPLERİ: char, string
             *char: ' tek tırnak ile tanımlanır ve tek bir karakter alır.
                    char harf = 'A';
                    char sayi = '5';
                    char karakter = '?';
            
             *string: " çift tırnak ile tanımlanır ve istenilen kadar karakter alabilir.
                    string ad = "Altan Emre Demirci";
                    string metin = "";
             
            ** MANTIKSAL VERİ TİPİ(Boolean):bool
            *bool: true veya false değer tutar.

            */

            //bool cevap = 5 < 3;
            //Console.WriteLine(cevap);

            // + operatörü sayısal değerlerde toplama, sözel değerlerde birleştirme işlemi yapar.
            //string sayi = "5";

            ////int sayi = 5;
            //int sayi2 = 10;
            //Console.WriteLine(sayi2 + sayi);


            //{
            //    int a = 10;
            //    Console.WriteLine(a);
            //}
            //{
            //    Console.WriteLine(a);//HATA:Scope(Kapsam) geçerliliği sebebiyle a değişkeni farklı bir kapsamda olması sebebiyle hata aldık. 
            //}


            //Aynı değişkeni farklı kapsamlarda tanımlayabilirsiniz
            //{
            //    int sayi = 10;
            //}
            //{
            //    int sayi = 5;
            //}


            //Daha geniş kapsamda bulunan tanım içerideki {} içinde kullanılabilir.
            //{
            //    int b = 10;
            //    {
            //        Console.WriteLine(b);
            //    }
            //}


            int a = 10;
            int b = 3;
            double c = 4;


            Console.WriteLine(a/b);
            Console.WriteLine(a/c);

            //** CONSTANT : Sabit değişken

            const double PI = 3.14;

            //PI = 3; //const ile tanımlanan bir değişken değeri değiştirilemez.


        }
    }
}
