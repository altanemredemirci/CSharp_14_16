namespace _18_Generic_6_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir tane Ogrenci class'ı oluşturalım içerisinde Id, AdSoyad, Sinif property'leri olsun
            //Bir tane Ogretmen class'ı oluşturalım içerisinde Id, AdSoyad, Eğitimler property'leri olsun
            //OgrenciIslemleri class'ı oluşturalım içerisinde OgrenciListesi property'si (List<Ogrenci>) ve Ekle, Sil, ListeyiGetir methodları olsun.
            //OgretmenIslemleri class'ı oluşturalım içerisinde OgretmenListesi property'si (List<Ogretmen>) ve Ekle, Sil, ListeyiGetir methodları olsun
            //Sonuc adında bir class oluşturalum içerisinde Mesaj, BasariliMi ve Data property'leri olsun. Data property'sinin tipi generic olacak. 
            //OgrenciIslemleri ve OgretmenIslemleri class'larındaki Ekle, Sil ListeyiGetir methodlarının hepsinin return tipi Sonuc class'ı tipinde olacak. Sonuc class'ının içindeki Data property'si içerisinde sonuçlar dönülecek. 
            //İşlem başarılıysa BasariliMi property'si true değilse false olarak dönecek
            //Mesaj kısmı da "İşlem başarıyla tamamlandı" ya da "Hata oluştu, Hata detayı: ex.message" şeklinde bilgi dönecek.

            Console.WriteLine("--- ÖĞRENCİ İŞLEMLERİ ---");

            OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();

            Ogrenci ogrenci = new Ogrenci { Id = 1, AdSoyad = "Ömer Çelik", Sinif = "1-B" };
            Ogrenci ogrenci2 = new Ogrenci { Id = 2, AdSoyad = "Poyraz Akın", Sinif = "1-A" };

            var ekleSonuc = ogrenciIslemleri.Ekle(ogrenci);
            ogrenciIslemleri.Ekle(ogrenci2);

            SonucYazdir(ekleSonuc);

            Console.WriteLine("\n--- Öğrenci Listesi ---");
            var listeSonuc = ogrenciIslemleri.ListeyiGetir();

            if (listeSonuc.BasariliMi)
            {
                foreach (var ogr in listeSonuc.Data)
                {
                    Console.WriteLine($"Id: {ogr.Id} - Ad Soyad: {ogr.AdSoyad} - Sınıf: {ogr.Sinif}");
                }
            }

            Console.WriteLine("\n--- Öğrenci Silme ---");
            var silSonuc = ogrenciIslemleri.Sil(1);
            SonucYazdir(silSonuc);

            Console.WriteLine("\n--- Hatalı Öğrenci Silme ---");
            var hataliSonuc = ogrenciIslemleri.Sil(5);
            SonucYazdir(hataliSonuc);
                       
        }

        static void SonucYazdir<T>(Sonuc<T> sonuc)
        {
            if (sonuc.BasariliMi)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[Başarılı] {sonuc.Mesaj}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[HATA] {sonuc.Mesaj}");
            }
        }
    }
}
