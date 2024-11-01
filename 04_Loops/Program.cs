using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adei giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue ; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları
            //1-100 5 e tam bölünen sayılar

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //n*(n+1)/2
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //1-20 çift sayı toplamı
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(totalValue);

            //1-50 7 ye tam bölünen kaç sayı vardır
            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //        count++;
            //}
            //Console.WriteLine(count);


            //başlangıçta 1 bakteri var ve her saat sonunda 2 ye bölnerek çoğalıyor 24 saat sonunda bu ortamda kaç bakteri vardır?
            //1-2-4-8-16
            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2 ;
            //    Console.WriteLine(i+ ".Saat Sonunda: "+bacterium);
            //}

            //Console.WriteLine("24.Saat Sonunda " + bacterium);

            #endregion

            #region While Döngsü

            //Şart sağlandığı müddetçe döngü devam eder
            //arttırma işlemi işlemlerinn old yerde yapılır.
            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine(i+" Merhaba Dünya");
            //    i++;
            //}

            //1-10 arasnda 3 e tam bölnen sayılar
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i %3== 0) 
            //    {
            //        Console.WriteLine(i);
            //    }                
            //    i++;
            //}

            //1-10 arasındaki sayıların toplamı
            //int i = 1;
            //int sum= 0;
            //while (i<=10) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("3 Basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //Console.WriteLine(ones+"-"+tens+"-"+hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);


            #endregion

            Console.Read();
        }
    }
}




