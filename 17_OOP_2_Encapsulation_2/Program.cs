namespace _17_OOP_2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Üniversite sınav sonuçlarının vize ve final property leri ile alındığı vize'nin %40, final'ın %60 ile ortalamayı hesaplayan bir metot tanımlayınız.
            //vize ve final notlarının 0-100 aralığında olmasına dikkat ediniz. 

            Universite universite = new Universite();
            Console.WriteLine("Vize:");
            universite._vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            universite._final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(universite.Ortalama());

        }
    }
    class Universite
    {
        private int vize;
        private int final;

        public int _vize 
        {
            get
            {
                return vize;
            }
            set
            {
                if(value>=0 && value < 101)
                {
                    vize = value;
                }
                else
                {
                    vize = 0;
                    Console.WriteLine("vize 0 hesaplandı.");
                }
            } 
        }
        public int _final
        {
            get
            {
                return final;
            }
            set
            {
                if (value >= 0 && value < 101)
                {
                    final = value;
                }
                else
                {
                    final = 0;
                    Console.WriteLine("final 0 hesaplandı.");
                }
            }
        }

        public double Ortalama()
        {
            return vize * 0.4 + final * 0.6;
        }
    }
}
