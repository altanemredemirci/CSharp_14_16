namespace _17_OOP_3_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KALITIM _ MİRAS ALMA - INHERITANCE
            //Ortak özellikleri bulunan birden fazla sınıfın için base bir class oluşturarak ortak özellikleri bu classtan miras alma işlemine kalıtım denir.
            //Kural 1:Her sınıf bir tane miras alabilir.
            //Kural 2:Miras alınan sınıftaki private özellikler haricinde herşey aktarılır.

            //Protected: Sadece tanımlı olduğu ve miras alınan sınıf içerisinde erişilebilir.


            InsanKaynaklari ik = new InsanKaynaklari();
            ik.Ad = "Altan Emre";
            ik.MaasAl();
            ik.MaasYaz();
            ik.Kaydet();
            

            //Personel pers = new Personel();
            //pers.Ad = "Ömer";
            
        }
    }

    class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        protected double Maas { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("Personel Kayıt Metodu...");
            this.Maas = 1000;
        }
    }

    class InsanKaynaklari : Personel
    {
        public int PersonelSayisi { get; set; }

        public void MaasAl()
        {
            Console.WriteLine("Maaş:");
            this.Maas = Convert.ToDouble(Console.ReadLine());
        }

        public void MaasYaz()
        {
            Console.WriteLine(Maas);
        }
    }

    class Muhasebe : Personel
    {
        public int HesapSayisi { get; set; }
    }

    class IT:Personel
    {
        public int ProgramSayisi { get; set; }
    }

    class Yazilim:IT
    {

    }
}
