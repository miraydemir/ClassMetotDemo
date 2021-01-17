using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri1 = new  Musteri();
            musteri1.Id = 123;
            musteri1.musteriAdi = "Miray";
            musteri1.musteriSoyadi = "Demir";
            musteri1.musteriYasi = 26;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.musteriAdi = "Metehan";
            musteri2.musteriSoyadi = "Demir";
            musteri2.musteriYasi = 11;


            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteriler  in  musteri)
            {
                Console.WriteLine(musteriler.musteriAdi);
                Console.WriteLine(musteriler.musteriSoyadi);
                Console.WriteLine(musteriler.musteriYasi);

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
        }
    }
}
