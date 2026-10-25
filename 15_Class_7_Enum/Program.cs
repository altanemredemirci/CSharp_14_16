namespace _15_Class_7_Enum
{
    //Enum:Sabit Veri Tipleri
    enum Gunler
    {
        Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }

    enum Marka
    {
        Ford, Mazda, Toyota, Chevrolet, BMW, Mercedes, VW
    }

    internal class Program
    {
      


        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan.Ad = "Altan Emre";
            insan.Soyad = "Demirci";
            insan.DogumGunu = Gunler.Pazartesi;
            insan.Marka = Marka.BMW;
            insan.Araba = Arabalar.Tasit2;

            Console.WriteLine(insan.Araba);
            Console.WriteLine(insan.Marka);
            Console.WriteLine(insan.DogumGunu);
        }
    }

    class Insan
    {
        public string Ad;
        public string Soyad;
        public Gunler DogumGunu;
        public Marka Marka;
        public Arabalar Araba;
    }
}
