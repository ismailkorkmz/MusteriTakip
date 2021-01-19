using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
           musteri1.Adi = "İsmail Murat";
            musteri1.Soyadi = "KORKMAZ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "İhsan";
            musteri2.Soyadi = "ARVAS";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mert";
            musteri3.Soyadi = "ÇELİK";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Melda";
            musteri4.Soyadi = "KARTAL";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
           

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.MusteriListeleme(musteriler);
            musteriManager.Silme(musteri3);
        }
            
    }
}
