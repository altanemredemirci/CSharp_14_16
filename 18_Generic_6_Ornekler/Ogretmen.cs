using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_6_Ornekler
{
    internal class Ogretmen
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public List<string> Egitimler { get; set; } = new List<string>();
    }
}
