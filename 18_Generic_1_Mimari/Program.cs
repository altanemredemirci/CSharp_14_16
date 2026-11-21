namespace _18_Generic_1_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TestSinifi<string> testSinifi = new TestSinifi<string>();

            testSinifi.genericField = "AltanEmre";
            testSinifi.nonGenericField = 10;


            TestSinifi<double> testSinifi2 = new TestSinifi<double>();

            testSinifi2.genericField = 10.5;


            //T yerine double gönderildiği için Fiyat ve Kdv bilgileri double oluştu.
            Urun<double> urun = new Urun<double>(1000.0,18.0);

            Urun<string> urun2 = new Urun<string>("1500","yüzde 20");


        }
    }

    
}
