namespace _15_Class_6_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR METHOD - Yapıcı(Kurucu) Metot
            /*
             Class ile aynı isme sahip ve herhangi bir dönüş tipi(void,int,return) almayan metotdur.
             Classtan nesne oluşturulduğu an otomatik çalışır.
             */

            Ogrenci ogrenci = new Ogrenci();
        }
    }

    class Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

        //public Ogrenci()
        //{
        //    //Class tanımı ile arkaplana default olarak constructor metot tanımlanır.
        //}

        public Ogrenci()
        {
            Console.WriteLine("Constructor Metot Çalıştı");
            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }
}
