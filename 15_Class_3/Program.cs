namespace _15_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap: BarkodNo,Yazar,KitapAdi

            List<Kitap> kitaplar = new List<Kitap>();

            //Static Kaydet Metodu
            //Kitap.Kaydet(kitaplar);




            //Kitap kitap = new Kitap();
            //kitap.KaydetNonStatic();
            //kitaplar.Add(kitap);




            Kitap kitap = Kitap.Kaydet();
            kitaplar.Add(kitap);

            kitaplar.Add(Kitap.Kaydet());
        }
    }
}
