using System.Collections;

namespace _11_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ﻿﻿******** MANAV OTOMASYONU *********
            1.Toptancı,Manav ve Müşteri alanlarımız olacak
            2.Manav toptancıdan isteğine göre meyve,sebze alacak ve müşteri de manavın toptancıdan aldığı   ürünleri alabilecek.
            3.Toptancı için meyve ve sebze programın başında tanımlanacak.(Dolu liste yapılacak)
            4.Manav için meyve sebze listeleri boş olarak tanımlanacak
            5.Müşteri için tek liste yeterli boş olarak
            6.Program başladığında HALE HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
            7.M tuşuna basıldıysa Toptancının meyve listesi S tuşuna basıldıysa Toptancının sebze listesi   ekrana yazdırıp manavın bir ürün alması istenecek
            8.Mesela Elma istediyse manavın meyveler listesine elma değeri eklenecek ve kaç kilo diye   sorularak kilo alınacak
            9.Başka bir arzunu var mı? Evet E veya Hayır H
            10.Evet dendiyse Tekrar 6. adıma gidilecek ve işlemler tekrar edilecek
            11.Hayır dendiyse MANAVA HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
            12.Manav Bölümünde müşteri M bastı diyelim 
            13.Manavın toptancıdan aldığı meyveler listelenecek ve müşterinin bir meyve girmesi beklenecek
            14.Mesela Elma istediyse kaç kilo diye sorularak kilo alınacak
            15.Müşterinin istediği kilo ile manavın toptancıdan aldığı elmanın kilosu karşılaştırılacak 
            16.Eğer manavın elinde yeterli miktarda elma varsa müşterinin listesine elma değeri eklenecek
            17.Başka bir arzunu var mı? Evet E veya Hayır H
            18.Evet dendiyse Tekrar 11. adıma gidilecek ve işlemler tekrar edilecek
            19.Hayır dendiyse Müşteri listesi ekrana yazdırılsın.
             
             */

            ArrayList halMeyve = new ArrayList() { "ELMA", "ARMUT", "KİRAZ" };
            ArrayList halSebze = new ArrayList() { "PATLICAN", "SOĞAN", "PATATES" };

            ArrayList manavMeyve = new ArrayList();
            ArrayList manavSebze = new ArrayList();

            ArrayList manavKiloMeyve = new ArrayList();
            ArrayList manavKiloSebze = new ArrayList();


            ArrayList musteri = new ArrayList();

            Console.WriteLine("HALE HOŞGELDİNİZ");

            while (true)
            {
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();


                if (secim == "M") 
                {
                    for (int i = 0; i < halMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halMeyve[i]}");
                    }

                    Console.WriteLine("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    

                    if (urunNo>=0 && urunNo < halMeyve.Count)
                    {
                        string urun = (string)halMeyve[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (manavMeyve.Contains(urun) == false)
                        {
                            manavKiloMeyve.Add(kilo);
                            manavMeyve.Add(urun);
                        }
                        else
                        {
                            int index = manavMeyve.IndexOf(urun);

                            manavKiloMeyve[index] = (int)manavKiloMeyve[index] + kilo;
                        }                      
                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün seçimi!!");
                    }

                }
                else if (secim == "S") 
                {
                    for (int i = 0; i < halSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halSebze[i]}");
                    }

                    Console.WriteLine("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());



                    if (urunNo >= 0 && urunNo < halSebze.Count)
                    {
                        string urun = (string)halSebze[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (manavSebze.Contains(urun) == false)
                        {
                            manavKiloSebze.Add(kilo);
                            manavSebze.Add(urun);
                        }
                        else
                        {
                            int index = manavSebze.IndexOf(urun);

                            manavKiloSebze[index] = (int)manavKiloSebze[index] + kilo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün seçimi!!");
                    }
                }
                else if (secim == "Q") 
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break; 
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }

            while (true)
            {
                Console.WriteLine("MANAVA HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    for (int i = 0; i < manavMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavMeyve[i]}:{manavKiloMeyve[i]}");
                    }

                    Console.WriteLine("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if(urunNo>=0 && urunNo < manavMeyve.Count)
                    {
                        string urun = (string)manavMeyve[urunNo];
                        int mevcutKilo = (int)manavKiloMeyve[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (mevcutKilo >= kilo)
                        {
                            Console.WriteLine("Afiyet Olsun.");

                            musteri.Add(urun);
                            int yeniKilo = mevcutKilo - kilo;

                            if (yeniKilo == 0)
                            {
                                manavMeyve.RemoveAt(urunNo);
                                manavKiloMeyve.RemoveAt(urunNo);
                            }
                            else
                            {
                                manavKiloMeyve[urunNo] = yeniKilo;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Stok!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün seçimi!");
                    }
                }
                else if (secim == "S") 
                {
                    for (int i = 0; i < manavSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavSebze[i]}:{manavKiloSebze[i]}");
                    }

                    Console.WriteLine("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= 0 && urunNo < manavSebze.Count)
                    {
                        string urun = (string)manavSebze[urunNo];
                        int mevcutKilo = (int)manavKiloSebze[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (mevcutKilo >= kilo)
                        {
                            Console.WriteLine("Afiyet Olsun.");

                            musteri.Add(urun);
                            int yeniKilo = mevcutKilo - kilo;

                            if (yeniKilo == 0)
                            {
                                manavSebze.RemoveAt(urunNo);
                                manavKiloSebze.RemoveAt(urunNo);
                            }
                            else
                            {
                                manavKiloSebze[urunNo] = yeniKilo;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Stok!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün seçimi!");
                    }
                }
                else if (secim == "Q") 
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

            }

        }
    }
}
