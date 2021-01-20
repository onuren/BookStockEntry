using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKayitOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç kitap kaydedeceksiniz?");
            int adet = Convert.ToInt32(Console.ReadLine());

            kitap[] kitapDizi = new kitap[adet];

            for (int i = 0; i < adet; i++)
            {
                kitap ktp = new kitap();

                Console.WriteLine("Lütfen {0}. kitap adını giriniz:  ", (i + 1));
                ktp.kitapAdi = Console.ReadLine();

                Console.WriteLine("Lütfen {0}. kitabın yayınevini giriniz:  ", (i + 1));
                ktp.yayinEvi = Console.ReadLine();

                Console.WriteLine("Lütfen {0}. kitabın yazarını giriniz:  ", (i + 1));
                ktp.yazar = Console.ReadLine();

                Console.WriteLine("Lütfen {0}. kitabın basım yılını giriniz:  ", (i + 1));
                ktp.basimYili = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0}. kitabın adedini giriniz:  ", (i + 1));
                ktp.adet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen {0}. kitabın fiyatını giriniz:  ", (i + 1));
                ktp.fiyat = Convert.ToDouble(Console.ReadLine());

                kitapDizi[i] = ktp;
            }
            Console.WriteLine("-----------------Stokta Olan Kitaplar----------------");
            for (int i = 0; i < kitapDizi.Length; i++)
            {

                if (kitapDizi[i].adet>0)
                {
                    Console.WriteLine((i+1)+". Kitabın Adı: " + kitapDizi[i].kitapAdi + " - Yazar: " + kitapDizi[i].yazar + " - Fiyatı: " + kitapDizi[i].fiyat);
                }
            }
        }
    }
}
