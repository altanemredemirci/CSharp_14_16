using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_1_Mimari
{
    internal class TestSinifi<T> //Generic Type
    {
        public int nonGenericField { get; set; }

        public T genericField { get; set; } //nesne oluşturulurken veri tipi belirlenecek.
    }
}
