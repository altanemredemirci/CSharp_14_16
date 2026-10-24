namespace _15_Class_6_COnstructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uye uye = new Uye();
            
        }
    }

    class Uye
    {
        internal string KullaniciAdi;
        internal string Sifre;

        public Uye()
        {
            Kayit();
        }

        public void Kayit()
        {
            Console.WriteLine("Kullanıcı Adı:");
            KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre:");
            Sifre = Console.ReadLine();

        }
    }
}
