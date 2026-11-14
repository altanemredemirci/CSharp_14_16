namespace _17_OOP_6_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ŞİRKET:
            //Personel:Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas
            //Robot   :Id,Departman,ToplamCalismaSaati
            //Mudur   :Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas,PersonelSayisi
        }
    }

    interface ICalisan
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
    }

    interface IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
    }

    class Robot : ICalisan
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
    }

    class Personel : ICalisan, IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
    }

    class Mudur : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
        public int PersonelSayisi { get; set; }
    }
}
