namespace _17_OOP_2_Encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DATA ACCESS MODIFIER - ERİŞİM BELİRTECİ
            /*
            public:Bütün solution için erişime açık
            internal:Kendi projesi için erişime açık
            protected:Kalıtım ile miras alınan class için erişime açık
            private:Kendi classı için erişime açık
             */

            //********** ENCAPSULATION **********
            //Belirli bir property gizli tanımlanarak kullanıcının erişimine kapatılır. Gİzli property proje için önemli bilgi barındıracağı için kullanıcının direk değer atamasını istemediğimiz zamanlarda kullanılır.

            //Mesela TC kimlik numarası her kayıt için benzersiz ve en öneli tanım değeridir. Kullanıcının bu değeri girerken 11 haneli rakamlar dizisi olmasını kontrol etmemiz gerekiyor. Bu durumda TC private tanımlanır ve public tanımlı _TC değerine kullanıcıdan veri alınarak kontrol sonucunda private tanımlı TC değişkenine değer atanır.

            Vatandas vatandas = new Vatandas();
            Console.WriteLine("TC:");
            vatandas._TC = Console.ReadLine();

            Console.WriteLine(vatandas._TC);
        }
    }

    class Vatandas
    {
        public string Ad;
        public string Soyad;
        private string TC;

        public string _TC
        {
            //private tanımlı değeri okumamızı sağlar.
            get 
            {
                return TC;
            }
            //set:atanan değeri kontrol eder.
            set
            {
                if (value.Length == 11)
                {
                    long tc;
                    if (long.TryParse(value, out tc))
                    {
                        TC = value;
                    }
                    else
                    {
                        Console.WriteLine("TC rakamlardan oluşur.");
                    }
                }
                else
                {
                    Console.WriteLine("11 haneli olmalıdır.");
                }
            }
        }

    }
}
