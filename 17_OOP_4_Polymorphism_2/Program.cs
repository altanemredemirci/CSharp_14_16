namespace _17_OOP_4_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Tekstil     : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
             Cep Telefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
             Ekmek       : Ad,Fiyat,Gramaj, EkmekTuru - KDVUygula(%20)


             Nesne özelliklerini constructor metot ile alın.
             */

            Ekmek ekmek = new Ekmek("TamBuğday", 120, 250, "Buğday");

            Sepet sepet = new Sepet();
            sepet.Ekle(ekmek);

            CepTelefonu cepTelefonu = new CepTelefonu("G200",45000,"Bluetooth","Nokia");

            sepet.Ekle(cepTelefonu);

            Console.WriteLine(sepet.ToplamTutar());
        }
    }
    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string ad, double fiyat, string kumasTuru,string beden,string ureticiFirma):base(ad,fiyat)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }

    class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad, double fiyat, string ozellikler, string marka):base(ad,fiyat)
        {
            Ozellikler = ozellikler;
            Marka = marka;
        }

        public override double KDVUygula()
        {
            return Fiyat * 2.2;
        }
    }
    class Ekmek : Urun
    {
        public int Gramaj { get; set; }
        public string EkmekTuru { get; set; }

        public Ekmek(string ad, double fiyat, int gramaj,string ekmekTuru):base(ad,fiyat)
        {
            Gramaj = gramaj;
            EkmekTuru = ekmekTuru;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public void Ekle(Urun urun)
        {
            urun.Fiyat = urun.KDVUygula();
            urunler.Add(urun);
        }

        public string ToplamTutar()
        {
            double toplam = 0;
            foreach (Urun urun in urunler)
            {
                toplam += urun.Fiyat;
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return toplam.ToString("C");
        }
    }
}
