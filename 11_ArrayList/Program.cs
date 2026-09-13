using System.Collections;

namespace _11_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******* ARRAYLIST *********
            //Arraylist kullanılacağı zaman using System.Collections kütüphanesi projeye dahil edilir. Arraylist belirli bir veritipi ve kapasitesi olmayan bir koleksiyon türüdür.


            //int[] sayilar = new int[10];


            //Boi bir arraylist tanımı
            //ArrayList sayilar = new ArrayList();
            //sayilar.Add("Altan Emre");
            //sayilar.Add('K');
            //sayilar.Add(5);
            //sayilar.Add(5.5);
            //sayilar.Add(5.5f);
            //sayilar.Add(5.5m);

            //ArrayList Elemanları Ekrana Yazdırma

            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //foreach (var item in sayilar) //var:variable 
            //{
            //    Console.WriteLine(item);
            //}

            //Dolu ArrayList Tanımı
            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55, 66, 77 };


            //Console.WriteLine(sayilar[1]);

            //İstenilen Index'e Değerine Eleman Ekleme
            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55, 66, 77 };

            //sayilar.Insert(2, 13);


            //foreach (var item in sayilar) //var:variable 
            //{
            //    Console.WriteLine(item);
            //}


            //COUNT() ve CAPACITY()
            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55, 66, 77, 88, 99};

            //Console.WriteLine(sayilar.Capacity);
            //Console.WriteLine(sayilar.Count);


            //CLEAR()
            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            //sayilar.Clear();

            //Console.WriteLine(sayilar.Capacity);
            //Console.WriteLine(sayilar.Count);


            //REMOVE()
            //sayilar.Remove(88);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);

            //}


            //REMOVEAT()

            //sayilar.RemoveAt(2); //index numarası ile siler.

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //REMOVERANGE()

            //sayilar.RemoveRange(1,3);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            #region Kullanıcıdan aile bireylerinin isimlerini alarak bir arrayliste ekleyinizve ekrana yazdırınız.

            //Console.WriteLine("Aileniz kaç kişi?");
            //int bireySayisi = Convert.ToInt32(Console.ReadLine());

            //ArrayList arrayList = new ArrayList();

            //for (int i = 0; i < bireySayisi; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    string isim = Console.ReadLine();
            //    arrayList.Add(isim);
            //}

            //Console.WriteLine();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            //CLONE()

            //ArrayList sehirler = new ArrayList() { "İstanbul", "Yalova", "Tekirdağ" };

            //ArrayList sehirler2 = (ArrayList)sehirler.Clone();


            //sehirler.Add("Hakkari");


            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");


            //foreach (var item in sehirler2)
            //{
            //    Console.WriteLine(item);
            //}

            #region Kullanıcıdan sayı girmesini isteyelim. Sayı yerine "çık" yazana kadar girdiği sayıları Arrayliste ekleyelim. sayı yerine "çık" yazarsa arraylist içerisindeki sayıları toplayarak ekrana yazdıralım


            int toplam = 0;
            ArrayList sayilar = new ArrayList();

            while (true)
            {
                Console.WriteLine("Sayı:");
                string sayi = Console.ReadLine();

                if (sayi == "çık")
                {
                    break;
                }
                else
                {
                    sayilar.Add(Convert.ToInt32(sayi));
                }
            }


            foreach (int item in sayilar)
            {
                toplam += item;
            }

            Console.WriteLine("Toplam:"+toplam);


            #endregion

        }
    }
}
