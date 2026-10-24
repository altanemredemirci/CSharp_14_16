namespace _16_Restaurant_Otomasyonu
{
    internal class Program
    {
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

            List<Masa> Masalar = new List<Masa>()
            {
                new Masa(){No=1,Hesap=0},
                new Masa(){No=2,Hesap=0},
                new Masa(){No=3,Hesap=0},
                new Masa(){No=4,Hesap=0},
                new Masa(){No=5,Hesap=0}
            };

            List<Menu> Menuler = new List<Menu>()
            {
                new Menu(){No=1,Ad="Çorbalar",Yemekler = new List<Yemek>()
                    {
                        new Yemek(){No=1,Ad="Mercimek",Fiyat=100},
                        new Yemek(){No=2,Ad="Ezogelin",Fiyat=200},
                        new Yemek(){No=3,Ad="Yayla",Fiyat=150}
                    }
                },

                new Menu(){No=2,Ad="Salatalar",Yemekler = new List<Yemek>()
                    {
                        new Yemek(){No=1,Ad="Sezar",Fiyat=100},
                        new Yemek(){No=2,Ad="Mevsim",Fiyat=200},
                        new Yemek(){No=3,Ad="Ton Balıklı",Fiyat=150}
                    },
                }
            };
        }
    }
}   
