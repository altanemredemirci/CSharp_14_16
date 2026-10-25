namespace _15_Class_7_Enum_2
{
    enum Markalar
    {
        Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş
    }
    enum Vitesler
    {
        Otomatik, Manuel, Yarı_Otomatik
    }

    enum Renkler
    {
        Kırmızı, Beyaz, Siyah, Sarı
    }

    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public Otomobil(Markalar marka,Vitesler vites, Renkler renk, int motorHacmi,int kapiSayisi, string model, bool ceker4, bool parkSensoru)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            MotorHacmi = motorHacmi;
            KapiSayisi = kapiSayisi;
            Model = model;
            Ceker4 = ceker4;
            ParkSensoru = parkSensoru;
        }

        public void OtomobilBilgiYaz()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Vites);
            Console.WriteLine(Renk);
            Console.WriteLine(MotorHacmi);
            Console.WriteLine(KapiSayisi);
            Console.WriteLine("4x4:"+Ceker4);
            Console.WriteLine("Park Sensörü:"+ParkSensoru);
            Console.WriteLine(Model);
        }
    }

    class Ticari
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int TasimaKapasitesi;
        public int YolcuKapasitesi;
        public bool Ceker4;

        public Ticari(Markalar marka, Vitesler vites, Renkler renk,int tasimaKapasitesi, int yolcuKapasitesi,bool ceker4)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            TasimaKapasitesi = tasimaKapasitesi;
            YolcuKapasitesi = yolcuKapasitesi;
            Ceker4 = ceker4;
        }

        public void TicariBilgiYaz()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Vites);
            Console.WriteLine(Renk);
            Console.WriteLine(TasimaKapasitesi);
            Console.WriteLine(YolcuKapasitesi);
            Console.WriteLine("4x4:" + Ceker4);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORU
            /*
            Aşağıdaki Sınıfları tanımlayınız.
            Otomobil ve Ticari sınıfları var.
            Her sınıfa ait tüm sınıf özelliklerine atama yapan constructor metotlar tanımlanacaktır.
            Main içinde 2 nesne örneklendirilecektir.

            Sabit veri tipleri(enum):
            Marka:
            Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş
            Vites:
            Otomatik,Manuel,Yarı_Otomatik
            Renk:
            Kırmızı,Beyaz,Siyah,Sarı

            SınıfAdı:Otomobil
            ------------------
            Marka,Vites,Renk,MotorHacmi,KapiSayisi,Model,Ceker4(4x4 mü),Park Sensörü

            public void OtomobilBilgiYaz() => Araca ait tüm bilgiler yazıdırılsın


            SınıfAdı:Ticari
            ------------------
            Marka,Vites,Renk,MotorHacmi,TasimaKapasitesi,Ceker4(4x4 mü),YolcuKapasitesi

            public void TicariBilgiYaz() => Araca ait tüm bilgiler yazıdırılsın
             */
            #endregion

            Otomobil otomobil = new Otomobil(Markalar.Ford, Vitesler.Manuel, Renkler.Beyaz, 1500, 5, "Ranger", true, true);
            Ticari ticari = new Ticari(Markalar.Honda,Vitesler.Otomatik,Renkler.Beyaz,40000,16,true);

            otomobil.OtomobilBilgiYaz();
            ticari.TicariBilgiYaz();

        }
    }
}
