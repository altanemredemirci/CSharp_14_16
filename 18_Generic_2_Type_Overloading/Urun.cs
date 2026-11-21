using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_2_Type_Overloading
{
    internal class Urun<T>
    {
        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }

        public T Fiyat { get; set; }
        public T Kdv { get; set; }
    }

    class Urun<T, K>
    {
        public Urun(T fiyat, K kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }

        public T Fiyat { get; set; }
        public K Kdv { get; set; }
    }
}
