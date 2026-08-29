namespace _07_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            //            /*   
            //             *   25000 tl parası olacak 
            //            Bir bankamatik düşünülerek tasarlanacak bir program  için 
            //            Kartlı işlem    1
            //            Kartsız işlem   2
            //            //********Kartlı işlem bölümü
            //            Şifre istenecek=> Şifre:ab18
            //            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //            //*******************Ana Menü 
            //            Para Çekmek için    1
            //            Para yatırmak için  2
            //            Para Transferleri   3
            //            Eğitim Ödemeleri    4
            //            Ödemeler            5
            //            Bilgi Güncelleme    6
            //            //*********************Seçim 1************
            //            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            //            Ana meüye dönmek için   9
            //            Çıkmak için             0
            //            //******************Seçim 2***********************
            //            Kredi Kartına   1
            //            Kendi Hesabınıza yatırmak için  2
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //------------------------------------
            //            //----1
            //            Kredi kardı için en az 12 haneli kart numarasını girsin
            //            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //--------------------------
            //            //---2
            //            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //*****************************Seçim 3
            //            Başka Hesaba EFT    1
            //            Başka Hesaba Havale 2
            //            //---------------------------------
            //            //--1
            //            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------
            //            //---2
            //            hesap için 11 haneli hesap numarası işlemler doğru ise
            //            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************Seçim 4
            //            Eğitim Ödemeleri sayfası arızalı
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************************Seçim 5
            //            Elektrik Faturası       1
            //            Telefon Faturası        2
            //            İnternet faturası       3
            //            Su Faturası             4
            //            OGS Ödemeleri           5
            //            //-----------------------------------------
            //            //---1 => bütün faturala için aşağıdaki şart yeterli
            //            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------------
            //            //***************Seçim 6
            //            Şifre değiştirmek için 1
            //            Şifre değiştirme işlemi gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0



            //            //********Kartsız işlem bölümü

            //            //*******************Ana Menü 
            //            CepBank Para Çekmek 1
            //             Para yatırmak için  2
            //             Kredi Kartı Ödeme   3
            //             Eğitim Ödemeleri    4
            //             Ödemeler            5

            //             //*********************Seçim 1************
            //             TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
            //             Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
            //Ana menüye dönmek için   9
            //             Çıkmak için              0
            //             //******************Seçim 2***********************
            //             Nakit ödeme     1
            //             Hesaptan ödeme  2
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //------------------------------------
            //             //----1
            //          Kredi kartı için en az 12 haneli kart numarasını girsin

            //          Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
            //             Nakit olarak ödeme gerçekleştirin.
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //--------------------------
            //             //---2
            //             Kredi kartı için en az 12 haneli kart numarasını girsin
            // Hesap numarasını girsin

            //             Ana Menü        9
            //             Çıkmak için     0
            //             //*****************************Seçim 3
            //             Başka Hesaba EFT    1
            //             Başka Hesaba Havale 2
            //             //---------------------------------
            //             //--1
            //             EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //             yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------
            //             //---2
            //             hesap için 11 haneli hesap numarası işlemler doğru ise
            //             gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************Seçim 4
            //             Eğitim Ödemeleri sayfası arızalı
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************************Seçim 5
            //             Elektrik Faturası       1
            //             Telefon Faturası        2
            //             İnternet faturası       3
            //             Su Faturası             4
            //             OGS Ödemeleri           5
            //             //-----------------------------------------
            //             //---1 => bütün faturala için aşağıdaki şart yeterli
            //             fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            */
            #endregion

            string password = "ab18";
            int bakiye = 25000;
            int hak = 3;

        KARTLI:
            Console.WriteLine("Kartlı İşlem\t1\nKartsız İşlem\t2\nSeçiminiz:");
            int kartli = Convert.ToInt32(Console.ReadLine());

            if (kartli == 1) 
            {
                while (hak > 0)
                {
                    Console.WriteLine("Şifreniz:");
                    string sifre = Console.ReadLine();
                    hak--;

                    if (sifre == password) 
                    {
                        goto ANAMENU;   
                    }
                    else
                    {
                        Console.WriteLine("Şifre Hatalı!");
                    }
                    if (hak == 0)
                    {
                        Console.WriteLine("Hakkınız Bitti");
                        int sayac = 5;
                        while (sayac > 0)
                        {
                            Console.WriteLine(sayac);
                            sayac--;
                            Thread.Sleep(1000);
                        }
                        
                        goto KARTLI;
                    }
                }

            ANAMENU:
                Console.WriteLine("****** ANA MENÜ ******");
                Console.WriteLine("Para Çekme\t1\nPara Yatırma\t2\nPara Transfer\t3\nEğitim Ödemesi\t4\nFatura Ödeme\t5\nBilgi Güncelle\t6\nSeçiminiz:");
                int islem = Convert.ToInt32(Console.ReadLine());

                if (islem == 1) 
                {
                    Console.WriteLine("Çekilecek Miktar?");
                    int miktar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= miktar) 
                    {
                        bakiye -= miktar;
                        Console.WriteLine("Paranızı Alınız. Yeni Bakiye:"+bakiye);
                    }
                    else
                    { 
                        Console.WriteLine("Yetersiz Bakiye!"); 
                    }
                }
                else if (islem == 2) 
                {
                    Console.WriteLine("Kartta Yatır\t1\nHesaba Yatır\t2\nSeçiminiz:");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1) 
                    {
                        Console.WriteLine("12 Haneli Kart Numarası:");
                        string kartNo = Console.ReadLine();

                        if (kartNo.Length == 12)
                        {
                            if(long.TryParse(kartNo,out _))
                            {
                                Console.WriteLine("Yatıralacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye += miktar;
                                    Console.WriteLine("Paranız Yatırıldı. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kart Numarası RAKAMLARDAN oluşmalıdır!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kart Numarası 12 Haneli Olmalıdır!!");
                        }
                    }
                    else if (secim == 2) 
                    {
                        Console.WriteLine("Yatıralacak Miktar:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        bakiye += miktar;

                        Console.WriteLine("Paranız Yatırıldı. Yeni Bakiye:"+bakiye);
                    }
                    else 
                    {
                        Console.WriteLine("Hatalı Tuşlama!!");
                    }

                }
                else if (islem == 3) 
                {
                    Console.WriteLine("EFT\t1\nHAVALE\t2\nSeçiminiz:");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1) 
                    {
                        Console.WriteLine("Iban Giriniz:");
                        string Iban = Console.ReadLine().ToUpper();

                        if (Iban.StartsWith("TR"))
                        {
                            string IbanNo = Iban.Substring(2);
                            if (IbanNo.Length == 12)
                            {
                                if (long.TryParse(IbanNo, out _))
                                {
                                    Console.WriteLine("Transfer Edilecek Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Paranız Transder Edildi. Yeni Bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("IBAN Numarası RAKAMLARDAN oluşmalıdır!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("IBAN Numarası 12 Haneli Olmalıdır!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Iban bilgisinin başında TR olmalıdır.");
                        }
                    }
                    else if (secim == 2) 
                    {
                        Console.WriteLine("11 Haneli Hesap Numarası:");
                        string hesapNo = Console.ReadLine();

                        if (hesapNo.Length == 11)
                        {
                            if (long.TryParse(hesapNo, out _))
                            {
                                Console.WriteLine("Transfer Edilecek Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Paranız Transfer Edildi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hesap Numarası RAKAMLARDAN oluşmalıdır!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hesap Numarası 11 Haneli Olmalıdır!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama!!");
                    }
                }
                else if (islem == 4) 
                {
                    Console.WriteLine("Eğitim Ödemeleri ARIZALI!!");
                }
                else if (islem == 5) 
                {
                    Console.WriteLine("Elektrik Faturası\t1\nSu Faturası\t2\nDoğalgaz Faturası\t3\nİnternet Faturası\t4\nSeçiminiz:");
                    int fatura = Convert.ToInt32(Console.ReadLine());
                    if (fatura == 1)
                    {
                        Console.WriteLine("Fatura Tutarı:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        if (bakiye >= miktar)
                        {
                            bakiye -= miktar;
                            Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:"+bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!!");
                        }
                    }
                    else if (fatura == 2)
                    {
                        Console.WriteLine("Fatura Tutarı:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        if (bakiye >= miktar)
                        {
                            bakiye -= miktar;
                            Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!!");
                        }
                    }
                    else if (fatura == 3)
                    {
                        Console.WriteLine("Fatura Tutarı:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        if (bakiye >= miktar)
                        {
                            bakiye -= miktar;
                            Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!!");
                        }
                    }
                    else if (fatura == 4)
                    {
                        Console.WriteLine("Fatura Tutarı:");
                        int miktar = Convert.ToInt32(Console.ReadLine());

                        if (bakiye >= miktar)
                        {
                            bakiye -= miktar;
                            Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama!!");
                    }
                }
                else if (islem == 6) 
                {
                    Console.WriteLine("Yeni Şifreniz:");
                    string yenisifre = Console.ReadLine();
                    Console.WriteLine("Tekrar Yeni Şifreniz:");
                    string yenisifre2 = Console.ReadLine();

                    if (yenisifre == yenisifre2)
                    {
                        password = yenisifre;
                        goto KARTLI;
                    }
                    else
                    {
                        Console.WriteLine("Şifreleriniz Uyuşmamaktadır.");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem!!");                   
                }

                Console.WriteLine("Anamenü\t9\nÇıkış\t0\nSeçiminiz:");
                int donus = Convert.ToInt32(Console.ReadLine());
                if (donus == 9)
                {
                    goto ANAMENU;
                }
                else
                {
                    goto KARTLI;
                }

            }
            else if (kartli == 2) { }
            else
            {
                Console.WriteLine("Hatalı Seçim!!");
                goto KARTLI;
            }


        }
    }
}
