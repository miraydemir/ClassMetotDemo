using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {

            Console.WriteLine("Banka Hesabı Açıldı" + " " + musteri.musteriAdi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Banka Hesabı Silindi" + " " +  musteri.musteriAdi);
        }
    }
}
