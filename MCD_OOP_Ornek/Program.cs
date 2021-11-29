using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOP_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun u1 = new Urun()
                {
                    UrunAdi = "Ekmek",
                    UrunId = 1000,
                    UrunKategorisi = UrunKategorileri.Gıda
                };

                Urun u2 = new Urun()
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Elektronik
                };

                Urun u3 = new Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Gıda
                };

                Urun u4 = new Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Temizlik
                };


                Musteri m = new Musteri()
                {
                    MusteriId=1,
                    Cinsiyeti=Cinsiyetler.Erkek,
                    DogumTarihi=new DateTime(1978,11,29),
                    MusteriAdi="Faik",
                    MusteriSoyadi="Turan",
                };

                UrunSepeti musterininSepeti = new UrunSepeti()
                {
                    MusteriId=m.MusteriId,
                    SepetId=1
                };

                musterininSepeti.UrunListesi.Add(u1);
                musterininSepeti.UrunListesi.Add(u2);
                musterininSepeti.UrunListesi.Add(u3);
                musterininSepeti.UrunListesi.Add(u4);

                m.MusterininUrunSepeti = musterininSepeti; //Önce sepeti ve sepete eklenecek ürünleri yukarıda
                //aldım sonra o sepeti müşterime atadım.

                m.MusteriBilgileriYazdir();
                m.MusterininSepetiniYazdir();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }

            Console.ReadKey();
        }
    }
}
