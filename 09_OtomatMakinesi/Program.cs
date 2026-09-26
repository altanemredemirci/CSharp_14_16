namespace _09_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Çikolata", "Bisküvi", "Cips", "Soda", "Su" };
            double[] fiyatlar = { 50, 35, 40, 25, 10 };
            double bakiye = 0;
            while (true)
            {
                Console.WriteLine("Otomat Makinesine Hoşgeldiniz!");
                foreach (var urun in urunler)
                {
                    int index = Array.IndexOf(urunler, urun);
                    Console.WriteLine($"{index}. {urun} - {fiyatlar[index]} TL");
                }

                Console.WriteLine("Lütfen almak istediğiniz ürünün numarasını giriniz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 100)
                {
                    Console.WriteLine("Yönetici Paneline Hoşgeldiniz!");

                    Console.WriteLine("0-Ürün Taşıma\n1-Ürün Ekle\n2-Ürün Sil\n3-Fiyat Güncelle\n4-Çıkış\nSeçiminiz:");
                    int yoneticiSecim = Convert.ToInt32(Console.ReadLine());

                    if (yoneticiSecim == 0)
                    {
                        Console.WriteLine("Taşınacak ürünün numarasını giriniz:");
                        int eskiUrun = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Taşınacak ürünün yeni konumunu giriniz:");
                        int yeniUrun = Convert.ToInt32(Console.ReadLine());

                        string eskiUrunAdi = urunler[eskiUrun];
                        double eskiUrunFiyati = fiyatlar[eskiUrun];

                        urunler[eskiUrun] = urunler[yeniUrun];
                        fiyatlar[eskiUrun] = fiyatlar[yeniUrun];

                        urunler[yeniUrun] = eskiUrunAdi;
                        fiyatlar[yeniUrun] = eskiUrunFiyati;

                        Console.WriteLine("Taşınma işlemi tamamlandı.");
                    }

                    else if (yoneticiSecim == 1)
                    {
                        Console.WriteLine("Eklemek istediğiniz ürünün adını giriniz:");
                        string yeniUrun = Console.ReadLine();
                        Console.WriteLine("Eklemek istediğiniz ürünün fiyatını giriniz:");
                        double yeniFiyat = Convert.ToDouble(Console.ReadLine());

                        Array.Resize(ref urunler, urunler.Length + 1);
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                        urunler[urunler.Length - 1] = yeniUrun;
                        fiyatlar[fiyatlar.Length - 1] = yeniFiyat;
                        Console.WriteLine($"{yeniUrun} ürünü eklendi.");
                    }
                    else if (yoneticiSecim == 2)
                    {
                        foreach (var urun in urunler)
                        {
                            int index = Array.IndexOf(urunler, urun);
                            Console.WriteLine($"{index}. {urun} - {fiyatlar[index]} TL");
                        }

                        Console.WriteLine("Silmek istediğiniz ürünün numarasını giriniz:");
                        int silinecekUrun = Convert.ToInt32(Console.ReadLine());

                        if (silinecekUrun >= 0 && silinecekUrun < urunler.Length)
                        {
                            string silinenUrun = urunler[silinecekUrun];
                            for (int i = silinecekUrun; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }
                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                            Console.WriteLine($"{silinenUrun} ürünü silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı ürün numarası!!");
                        }
                    }
                    else if (yoneticiSecim == 3)
                    {
                        foreach (var urun in urunler)
                        {
                            int index = Array.IndexOf(urunler, urun);
                            Console.WriteLine($"{index}. {urun} - {fiyatlar[index]} TL");
                        }

                        Console.WriteLine("Fiyatını güncellemek istediğiniz ürünün numarasını giriniz:");
                        int guncellenecekUrun = Convert.ToInt32(Console.ReadLine());
                        if (guncellenecekUrun >= 0 && guncellenecekUrun < urunler.Length)
                        {
                            Console.WriteLine($"Yeni fiyatı giriniz ({urunler[guncellenecekUrun]}):");
                            double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                            fiyatlar[guncellenecekUrun] = yeniFiyat;
                            Console.WriteLine("Fiyat güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı ürün numarası!!");
                        }
                    }
                    else if (yoneticiSecim == 4)
                    {
                        Console.WriteLine("Yönetici panelinden çıkılıyor...");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim!!");
                    }
                }

                else if (urunler.Length > secim)
                {
                    while (true)
                    {
                        Console.WriteLine("Para girişi yapınız:");
                        bakiye += Convert.ToDouble(Console.ReadLine());

                        if (bakiye >= fiyatlar[secim])
                        {
                            double paraUstu = bakiye - fiyatlar[secim];
                            Console.WriteLine($"{urunler[secim]} aldınız. Para üstünüz: {paraUstu} TL");
                            bakiye = 0; // Bakiye sıfırlanır
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye. Lütfen daha fazla para giriniz.");
                            Console.WriteLine("1 - Para İade\n2 - Para Ekle ");
                            int donus = Convert.ToInt32(Console.ReadLine());

                            if (donus == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Paranız iade edildi.");
                                bakiye = 0;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı ürün numarası!!");
                }
            }


        }
    }


}
