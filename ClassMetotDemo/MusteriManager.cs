using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+ " "+ musteri.Soyad + " " + "Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "Silindi");
        }

        public void Liste(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine( musteri.Id +" " + musteri.Ad + " " + musteri.Soyad );
            }
        }
    }
}
