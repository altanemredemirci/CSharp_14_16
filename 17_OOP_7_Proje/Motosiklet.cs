using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_7_Proje
{
    internal class Motosiklet : Arac
    {

        public int MotorHacmi { get; set; }
        public bool YanCantaVarMi { get; set; }


        public Motosiklet(string marka, string model, int yil, string plaka, double gunlukKiralamaBedeli, int motorHacmi, bool yanCantaVarMi) : base(marka, model, yil, plaka, gunlukKiralamaBedeli)
        {
            MotorHacmi = motorHacmi;
            YanCantaVarMi = yanCantaVarMi;
        }

        public override void AracBilgileriniGoster()
        {
            GenelBilgi();
            Console.WriteLine(MotorHacmi);
            Console.WriteLine(YanCantaVarMi);
        }

        public override string AracTipiGetir()
        {
            throw new NotImplementedException();
        }

        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukKiralamaBedeli * gun + (YanCantaVarMi == true ? 50 : 0);
        }

    }
}
