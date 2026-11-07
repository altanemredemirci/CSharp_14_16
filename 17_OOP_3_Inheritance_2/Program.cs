namespace _17_OOP_3_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Kolej sisteminde ilkokul,ortaokul ve lise yer almaktadır.
            //ilkokul: No,Ad,Soyad,Veli Telefon,OkumaYazmaBiliyorMu
            //ortaokul:No,Ad,Soyad,Veli Telefon,Notlar
            //lise:No,Ad,Soyad,Veli Telefon,YKSPuanı

            Ortaokul ortaokul = new Ortaokul();
            ortaokul.No = 1;
            ortaokul.Ad = "Sare";
            ortaokul.Soyad = "Kardaşoğlu";
            ortaokul.VeliTelefon = "02125552336";
            ortaokul.Notlar.Add(100);
            ortaokul.Notlar.Add(95);

        }
    }
}
