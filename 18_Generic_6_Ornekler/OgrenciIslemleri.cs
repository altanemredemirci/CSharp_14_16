using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Generic_6_Ornekler
{
    internal class OgrenciIslemleri
    {
        public List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();

        public Sonuc<Ogrenci> Ekle(Ogrenci ogrenci)
        {
            try
            {
                OgrenciListesi.Add(ogrenci);

                return new Sonuc<Ogrenci>
                {
                    BasariliMi = true,
                    Mesaj = "İşlem başarıyla tamamlandı.",
                    Data = ogrenci
                };
            }
            catch (Exception ex)
            {
                return new Sonuc<Ogrenci>
                {
                    BasariliMi = false,
                    Mesaj = $"Hata oluştu! Hata detayı:{ex.Message}",
                    Data = null
                };
            }
        }

        public Sonuc<Ogrenci> Sil(int id)
        {
            try
            {
                var silinecekOgrenci = OgrenciListesi.FirstOrDefault(i => i.Id == id);

                if (silinecekOgrenci != null)
                {
                    OgrenciListesi.Remove(silinecekOgrenci);
                    return new Sonuc<Ogrenci>
                    {
                        BasariliMi = true,
                        Mesaj = "Silme işlemi başarılı bir şekilde gerçekleşti.",
                        Data = silinecekOgrenci
                    };
                }

                else
                {
                    return new Sonuc<Ogrenci>
                    {
                        BasariliMi = false,
                        Mesaj = "Hata oluştu. Hata detayı: Kayıt bulunamadı.",
                        Data = null
                    };
                }
            }
            catch (Exception ex)
            {
                return new Sonuc<Ogrenci>
                {
                    BasariliMi = false,
                    Mesaj = $"Hata oluştu! Hata detayı:{ex.Message}",
                    Data = null
                };
            }
        }

        public Sonuc<List<Ogrenci>> ListeyiGetir()
        {
            try
            {
                return new Sonuc<List<Ogrenci>>
                {
                    BasariliMi = true,
                    Mesaj = "İşlem başarıyla gerçekleşti.",
                    Data = OgrenciListesi
                };
            }
            catch (Exception ex)
            {
                return new Sonuc<List<Ogrenci>>
                {
                    BasariliMi = false,
                    Mesaj = $"Hata oluştu! Öğrenci listesi getirilemedi. Hata detayı:{ex.Message}",
                    Data = null
                };
            }
        }
    }
}
