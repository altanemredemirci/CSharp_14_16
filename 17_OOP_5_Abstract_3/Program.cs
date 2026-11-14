namespace _17_OOP_5_Abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Telefon  : decimal AlisFiyati, decimal KarYuzdesi, decimal LisansUcreti - FiyatHesapla()
                Buzdolabi: decimal AlisFiyati, decimal KarYuzdesi - FiyatHesapla()
           */

            Telefon telefon = new Telefon();

            Console.WriteLine("Alış Fiyatı:");
            telefon.AlisFiyati=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Kar Yüzdesi:");
            telefon.KarYuzdesi =Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Lisans Ücreti:");
            telefon.LisansUcreti =Convert.ToDecimal(Console.ReadLine());

            decimal deger = telefon.FiyatHesapla();

            Console.WriteLine("Ödeme:"+deger);


            Buzdolabi buzdolabi = new Buzdolabi();

            Console.WriteLine("Alış Fiyatı:");
            buzdolabi.AlisFiyati = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Kar Yüzdesi:");
            buzdolabi.KarYuzdesi = Convert.ToDecimal(Console.ReadLine());


            decimal deger2 = buzdolabi.FiyatHesapla();

            Console.WriteLine("Ödeme:" + deger2);
        }
    }

    abstract class ElektronikEsya
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public decimal LisansUcreti { get; set; }
        public override decimal FiyatHesapla()
        {
            return (AlisFiyati * KarYuzdesi) + LisansUcreti;
        }
    }

    class Buzdolabi : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;
        }
    }
}
