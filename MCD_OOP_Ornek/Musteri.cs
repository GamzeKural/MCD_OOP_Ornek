using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOP_Ornek
{
    class Musteri
    {
        #region Properties

        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        #endregion


        #region Metotlar

        public bool MusterininDogumGunuMu()
        {
            bool kontrol = false;
            kontrol = (DogumTarihi.Day == DateTime.Now.Day && DogumTarihi.Month == DateTime.Now.Month) ? true : false;
            return kontrol;
        }

        public void MusteriBilgileriYazdir()
        {
            Console.WriteLine($"Müşteri no:{MusteriId} - {MusteriAdi} {MusteriSoyadi}");
        }

        public void MusterininSepetiniYazdir()
        {
            
            if (MusterininUrunSepeti.UrunListesi.Count > 0)
            {
                //Listeyi yazdırmadan önce doğum günü durumuna bakmanız gerekiyor.
                if (MusterininDogumGunuMu()==true)
                {
                    MusterininUrunSepeti.DogumGunuHediyesiEkle();
                    Console.WriteLine("Doğum gününüz kutlu olsun. Gofret hediyemiz sepete eklendi...");
                }

                int sayac = 1;
                foreach (var item in MusterininUrunSepeti.UrunListesi)
                {
                    Console.WriteLine(sayac + ". ürünümüz: "+item.UrunAdi);
                    sayac++;
                }
            }
        }

        #endregion

    }
}
