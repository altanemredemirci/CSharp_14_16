namespace _17_OOP_3_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsanKaynaklari ik = new InsanKaynaklari();
            ik.Kaydet();
        }
    }

    class Vatandas
    {
        public long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("TC:");
            TC = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }

    class InsanKaynaklari : Vatandas
    {
        public int PersonelSayisi { get; set; }

        //public new void Kaydet() //Name Hiding
        //{
        //    Console.WriteLine("TC:");
        //    TC = Convert.ToInt64(Console.ReadLine());
        //    Console.WriteLine("Ad:");
        //    Ad = Console.ReadLine();
        //    Console.WriteLine("Soyad:");
        //    Soyad = Console.ReadLine();
        //    Console.WriteLine("Personel Sayisi:");
        //    PersonelSayisi = Convert.ToInt32(Console.ReadLine());
        //} 

        public new void Kaydet() //Name Hiding
        {
            base.Kaydet(); //base: miras alınan sınıfı işaret eder.

            Console.WriteLine("Personel Sayisi:");
            PersonelSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
