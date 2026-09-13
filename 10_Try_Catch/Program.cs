namespace _10_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı giriniz:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(sayi/0);
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
            //    }
            //}


            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / 0);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Bir sayı 0'a bölünemez");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çok büyük");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
            //}


            #region Kullanıcıdan 2 sayı alınız. sayıların hatalı olması durumunda sayıyı yeniden isteyiniz ama 2. sayı hatalı ise 1. sayıyı tekrar istemeyiniz.

            int sayi1;
            int sayi2;

            while (true)
            {
                try
                {
                    Console.WriteLine("1.Sayı:");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
                }
              
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("2.Sayı:");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
                }

            }

            Console.WriteLine("Toplam:"+(sayi1+sayi2));
            #endregion




        }
    }
}
