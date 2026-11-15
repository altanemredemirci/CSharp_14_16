namespace _17_OOP_7_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ARAÇ KİRALAMA SİSTEMİ
             
            Bir araç kiralama şirketi için Araç Yönetim Sistemi geliştireceğiz. Aşağıdaki gereksinimleri karşılayan bir C# konsol uygulaması yazınız.


            * IElektrikliArac adında bir interface oluşturun. Bu interface şunları içermelidir.
            
            BataryaKapasitesi(double) - property
            MaksimumMenzil(double) - property
            BataryaDurumuGoster() - method
            SarjSuresiHesapla() - method (double döndürmeli)


            * Arac adında bir abstract class oluışturun. Bu sınıfı şunları içermeklidir.
            
            Properties : Marka, Model, Yıl, Plaka, GunlukKiraBedeli
            Constructor : Tüm özellikleri parametre olarak alsın.

            * Abstract Metodlar:
            KiraUcretiHesapla(int gun) - double döndürmeli
            AracBilgileriniGoster() - void
            AracTipiGoster() - string döndürmeli

            * Virtual Metod:
            GenelBilgi() - Araç bilgilerini konsola yazdırsın

            * Araba Sınıf:
            Arac sınıfından türetilmeli
            Ek özellikler: KapiSayisi(int), VitesTipi(string)
            Kira ücreti hesaplama: Günlük Kira x gun sayısı x 1.10(hizmet bedeli)

            * ElektrikliAraba Sınıfı
            Araba sınıfından türetilmeli
            IElektrikliArac interface'ini implement etmeli
            Şarj süresi hesaplama: BataryaKapasitesi / 10(her 10 kWh için 1 saat)
            Kira ücreti hesaplama: Günük kira x gün sayısı x 0.95(%5 indirim)

            * Motosiklet Sınıfı
            Arac sınıfından türemeli
            Ek özellikler: MotorHacmi(int), YanCantaVarMi(bool)
            Kira ücreti hesaplama: Günük kira x gün sayısı x (yan çanta varsa günlük 50 tl ekstra)

            * Main metodunda
            En az 1 Araba, 1 ElektrikliAraba, 1 Motosiklet nesnesi oluşturun
            Tüm araçların bilgilerini gösterin
            Her araç için 7 günlük kiralama ücretini hesaplayıp ekrana yazdırın
            Polymorphism kullanılarak tüm araçlari List<Araç> içinde saklayın ve döngü ile işleyin 



             */

            Araba araba = new Araba("Ford", "Ranger", 2016, "34YN2447", 3000, 4, "Otomatik");

            ElektrikliAraba elektrikliAraba = new ElektrikliAraba("Tesla", "Y100", 2025, "34YZ240", 5000, 10000, 500, 2, "Otomatik");

            Motosiklet motosiklet = new Motosiklet("Yamaha", "YBR125", 2020, "34DM99", 1500, 1250, true);

            araba.AracBilgileriniGoster();

            Console.WriteLine(araba.KiraUcretiHesapla(7));

            Console.WriteLine("-------------");

            elektrikliAraba.AracBilgileriniGoster();

            Console.WriteLine(elektrikliAraba.KiraUcretiHesapla(7));

            Console.WriteLine("-------------");

            motosiklet.AracBilgileriniGoster();

            Console.WriteLine(motosiklet.KiraUcretiHesapla(7));

            List<Arac> araclar = new List<Arac>();
            araclar.Add(araba);
            araclar.Add(elektrikliAraba);
            araclar.Add(motosiklet);

        }
    }


}
