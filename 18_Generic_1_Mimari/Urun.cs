using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_1_Mimari
{
    internal class Urun<T>
    {
        public T Fiyat { get; set; }
        public T Kdv { get; set; }

        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }
}
