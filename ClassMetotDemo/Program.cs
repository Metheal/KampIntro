using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Ad = "John",
                Soyad = "Smith"
            };

            Musteri musteri2 = new Musteri
            {
                Ad = "Richard",
                Soyad = "Roe"
            };

            Musteri musteri3 = new Musteri
            {
                Ad = "Jane",
                Soyad = "Smith"
            };

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Musteri Ekleme:");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine();

            Console.WriteLine("Tum Musterileri Listeleme:");
            musteriManager.Listele(musteriler);

            Console.WriteLine();

            Console.WriteLine("Musteri Silme:");
            musteriManager.Sil(musteri3);



        }
    }
}
