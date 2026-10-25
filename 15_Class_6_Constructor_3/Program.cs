namespace _15_Class_6_Constructor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                         ﻿﻿===== KÜTÜPHANE SİSTEMİ =====
            1. Yeni Kitap Ekle
            2. Tüm Kitapları Listele
            3. Kitap Ara (Ada göre)
            4. Kitap Sil
            5. Üye Ekle
            6. Üyeleri Listele
            7. Kitap Ödünç Ver
            8. Ödünç Alınan Kitapları Listele
            0. Çıkış
            =============================
            Seçiminiz:

            Kullanılacak Yapılar ve Konular:

            Class: Kitap, Uye, Kutuphane

            List<T>: Kitap ve üye listeleri

            If-Else: Kullanıcı seçimleri, doğrulamalar

            Döngüler: Menü tekrarı, listeleme

            Metotlar: Her işlem için ayrı metotlar

            Try-Catch: Hata yönetimi (opsiyonel, zorluk arttırmak için)

            Algoritmik düşünme: Arama, silme, koşullu listeleme

            Algoritma Adımları:

            Kitap sınıfını oluştur (ISBN, Ad, Yazar, Durum (Ödünçte mi?)).

            Uye sınıfını oluştur (UyeNo, AdSoyad, AldigiKitaplar listesi).

            Kutuphane sınıfı içinde List<Kitap> ve List<Uye> tanımla.

            Menü yapısını oluştur.

            Seçilen menüye göre ilgili metodu çağır.

            Her işlem için:

            Kitap ekleme: Kullanıcıdan bilgiler al, listeye ekle.

            Listeleme: Kitap listesini ekrana yaz.

            Arama: Ada göre kitap ara ve sonucu göster.

            Silme: Kitap adı veya ISBN ile sil.

            Üye ekleme / listeleme: Benzer şekilde üyeleri yönet.

            Ödünç verme: Kitap müsaitse üyeye ata, durumu “ödünçte” yap.
                         */


            while (true)
            {
                Console.WriteLine("1-Kitap Ekle\n2-Kitap Sil\n3-Kitap Listele\n4-Kitap Ara\n5-Ödünç Ver\n6-Ödünç Listele\n7-Üye Ekle\n8-Üye Lİstele\n0-Çıkış");

                Console.WriteLine("Seçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1) { Kitap.Ekle(Kutuphane.Kitaplar); }
                else if (secim == 2) { Kitap.Sil(Kutuphane.Kitaplar); }
                else if (secim == 3) { Kitap.Listele(Kutuphane.Kitaplar); }
                else if (secim == 4) { Kitap.KitapAra(Kutuphane.Kitaplar); }
                else if (secim == 5) { Kutuphane.OduncAl(); }
                else if (secim == 6) { Kutuphane.OduncListele(); }
                else if (secim == 7) { Uye.Ekle(Kutuphane.Uyeler); }
                else if (secim == 8) { Uye.Listele(Kutuphane.Uyeler); }
                else if (secim == 0) { break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }

        }
    }
}
