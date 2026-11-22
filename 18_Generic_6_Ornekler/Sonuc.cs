using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_6_Ornekler
{
    internal class Sonuc<T>
    {
        public string Mesaj { get; set; }
        public bool BasariliMi { get; set; }
        public T Data { get; set; }
    
    
    }
}
