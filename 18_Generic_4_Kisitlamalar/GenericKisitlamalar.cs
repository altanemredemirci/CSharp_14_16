using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_4_Kisitlamalar
{
    internal class GenericKisitlamalar
    {
      
    }
    // T yerine sadece class'ların gelmesini sağlamak
    // T yerine gelecek tipin yalnızca class olabileceğini belirttik.
    class SadeceClasslar<T> where T : class
    {

    }

    // T yerine sadece struct'ların gelmesini sağlamak
    // T yerine gelecek tipin yalnızca struct olabileceğini belirttik.
    class SadeceStructlar<T> where T : struct
    {

    }

    // T yerine bir interface'i implement etmeye zorlamak
    // T yerine gelecek tipin yalnızca IEnumerable interface'ini implement etmiş olmak zorunda olduğunu belirttik.
    class SadeceForeachIleGezilebilenler<T> where T : IEnumerable
    {

    }

    // T yerine gelecek tipin yalnızca IComparable interface'ini implement etmiş olmak zorunda olduğunu belirttik.
    class SadeceKarsilastirilabilenler<T> where T : IComparable
    {


    }

    // Belli bir sınıftan kalıtılmış olmaya zorlamak
    // T yerine gelecek tipin Urun ya da Urun'den kalıtılmış olmak zorunda olduğunu belirttik!
    // Yani T yerine Personel,Muhendis, Mudur sınıfıdan gelebilir. Bu sınıfların dışında bir tip gelemez!
    public class SadecePersoneller<T> where T : Personel
    {

    }

    // T yerine gelecek tipin yalnızca Mudur sınıfını miras almak zorunda olduğunu belirttik.
    public class SadeceMudur<T> where T : Mudur
    {

    }

    // Varsayılan ctor'u olmaya zorlamak
    // T yerine gelecek tipin mutlaka varsayılan ctor'u olmalıdır
    // Kısacası örneklenmesi garanti olacak tipin gelmesi garanti altına alınmış olur
    class SadeceOrneklenmesiGarantiOlanlar<T> where T : new()
    {
        void Test()
        {
            T obj = new T();
        }
    }

    class Test<T, K, L> where T : class
                     where K : class, IEnumerable
                     where L : struct
    {

    }

}
