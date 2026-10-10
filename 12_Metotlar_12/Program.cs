namespace _12_Metotlar_12
{
    internal class Program
    {
        static double bakiye = 25000;
        static string sifre = "abc12";
        static int hak = 3;
        static void Main(string[] args)
        {
            //Bankamatik Metotlar ile yazılacak
            girisEkranı();

        }
        static void girisEkranı()
        {
            Console.WriteLine("Bankacılık uygulamasına hoşgeldiniz yapacağınız işlemi seçin");
            Console.WriteLine("Kartlı işlem için 1 , Kartsız işlem için 2 ye basın");
            Console.WriteLine("Çıkış için 0 a basın");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                kartliGiris();

            }
            else if (secim == 2)
            {
                kartsızGiris();
            }
            else if (secim == 0)
            {
                Console.WriteLine("Sistemden çıkılıyor...");
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim");
            }
        }
        static void kartliGiris()
        {
            while (hak > 0)
            {
                Console.WriteLine("Şifrenizi giriniz");
                string password = Console.ReadLine();

                if (password == sifre)
                {
                    anaMenu();
                    return;
                }
                else
                {
                    hak--;
                    Console.WriteLine("Hatalı sifre kalan hakkınız " + hak);
                }
            }
            Console.WriteLine("Şifrenizi 3 kez üst üste yanlış girdiniz sistemden çıkılıyor");

        }
        static void kartsızGiris()
        {
            int tcNoHak = 3;

            while (tcNoHak > 0)
            {
                Console.WriteLine("TC numaranızı giriniz...");
                string tcNo = Console.ReadLine();

                if (tcNo.Length == 11)
                {
                    Console.WriteLine("Başarılı giriş");
                    kartsızMenu();
                    return;
                }
                else
                {
                    tcNoHak--;
                    Console.WriteLine("Hatalı TC numara girişi kalan hakkınız " + tcNoHak);
                }
            }

            if (tcNoHak == 0)
            {
                Console.WriteLine("TC numaranızı 3 kez üst üste hatalı girdiniz sistemden çıkılıyor.");
            }

        }
        static void kartsızMenu()
        {
            while (true)
            {
                Console.WriteLine("Kartsız işlem menüsü yapmak istediğiniz işlemi seçin");
                Console.WriteLine("1-Para yatır");
                Console.WriteLine("2-Havale");
                Console.WriteLine("3-Eğitim ödemeleri");
                Console.WriteLine("4-Fatura ödemeleri");
                Console.WriteLine("0-Çıkış");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        paraYatır();
                        break;
                    case 2:
                        havale();
                        break;
                    case 3:
                        egitimOdemesi();
                        break;
                    case 4:
                        odemeler();
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim");
                        break;
                }

            }
        }
        static void anaMenu()
        {
            while (true)
            {
                Console.WriteLine("Başarılı giriş yapmak istediğiniz işlemi seçin");
                Console.WriteLine("1-Para Çek");
                Console.WriteLine("2-Para Yatır");
                Console.WriteLine("3-Havale");
                Console.WriteLine("4-Eğitim Ödemeleri");
                Console.WriteLine("5-Ödemeler");
                Console.WriteLine("6-Şifre Değiştir");
                Console.WriteLine("0-Çıkış");

                int secim1 = Convert.ToInt32(Console.ReadLine());

                switch (secim1)
                {
                    case 1:
                        paraCek();
                        break;

                    case 2:
                        paraYatır();
                        break;

                    case 3:
                        havale();
                        break;

                    case 4:
                        egitimOdemesi();
                        break;

                    case 5:
                        odemeler();
                        break;

                    case 6:
                        sifreDegistir();
                        break;
                    case 0:
                        Console.WriteLine("Sistemden çıkılıyor");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız...");
                        break;

                }
            }

        }
        static void paraCek()
        {
            Console.WriteLine("Çekilecek tutarı giriniz");
            double cekilenTutar = Convert.ToDouble(Console.ReadLine());

            if (cekilenTutar <= bakiye)
            {
                bakiye -= cekilenTutar;
                Console.WriteLine("Kalan bakiye " + bakiye + " TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }
        static void paraYatır()
        {
            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
            double yatırılanTutar = Convert.ToDouble(Console.ReadLine());
            bakiye += yatırılanTutar;
            Console.WriteLine("Para yatırma işlemi başarılı,bakiyeniz " + bakiye + " TL");
        }
        static void havale()
        {
            Console.WriteLine("Havale yapılacak IBAN bilgisini giriniz iban TR ile başlamalıdır");
            string iban = Console.ReadLine().ToUpper();

            if (iban.StartsWith("TR"))
            {
                Console.WriteLine("Havale tutarını giriniz");
                double havaleTutar = Convert.ToDouble(Console.ReadLine());

                if (havaleTutar <= bakiye)
                {
                    bakiye -= havaleTutar;
                    Console.WriteLine("Havale işlemi başarılı kalan bakiye : " + bakiye + " TL");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz IBAN numarası");
            }
        }
        static void egitimOdemesi()
        {
            Console.WriteLine("Sistemdeki hata nedeniyle işleminizi gerçekleştiremiyoruz");
        }
        static void odemeler()
        {
            Console.WriteLine("Ödemek istediğiniz fatutayı seçiniz");
            Console.WriteLine("1-Elektrik");
            Console.WriteLine("2-Telefon");
            Console.WriteLine("3-İnternet");

            int faturaTuru = Convert.ToInt32(Console.ReadLine());

            switch (faturaTuru)
            {
                case 1:
                    Console.WriteLine("Elektrik fatura ödemesi tutarını giriniz");
                    double elektrikTutar = Convert.ToDouble(Console.ReadLine());

                    if (elektrikTutar <= bakiye)
                    {
                        bakiye -= elektrikTutar;
                        Console.WriteLine("Başarılı ödeme kalan tutar " + bakiye + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    break;

                case 2:
                    Console.WriteLine("Telefon faturası tutarını giriniz");
                    double telefonTutar = Convert.ToDouble(Console.ReadLine());

                    if (telefonTutar <= bakiye)
                    {
                        bakiye -= telefonTutar;
                        Console.WriteLine("Başarılı ödeme kalan tutar " + bakiye + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    break;

                case 3:
                    Console.WriteLine("İnternet faturası tutarını giriniz");
                    double internetTutar = Convert.ToDouble(Console.ReadLine());

                    if (internetTutar <= bakiye)
                    {
                        bakiye -= internetTutar;
                        Console.WriteLine("Başarılı ödeme kalan tutar " + bakiye + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    break;
            }
        }
        static void sifreDegistir()
        {
            Console.WriteLine("Yeni sifrenizi giriniz");
            string yeniSifre = Console.ReadLine();
            sifre = yeniSifre;
            Console.WriteLine("Sifreniz basarıyla degistirildi");
        }
    }
}
