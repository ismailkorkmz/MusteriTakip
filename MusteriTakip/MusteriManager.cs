using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi +" "+ musteri.Soyadi );
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
            }
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Id + musteri.Adi + musteri.Soyadi);
        }

    }
}
