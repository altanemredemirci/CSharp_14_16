using System.Threading.Channels;

namespace _17_OOP_5_Abstract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *** ABSTRACT - SOYUTLAMA ***
             * ABSTRACT NEDİR?
             * Abstract özelliği bitr classın base class olarak tanımlanmasını ve Instance alınmamasını sağlar.
             * Abstract tanımlı property miras alınan sınıfta çağrılmak zorundadır.
             * C#'da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğü kullanılır.
             * Abstract tanımlı bir metot sadece abstract tanımlı bir sınıfta olabilir.
             * Abstract tanımlı sınıflar abstract metotlar gibi normal tanımlı metotlarda barındırabilir.
             * Ad,Soyad gibi propertylerde abstract olabilirler.
             
             */

            Insan insan = new Insan(); //Class Abstract tanımlı olması sebebiyle örnek (nesne) oluşturulumaz.

            Vatandas vatandas = new Vatandas();
            Memur memur = new Memur();
            memur.Sil();
        }
    }

    public abstract class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Kaydet();
        public abstract void Guncelle();
        public abstract void Sil();

        public void Yaz()
        {
            Console.WriteLine("Yaz Metodu");
        }
        
        
    }

    class Vatandas : Insan
    {
        public string TC { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("TC:");
            TC = Console.ReadLine();

        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }

    class Memur : Insan
    {
        public double Maas { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kaydet()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}

