using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_3_Inheritance_2
{
    internal class Ortaokul:Ogrenci
    {
        internal List<int> Notlar;

        public Ortaokul()
        {
            Notlar = new List<int>();
        }
    }
}
