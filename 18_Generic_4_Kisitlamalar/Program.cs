using System.Collections;

namespace _18_Generic_4_Kisitlamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new GenericClass<int>();
            new GenericClass<string>();
            new GenericClass<bool>();
            new GenericClass<Personel>();
            new GenericClass<Mudur>();
            new GenericClass<Muhendis>();

            new SadeceClasslar<Personel>();
            new SadeceClasslar<Muhendis>();
            new SadeceClasslar<Mudur>();
            new SadeceClasslar<string>();
            //new SadeceClasslar<int>(); int bir class olmadığı için T yerine gönderilemez!

            new SadeceStructlar<StructTest>();
            new SadeceStructlar<int>();
            new SadeceStructlar<char>();
            new SadeceStructlar<double>();
            //new SadeceStructlar<string>(); // string bir reference tip olduğu için verilemez!

            new SadeceForeachIleGezilebilenler<SadeceForeachIleGezilebilen>();
            new SadeceForeachIleGezilebilenler<GezilebilenVeKarsilastirilabilen>();
            new SadeceForeachIleGezilebilenler<Array>();
            new SadeceForeachIleGezilebilenler<ArrayList>();

            //new SadecePersoneller<string>(); // string bir Personel class'a ait üye olmadığı için verilemez!
            new SadecePersoneller<Personel>();
            new SadecePersoneller<Mudur>();
            new SadecePersoneller<Muhendis>();

            new SadeceOrneklenmesiGarantiOlanlar<Muhendis>();
            //new SadeceOrneklenmesiGarantiOlanlar<Orneklenemeyen>(); // Orneklenemeyen class'ı private ctor'a sahip olduğu için verilemez!
            //new SadeceOrneklenmesiGarantiOlanlar<Orneklenemeyen2>();

          

            new Test<Personel, SadeceForeachIleGezilebilen, StructTest>();
            new Test<string, ArrayList, int>();


           
        }
    }


    class GenericClass<T>
    {
        public T GenericProperty { get; set; }
    }

    struct StructTest
    {

    }

    class SadeceForeachIleGezilebilen : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class SadeceKarsilastirilabilen : IComparable
    {
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }

    class Orneklenemeyen
    {
        private Orneklenemeyen()
        {

        }
    }

    abstract class Orneklenemeyen2
    {

    }

    class GezilebilenVeKarsilastirilabilen : IEnumerable, IComparable
    {
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
