namespace _15_Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrenci kayıt sistemi
            //öğrenci:Numara,Ad,Soyad,Sınıf

            //List<string> ogrenciler = new List<string>();

            //string numara = "1";
            //string ad = "Ömer";
            //string soyad = "Kale";
            //string sinif = "10-F";

            //ogrenciler.Add(numara);
            //ogrenciler.Add(ad);
            //ogrenciler.Add(soyad);
            //ogrenciler.Add(sinif);

            //string numara2 = "2";
            //string ad2 = "Nesrin";
            //string soyad2 = "Kale";
            //string sinif2 = "9-A";

            //ogrenciler.Add(numara2);
            //ogrenciler.Add(ad2);
            //ogrenciler.Add(soyad2);
            //ogrenciler.Add(sinif);

            Ogrenci ogrenci = new Ogrenci(); //Instance - Örneklem

            ogrenci.Numara = 1;
            ogrenci.Ad = "Altan Emre";
            ogrenci.Soyad = "Demirci";
            ogrenci.Sinif = "11-F";

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci);

            Ogrenci ogrenci2 = new Ogrenci(); 

            ogrenci2.Numara = 2;
            ogrenci2.Ad = "Kıvanç";
            ogrenci2.Soyad = "Demirci";
            ogrenci2.Sinif = "9-F";

            ogrenciler.Add(ogrenci2);

            Console.WriteLine(ogrenciler[0].Ad);
            Console.WriteLine(ogrenciler[0].Soyad);

        }
    }

    class Ogrenci //default internal alır.
    {
        public int Numara; //Property
        internal string Ad;
        internal string Soyad;
        internal string Sinif;
    }
}
