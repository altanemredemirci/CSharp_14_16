namespace _15_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrenci Kayıt Sistemi
            //ANa menüden kayıt ol seçildiğinde dataların alınarak bir listeye kayıt olması lazım

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci.Kayit(ogrenciler);
            Ogrenci.Kayit(ogrenciler);
            Ogrenci.Kayit(ogrenciler);

            
        }

    }

}
