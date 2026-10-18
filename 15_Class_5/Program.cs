namespace _15_Class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uye Kayit Sistemi

            //Uye: Username,Fullname,Email,Password

            //Uye Kayit, Uye Silme, Uye Güncelleme

            List<Uye> uyeler = new List<Uye>();
            while (true)
            {
                Console.WriteLine("1-Üye Ekle\n2-Üye Sil\n3-Üye Güncelle\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1) 
                {
                    Uye.Kaydet(uyeler);
                }
                else if (secim == 2) 
                {
                    if (Uye.Sil(uyeler))
                    {
                        Console.WriteLine("Silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Silme İşlemi Başarısız!!");
                    }
                }
                else if (secim == 3) 
                {
                    string result = Uye.Guncelle(uyeler) == true ? "Güncellendi" : "Güncelleme İşlemi Başarısız!!";

                    Console.WriteLine(result);
                }
                else  
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }
        }
    }
}