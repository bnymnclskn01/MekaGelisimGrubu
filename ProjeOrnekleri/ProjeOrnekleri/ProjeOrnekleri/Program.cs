using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'den 100'e kadar olan tam sayıların toplanması
            char secim,biletsecim;
            int YetiskinFiyat = 30, OgrenciFiyat = 20, Kisi;
            do
            {
                Console.WriteLine("Bilet Türünü Seçiniz \nYetişkin ise Y'ye\nÖğrenci ise O'ya\nBasınız... : ");
                biletsecim = Convert.ToChar(Console.ReadLine().ToLower());
                switch (biletsecim)
                {
                    case 'y':
                        Console.WriteLine("Kaç Kişilik Bilet Ayırt Edildi : ");
                        Kisi = Convert.ToInt32(Console.ReadLine());
                        YetiskinFiyat *= Kisi;
                        Console.WriteLine("Toplam Tutar : " + YetiskinFiyat);
                        break;
                    case 'o':
                        Console.WriteLine("Kaç Kişilik Bilet Ayırt Edildi : ");
                        Kisi = Convert.ToInt32(Console.ReadLine());
                        OgrenciFiyat *= Kisi;
                        Console.WriteLine("Toplam Tutar : " + OgrenciFiyat);
                        break;
                    default:
                        Console.WriteLine("Yanlış İşlem Yaptınız");
                        break;
                }
                //if (biletsecim == 'y')
                //{
                //    Console.WriteLine("Kaç Kişilik Bilet Ayırt Edildi : ");
                //    Kisi = Convert.ToInt32(Console.ReadLine());
                //    YetiskinFiyat *= Kisi;
                //    Console.WriteLine("Toplam Tutar : " + YetiskinFiyat);
                //}
                //else if (biletsecim == 'o')
                //{
                //    Console.WriteLine("Kaç Kişilik Bilet Ayırt Edildi : ");
                //    Kisi = Convert.ToInt32(Console.ReadLine());
                //    OgrenciFiyat *= Kisi;
                //    Console.WriteLine("Toplam Tutar : " + OgrenciFiyat);
                //}
                //else
                //{
                //    Console.WriteLine("Yanlış İşlem Yaptınız");
                //}
                Console.WriteLine("Yeni İşlem Yaptırmak İçin E'ye İşlemi Bitirmek İçin H'ye Basın");
                secim = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();
            } while (secim != 'h');
            
            Console.ReadKey();
        }
    }
}
#region Döngüler-1
//int toplam = 0, j = 0, k = 1;
//for (int i = 0; i <= 100; i++) // 0 ile 100 arasında sayıların toplamına bakar
//{
//    toplam += i;
//    //toplam = toplam + i;
//}
//Console.Write("1'den 100'e kadar olan sayıların toplamı : {0}", toplam);
//while (j <= 100)
//{
//    toplam += j;
//    j++;
//}
//Console.Write("1'den 100'e kadar olan sayıların toplamı : {0}", toplam);

//do
//{
//    toplam += k;
//    k++;
//} while (k <= 100);
//Console.Write("1'den 100'e kadar olan sayıların toplamı : {0}", toplam);
#endregion