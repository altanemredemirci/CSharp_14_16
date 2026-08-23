namespace _05_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KARAR YAPISI - AKIŞ KONTROL 
            /*
             * If - Else if - Else
             * Switch Case
             
            Kod içerisinde bir karşılaştırma durumunun cevabına göre kodun yönünü belirleme işlemine denir.

            IF ELSE 

            Birden fazla kontrol durumunda ilk koşul(durum) if deyimine yazılır.Alternatif durumlar(koşullar) için else if kullanılır.Geri kalan kontrol dışı durumlar için else kullanılır.
             */

            //Kullanıcıdan alınan sayı 0'dan büyük ise "Pozitif", 0'dan küçük ise "Negatif", 0 ise "Nötr" yazdıran kodu yazınız. 

            //Console.WriteLine("Sayı Giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Nötr");
            //}

            #region Haftanın kaçıncı gününde olduğumuzu kullanıcıdan alalım. Alınan sayıya göre ekrana günün adını yazdıralım

            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur!!");
            //}




            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //string gun = Console.ReadLine();

            //if (gun == "1")
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == "2")
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == "3")
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == "4")
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == "5")
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == "6")
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == "7")
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur!!");
            //}



            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if(gun<1 || gun > 7)
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur!!");
            //}
            //else
            //{
            //    if (gun == 1)
            //    {
            //        Console.WriteLine("Pazartesi");
            //    }
            //    else if (gun == 2)
            //    {
            //        Console.WriteLine("Salı");
            //    }
            //    else if (gun == 3)
            //    {
            //        Console.WriteLine("Çarşamba");
            //    }
            //    else if (gun == 4)
            //    {
            //        Console.WriteLine("Perşembe");
            //    }
            //    else if (gun == 5)
            //    {
            //        Console.WriteLine("Cuma");
            //    }
            //    else if (gun == 6)
            //    {
            //        Console.WriteLine("Cumartesi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pazar");
            //    }
            //}




            #endregion
            #region Kullanıcında 2 ürün fiyatı isteyin. Bu ürün fiyatlarının toplamı 2500 tl geçerse ucuz olan ürüne %25 indirim uygulayarak toplam ödemeyi ekrana yazdırınız

            //Console.WriteLine("1.Ürün Fiyat:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün Fiyat:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //if ((fiyat1 + fiyat2) > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }

            //    Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2));
            //}
            //else
            //{
            //    Console.WriteLine("Ödemeniz:"+(fiyat2+fiyat1));
            //}



            //Console.WriteLine("1.Ürün Fiyat:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün Fiyat:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //if ((fiyat1 + fiyat2) > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }
            //}

            //Console.WriteLine("Ödemeniz:" + (fiyat2 + fiyat1));





            #endregion
            #region Aylık Geliri kullanıcıdan alınız. 40000 üzerinde ise %12 vergi kesintisi, 40000 ve altında ise %9 vergi kesintisi yapılacak. Kullanıcıya vergi değeri ve net maaşını yazınız.

            //Console.WriteLine("Aylık Gelir:");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    double vergi = gelir * 0.12;
            //    gelir = gelir - vergi;

            //    Console.WriteLine($"Aylık Net Gelir:{gelir} Vergi:{vergi}");
            //}

            //else
            //{
            //    double vergi = gelir * 0.09;
            //    gelir = gelir - vergi;

            //    Console.WriteLine($"Aylık Net Gelir:{gelir} Vergi:{vergi}");
            //}


            #endregion
            #region Öğrenciden vize ve final notlarını alınız. Not girişinde 0-100 aralığı kontrolünü yapınız. Sonra vizenin %40 + finalin %60 alarak ortalamayı hesaplayınız. Ortalama değerine göre harf notunu yazdırınız
            /*
             
            0-24 FF
            25-44 DD
            45-54 CC
            55-69 CB
            70-84 BB
            85-100 AA
             
            */
            //VIZE:
            //Console.WriteLine("Vize:");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //if(vize<0 || vize > 100)
            //{
            //    Console.WriteLine("Hatalı Vize Not Aralığı!!");
            //    goto VIZE;
            //}
            //else
            //{
            //    FINAL:
            //    Console.WriteLine("Final:");
            //    int final = Convert.ToInt32(Console.ReadLine());

            //    if(final<0 || final > 100)
            //    {
            //        Console.WriteLine("Hatalı Final Not Aralığı!!");
            //        goto FINAL;
            //    }
            //    else
            //    {
            //        double ortalama = vize * 0.4 + final * 0.6;

            //        if(ortalama>=0 && ortalama < 25)
            //        {
            //            Console.WriteLine("FF");
            //        }
            //        else if(ortalama>=25 && ortalama < 45)
            //        {
            //            Console.WriteLine("DD");
            //        }
            //        else if (ortalama >= 45 && ortalama < 55)
            //        {
            //            Console.WriteLine("CC");
            //        }
            //        else if (ortalama >= 55 && ortalama < 70)
            //        {
            //            Console.WriteLine("CB");
            //        }
            //        else if (ortalama >= 70 && ortalama < 85)
            //        {
            //            Console.WriteLine("BB");
            //        }
            //        else
            //        {
            //            Console.WriteLine("AA");
            //        }
            //    }
            //}


            #endregion
            #region Kullanıcıya 3 hak vererek kayıtlı username ve password üzerinden bir giriş paneli kodlayınız.

            //string username = "admin";
            //string password = "123";


            //int hak = 3;

            //donus:
            //    if (hak > 0)
            //    {
            //        Console.WriteLine("Kullanıcı Adı:");
            //        string kullaniciAdi = Console.ReadLine();
            //        Console.WriteLine("Şifre:");
            //        string sifre = Console.ReadLine();

            //        hak--;

            //        if (kullaniciAdi == username && sifre == password)
            //        {
            //            Console.WriteLine("Giriş Başarılı");
            //        }

            //        else if (hak == 0)
            //        {
            //            Console.WriteLine("Hakkınız Bitti");
            //        }

            //        else
            //        {
            //            Console.WriteLine("Giriş Bilgileri Hatalı!!");
            //            goto donus;
            //        }
            //    }


            //donus:
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kullaniciAdi = Console.ReadLine();
            //    Console.WriteLine("Şifre:");
            //    string sifre = Console.ReadLine();

            //    hak--;

            //    if (kullaniciAdi == username && sifre == password)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //    }

            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Bilgileri Hatalı!!");
            //        goto donus;
            //    }

            #endregion

            #region SWITCH CASE

            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break; //İşlemi bitir.

            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;

            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;

            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;

            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;

            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;

            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default:
            //        Console.WriteLine("Hafta 7 günden oluşur.");
            //        break;
            //}


            //Console.WriteLine("Cinsiyet:");
            //string cinsiyet=Console.ReadLine();

            //switch (cinsiyet)
            //{
            //    case "erkek":
            //        Console.WriteLine("BEYEFENDİ");
            //        break;

            //    case "kadın":
            //        Console.WriteLine("HANIMEFENDİ");
            //        break;
            //    default:
            //        Console.WriteLine("Cinsiyet bilgisi hatalı!!");
            //        break;
            //}




            #endregion

            #region SORU
            /*
            Kullanıcıdan cinsiyet bilgisini alınız.
            ERKEK => 
                yaşı 60 ve üstü ise maaş bilgisi alalım ve maaşının 10 katı ile emekli oldunuz yazalım
                yaşı 60'dan küçük ise 
                    prim günü bilgisi alalım. 
                        Prim günü 6000 ve üstünde ise maaşının 11 katı ile emekli oldunuz yazalım
                        Prim günü 6000'den az ise Emekli olamadınız yazalım
            KADIN => 
                yaşı 50 ve üstü ise maaş bilgisi alalım ve maaşının 10 katı ile emekli oldunuz yazalım
                yaşı 50'dan küçük ise 
                    prim günü bilgisi alalım. 
                        Prim günü 3600 ve üstünde ise maaşının 11 katı ile emekli oldunuz yazalım
                        Prim günü 3600'den az ise Emekli olamadınız yazalım
             */

            Console.WriteLine("Cinsiyet:");
            string cinsiyet = Console.ReadLine().ToLower(); //ToLower() girilen string değeri küçük harfe çevirir. ToUpper() büyük harfe çevrir.

            switch (cinsiyet)
            {

                case "erkek":
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());

                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Emekli ikramiyeniz:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Emekli ikramiyeniz:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal. Çalışmaya Devam.");
                        }
                    }


                    break;

                case "kadın":
                    Console.WriteLine("Yaş:");
                    int yaskadin = Convert.ToInt32(Console.ReadLine());

                    if (yaskadin >= 50)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Emekli ikramiyeniz:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 3600)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Emekli ikramiyeniz:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal. Çalışmaya Devam.");
                        }
                    }

                    break;
                default:
                    break;
            }


            #endregion

        }
    }
}
