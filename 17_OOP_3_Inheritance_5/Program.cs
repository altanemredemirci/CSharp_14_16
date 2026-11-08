namespace _17_OOP_3_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Altan Emre","Demirci");
        }
    }

    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Ogrenci(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
    }

    class IlkOkul : Ogrenci
    {
        public int Notu { get; set; }

        public IlkOkul(string isim, string soyisim,int notu):base(isim,soyisim)
        {
            Notu = notu;
        }
    }

    class IlkOgretim : IlkOkul
    {
        public string Bolum { get; set; }

        public IlkOgretim(string ad, string soyad, int notu,string bolum):base(ad,soyad,notu)
        {
            Bolum = bolum;
        }
    }
}
