namespace _16_Restaurant_Otomasyonu
{
    internal class Program
    {
        static List<Masa> Masalar = new List<Masa>()
            {
                new Masa(){No=1,Hesap=0},
                new Masa(){No=2,Hesap=0},
                new Masa(){No=3,Hesap=0},
                new Masa(){No=4,Hesap=0},
                new Masa(){No=5,Hesap=0}
            };

        static List<Menu> Menuler = new List<Menu>()
        {
            new Menu(){No=1,Ad="Çorbalar",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Mercimek",Fiyat=100},
                    new Yemek(){No=2,Ad="Ezogelin",Fiyat=200},
                    new Yemek(){No=3,Ad="Yayla",Fiyat=150}
                }
            },
            new Menu(){No=2,Ad="Balıklar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Levrek",Fiyat=100},
                    new Yemek(){No=2,Ad="Kalamar",Fiyat=200},
                    new Yemek(){No=3,Ad="Karides",Fiyat=150}
                }
            },
            new Menu(){No=3,Ad="Salatalar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Sezar",Fiyat=100},
                    new Yemek(){No=2,Ad="Ton Balıklı",Fiyat=200},
                    new Yemek(){No=3,Ad="Mevsim",Fiyat=150}
                }
            },
            new Menu(){No=4,Ad="Etler",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Pirzola",Fiyat=100},
                    new Yemek(){No=2,Ad="Biftek",Fiyat=200},
                    new Yemek(){No=3,Ad="Lokum",Fiyat=150}
                }
            },
            new Menu(){No=5,Ad="Makarnalar",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Spagetti",Fiyat=100},
                    new Yemek(){No=2,Ad="Bolanezli",Fiyat=200},
                    new Yemek(){No=3,Ad="Köri Soslu",Fiyat=150}
                }
            },
            new Menu(){No=6,Ad="İçecekler",Yemekler=new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Kola",Fiyat=100},
                    new Yemek(){No=2,Ad="Rakı",Fiyat=200},
                    new Yemek(){No=3,Ad="Şalgam",Fiyat=150}
                }
            }
        };

        //Restaurant Siparişler
        static List<Siparis> RestaurantSiparisleri = new List<Siparis>();

        //Müşteri Sipariş
        static List<Yemek> MusteriSiparisi = new List<Yemek>();


        static double kazanc = 0;
        static void Main(string[] args)
        {
            #region RESTAURANT OTOMASYONU
            /*
               Başlangıçta Çorbalar,Salatalar,Makarnalar,Etler,Balıklar,İçecekler diye içlerinde 3'er adet yemek kaydı olan menüler(listeler) tanımlanacaktır.

           Restaurant bünyesinde 5 adet masa bulunacaktır.

           Uygulama çalıştığında ekrana aşağıdaki menü gelecek
               1-Sipariş Al
               2-Hesap Al
               3-Masa Durumu
               4-Z Raporu
               5-Çıkış
               100-Yönetici Girişi

           *** 1-Sipariş Al 
           Her gelen yeni müşteri veya müşteriler ilk boş masaya oturtulacaktır.

           Kaç kişi oldukları öğrenildikten sonra sırasıyla müşterilere Menülerden yemek seçmeleri istenilecektir.
           Menüler:
               Çorbalar
               Salatalar
               Makarnalar
               Etler
               Balıklar
               İçecekler
           seçilen menü içerisindeki 3 yemek adı ekrana yazıdrılacak ve seçim yapılması istenilecektir.

           seçim sonrası başka bir arzunuz var mı? Evet ise menüler tekrar yazdırılacak
                                                   Hayır ise diğer müşteriye geçilecek


           *** 2-Hesap Al
           Hangi masa olduğu sorulacak ve seçilen masadaki toplam tutar ekrana yazdırılacak.
           Hesap Ödendi Mi? Evet ise masayı boşaltacağız ve Z raporuna tutarı ekleyeceğiz.

            */
            #endregion

            while (true)
            {
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\n3-Masa Durumu\n4-Günlük Kazanç\n5-Çıkış\n100-Yönetici Girişi\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1) 
                {
                    Masa musteriMasa = Masa.MasaDoldur(Masalar); //ilk boş masayı müşteri masası olarak geri döndürür.
                    if (musteriMasa == null)
                    {
                        Console.WriteLine("Yerimiz Yok!");
                        continue;
                    }

                    Console.WriteLine("Kaç Kişi?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                    Siparis siparis = new Siparis();
                    siparis.MasaNo = musteriMasa.No;

                    for (int i = 0; i < kisiSayisi; i++)
                    {
                        while (true)
                        {
                            Menu secilenMenu = Menu.MenuSec(Menuler);

                            if (secilenMenu == null)
                            {
                                Console.WriteLine("Hatalı Menü SEçimi!!");
                                continue;
                            }

                            Yemek secilenYemek = Siparis.YemekSec(secilenMenu);

                            if (secilenYemek == null)
                            {
                                Console.WriteLine("Hatalı Yemek Seçimi!!");
                                continue;
                            }
                            siparis.Siparisler.Add(secilenYemek);
                            MusteriSiparisi.Add(secilenYemek);//Gereksiz olabilir.
                            Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                            string cevap = Console.ReadLine().ToUpper();

                            if (cevap == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    RestaurantSiparisleri.Add(siparis);

                }
                else if (secim == 2) 
                {
                    Masa.MasaDurumu(Masalar);
                    int sonuc = Masa.HesapOde(RestaurantSiparisleri, Masalar, ref kazanc);
                    if (sonuc == 1)
                    {
                        Console.WriteLine("Yine Bekleriz.");
                    }
                    else if (sonuc == -100)
                    {
                        Console.WriteLine("Hesap Ödenmedi.");
                    }
                    else if(sonuc == -101)
                    {
                        Console.WriteLine("Hatalı Masa Seçimi!!");
                    }
                    else
                    {
                        Console.WriteLine("Bilinmeyen Hata. Lütfen Sistem Yöneticiniz ile İletişime Geçiniz.");
                    }
                    Thread.Sleep(5000); // 5 Saniye bekletme işlemi yapar.

                }
                else if (secim == 3) 
                {
                    Masa.MasaDurumu(Masalar);
                }
                else if (secim == 4) 
                {
                    Console.WriteLine("Günlük kazanç:"+kazanc);
                }
                else if (secim == 5) 
                {
                    break;
                }
                else if (secim == 100) 
                {
                    Console.WriteLine("1-Yemek Ekle\n2-Yemek Sil\n3-Yemek Güncelle\nSeçiminiz:");
                    int secimYemek = Convert.ToInt32(Console.ReadLine());
                    if (secimYemek == 1) 
                    {
                        Yemek.Ekle(Menuler);
                    }
                    else if (secimYemek == 2) 
                    {
                        Yemek.Sil(Menuler);
                    }
                    else if (secimYemek == 3) 
                    {
                        Yemek.Guncelle(Menuler);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem Seçimi!");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }
       
        }
    }
}   
