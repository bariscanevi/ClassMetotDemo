using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Can";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Barış";
            musteri2.Soyad = "Canevi";
            musteri2.Id = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Liste(musteriler);
            



        }
    }
}
