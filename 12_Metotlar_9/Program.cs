namespace _12_Metotlar_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          Bir şirkette çalışan maaş hesaplama programı yazmanız isteniyor.

          Görev 1: Aşağıdaki metotları yazınız
          a) double MaasHesapla(double saatUcreti, int calisilanSaat)

          Parametrelerle gelen saatlik ücret ve çalışılan saati çarparak toplam maaşı hesaplayıp döndüren metot yazın.


          b) double VergiHesapla(double maas)

          Maaşın %20'ini vergi olarak hesaplayıp döndüren metot yazın.


          c) double NetMaasHesapla(double brutMaas, double vergi)

          Brüt maaştan vergiyi çıkararak net maaşı hesaplayıp döndüren metot yazın.


          d) string MaasDurumu(double netMaas)

          Net maaş 150000'den fazla ise "Yüksek Gelir"
          Net maaş 80000-150000 arası ise "Orta Gelir"
          Net maaş 80000'den az ise "Düşük Gelir"
          string olarak döndüren metot yazın (if-else kullanın)



          Görev 2: Main metotunda aşağıdaki işlemleri yapınız
          Kullanıcıdan saatlik ücret ve çalışılan saat bilgilerini alın
          MaasHesapla metodunu çağırarak brüt maaşı hesaplayın
          VergiHesapla metodunu çağırarak vergi miktarını bulun
          NetMaasHesapla metodunu çağırarak net maaşı hesaplayın
          MaasDurumu metodunu çağırarak gelir durumunu öğrenin
          Tüm sonuçları ekrana yazdırın

          */

            Console.WriteLine("Saatlik ücret:");
            double saatUcret = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Çalışılan saat:");
            int calisilanSaat = Convert.ToInt32(Console.ReadLine());

            double maas = MaasHesapla(saatUcret, calisilanSaat);

            double vergi = VergiHesapla(maas);

            double netMaas = NetMaasHesapla(maas, vergi);

            string sonuc = MaasDurumu(netMaas);

            Console.WriteLine(sonuc);

        }
        static double MaasHesapla(double saatUcreti, int calisilanSaat)
        {
            return saatUcreti * calisilanSaat;
        }

        static double VergiHesapla(double maas)
        {
            return maas * 0.2;
        }

        static double NetMaasHesapla(double brutMaas, double vergi)
        {
            return brutMaas - vergi;
        }

        static string MaasDurumu(double netMaas)
        {
            if (netMaas > 150000)
            {
                return "Yüksek Gelir";
            }
            else if(netMaas>80000 && netMaas <= 150000)
            {
                return "Orta Gelir";
            }
            else
            {
                return "Düşük Gelir";
            }
        }
    }
}
