namespace _09_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

               **** ARRAYS - Diziler ****
            *Değişkenler tek bir veri tutarken, diziler aynı veri tipinde birden fazla veri tutabilirler.
            *Index adı verilen 0'dan başlayarak 1'er 1'er artan numaralandırma yöntemi ile verileri tutarlar.
            *[] dizi tanımlarken kullanılır.

             */

            //int sayi = 10;

            //int[] sayilar = { 11, 22, 33, 44, 55 }; // Dolu Dizi Tanımlama

            //string[] isimler = new string[10]; //10 elemanlı boş dizi tanımlama

            //isimler[3] = "Altan Emre"; //Index numarası üzerinden değer eklendi.

            //Console.WriteLine(sayilar[2]); //index numarası üzerinden değer okundu.

            //Console.WriteLine("Adınız:");
            //isimler[0] = Console.ReadLine();


            //string[] isimler = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Adınız:");
            //    isimler[i] = Console.ReadLine();
            //}


            #region Kullanıcıdan alınan 5 adet sayı bir diziye atayınız ve bu diziyi ekrana yazdırınız.

            //int[] sayilar = new int[5];

            ////Dizi doldurma alanı
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayı:");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////Dizi yazdırma alanı
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region Kullanıcıdan kaç personeli olduğu bilgisini alınız. Daha sonra personel isimlerini personeller isimli bir diziye kullanıcıdan alarak atayınız

            //Console.WriteLine("Kaç personelin var?");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++) 
            //{
            //    Console.WriteLine($"{i+1}.Personel Adı:");
            //    personeller[i] = Console.ReadLine();
            //}

            //for (int i = 0;i < personeller.Length;i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}


            #endregion
            #region ARRAY SINIF METOTLARI

            #region CLEAR()

            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 77 };

            ////Array.Clear(sayilar); //Dizi içerisindeki elemanları siler.

            //Array.Clear(sayilar, 2, 3); //Dizi içerisinde istenilen indexten başlayarak istenilen kadar sayıyı siler.

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region COPY()

            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 77 };
            //int[] sayilar2 = new int[10];

            ////Array.Copy(sayilar, sayilar2, 3);
            //Array.Copy(sayilar,2,sayilar2,3,4);

            //foreach (int item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region INDEXOF

            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 77 };

            ////int indexNo = sayilar.IndexOf(22);
            ////int indexNo = sayilar.IndexOf(23);

            //Console.WriteLine(indexNo);


            //string[] isimler = { "Altan", "Ömer", "Toprak", "Şeyma", "Altan", "Uras", "Altan", "Almina", "Altan", "Elif" };


            //Console.WriteLine(isimler.IndexOf("Altan"));
            //Console.WriteLine(Array.IndexOf(isimler,"Altan",1));

            //int index = -1;

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    index = Array.IndexOf(isimler, "Altan", index+1);

            //    if (index == -1)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(index);
            //}







            #endregion

            #region LASTINDEXOF()

            //string[] isimler = { "Altan", "Ömer", "Toprak", "Şeyma", "Altan", "Uras", "Altan", "Almina", "Altan", "Elif" };

            //Console.WriteLine(Array.LastIndexOf(isimler,"Altan"));


            #endregion

            #region SORT()

            //string[] sehirler = { "Zonguldak", "Adana", "Adıyaman", "Kars", "İstanbul", "Çanakkale", "Şırnak" };

            //Array.Sort(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region REVERSE

            //string[] sehirler = { "Zonguldak", "Adana", "Adıyaman", "Kars", "İstanbul", "Çanakkale", "Şırnak" };

            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region RESIZE

            //int[] sayilar = new int[3];

            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;

            //Array.Resize(ref sayilar, sayilar.Length+1);

            //sayilar[3] = 14;

            #endregion

            //string sehir = "İSTANBUL";

            //foreach (char item in sehir)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Bir dizinin elaman sayısı 10 ile 20 arasında rastgele atansın.
            //Bu dizinin elemanlarını sistem 0-100 aralığında rastgele otomatik dolduracak.
            //Aynı sayı tekrar diziye eklenmesin
            //Dizinin en büyük ve en küçük değerlerini ekran yazdırınız.

            //Random r = new Random();

            //int boyut = r.Next(10, 20);

            //int[] sayilar = new int[boyut];

            //int i = 0;
            //while(i<sayilar.Length)
            //{
            //    int sayi = r.Next(0, 100);

            //    if (sayilar.Contains(sayi)==false)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            ////Array.Sort(sayilar);

            ////Console.WriteLine("En Küçük:"+sayilar[0]);
            ////Console.WriteLine("En Büyük:"+sayilar[sayilar.Length-1]);


            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi > enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }
            //    if (sayi < enKucuk)
            //    {
            //        enKucuk = sayi;
            //    }
            //}

            //Console.WriteLine("En Küçük:" + enKucuk);
            //Console.WriteLine("En Büyük:" + enBuyuk);


            #endregion


            #region OTOMAT
            //            1.Başlangıç ve Veri Yapılarının Tanımlanması
            //Dizileri(Array) Oluştur:

            //            urunler adında 50 eleman kapasiteli bir metin dizisi(string array) tanımla.

            //fiyatlar adında 50 eleman kapasiteli bir sayı dizisi(integer array) tanımla.

            //Değişkenleri Tanımla:

            //urunSayisi = 3(Şu an sistemde var olan ürün sayısı).

            //gunSonuSatis = 0(Toplam kazancı tutacak değişken).

            //Başlangıç Verilerini Diziye Ekle:

            //urunler[0] = "Fanta", fiyatlar[0] = 40

            //urunler[1] = "Kola", fiyatlar[1] = 40

            //urunler[2] = "Çikolata", fiyatlar[2] = 30

            //2.Ana Akış(Sonsuz Döngü)
            //Program kapanana kadar ana menü sürekli ekranda kalmalıdır. Bunun için bir While Döngüsü başlatılır.

            //Ekrana seçenekleri yazdır: 1 - Müşteri Ekranı, 2 - Admin Paneli, 0 - Çıkış.

            //Kullanıcıdan modSecimi al.

            //EĞER modSecimi == 1 ise Müşteri Algoritmasına git.

            //EĞER DEĞİLSE(ELSE IF) modSecimi == 2 ise Admin Paneli Algoritmasına git.

            //EĞER DEĞİLSE(ELSE IF) modSecimi == 0 ise döngüyü kır ve programı bitir.

            //3.Müşteri Ekranı Algoritması
            //Ürünleri Listele(For Döngüsü):

            //i = 0'dan başlayıp urunSayisi değerine kadar dönen bir döngü kur.

            //Her adımda ekrana i+1.ürünün adını(urunler[i]) ve fiyatını(fiyatlar[i]) yazdır.

            //Ürün Seçimi:

            //Kullanıcıdan almak istediği ürünün sıra numarasını iste(secim).

            //Seçim Kontrolü(IF):

            //EĞER secim 0'dan büyük ve urunSayisina eşit ya da küçükse işlem geçerlidir:

            //Seçilen ürünün indeksini bul: index = secim - 1.

            //Seçilen ürünün fiyatını hafızaya al: urunFiyati = fiyatlar[index].

            //Kullanıcıdan para atmasını iste ve yatirilanPara değişkenine kaydet.

            //Ödeme Kontrolü(While Döngüsü): (Para yetersiz olduğu sürece bu döngü tekrarlanır)

            //Durum A(Tam Para): EĞER yatirilanPara == urunFiyati ise;

            //            Ekrana "Afiyet olsun" yazdır.

            //gunSonuSatis değişkenine urunFiyati kadar ekleme yap.

            //Ödeme döngüsünden çık.

            //Durum B(Fazla Para): EĞER DEĞİLSE(ELSE IF) yatirilanPara > urunFiyati ise;

            //            Para üstünü hesapla: paraUstu = yatirilanPara - urunFiyati.

            //            Ekrana "Afiyet olsun, para üstü: [paraUstu] alınız" yazdır.

            //gunSonuSatis değişkenine urunFiyati kadar ekleme yap.

            //Ödeme döngüsünden çık.

            //Durum C(Eksik Para): DEĞİLSE(ELSE);

            //            Ekrana "Yetersiz bakiye" yazdır.

            //Seçenek sun: 1 - Para Ekle, 2 - Para İade.

            //EĞER kullanıcı 1'i seçerse; eklenecek tutarı sor, girilen yeni parayı yatirilanPara değişkeninin üzerine topla (Döngü başa    sarar  ve   paranın yetip yetmediğini tekrar kontrol eder).

            //EĞER DEĞİLSE kullanıcı 2'yi seçerse; "Para iade edildi" yazdır ve ödeme döngüsünden çık.

            //4.Admin Paneli Algoritması
            //Admin panelinde işlemler bittiğinde ana menüye atmaması, admin menüsünde kalması için ayrı bir While Döngüsü başlatılır.

            //Ekrana seçenekleri yazdır: 1 - Ekle, 2 - Güncelle, 3 - Sil, 4 - Listele, 5 - Günsonu, 0 - Geri.

            //Adminin seçimini al(adminSecim).

            //1.Yeni Ürün Ekleme Algoritması
            //EĞER urunSayisi dizi kapasitesinden(50) küçükse;

            //            Kullanıcıdan yeni ürünün adını al ve urunler[urunSayisi] konumuna kaydet.

            //Kullanıcıdan yeni ürünün fiyatını al ve fiyatlar[urunSayisi] konumuna kaydet.

            //urunSayisi değerini 1 arttır.

            //DEĞİLSE; "Makine kapasitesi dolu" uyarısı ver.

            //2.Ürün Güncelleme Algoritması
            //For Döngüsü ile mevcut ürünleri listele.

            //Adminden güncellenecek ürünün sıra numarasını iste(guncelIndex).

            //EĞER girilen numara geçerli bir ürün ise;

            //            Yeni ürün adını al ve urunler[guncelIndex] içerisine yaz(eski verinin üzerine yazılır).

            //Yeni fiyatı al ve fiyatlar[guncelIndex] içerisine yaz.

            //3.Ürün Silme Algoritması(Dizi Kaydırma Yöntemi)
            //Standart dizilerden(Array) bir eleman silindiğinde arada boşluk kalmaması için sağdaki elemanlar sola kaydırılır.

            //For Döngüsü ile mevcut ürünleri listele.

            //Adminden silinecek ürünün sıra numarasını al(silIndex = girilenSayi - 1).

            //Kaydırma Döngüsü(For): i = silIndex konumundan başla, urunSayisi -1 değerine kadar dön.

            //Her adımda bir sağdaki ürünün adını, soldaki kutuya kopyala: urunler[i] = urunler[i + 1].

            //Her adımda bir sağdaki ürünün fiyatını, soldaki kutuya kopyala: fiyatlar[i] = fiyatlar[i + 1].

            //Döngü bittiğinde urunSayisi değerini 1 azalt(Böylece en sondaki çift kopya eleman sistemden dışlanmış olur).

            //4.Ürünleri Listeleme Algoritması
            //i = 0'dan urunSayisina kadar dönen bir For Döngüsü kur ve tüm diziyi ekrana yazdır.

            //5.Günsonu Toplam Satış Algoritması
            //Ekrana doğrudan gunSonuSatis değişkeninin içindeki sayısal değeri yazdır.
            #endregion
        }
    }
}
