using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda da 10 tane yıldız olsun

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Ügen 

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <i; j++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}
            //// veya 
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 10; j >i ; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //// veya
            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Üçgenin birleşimi

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            ////Yarı yükseklik değeri gerekli
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //    //n -= 1;
            //}
            ////Alt Kısım
            //for (int i = n-1; i >= 1; i--)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();                
            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <=n ; i++)
            //{
            //    //boşluklar için
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");                  
            //    }
            //    //yıldızlar için
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();                
            //}

            #endregion

            #region Ters Piramit 

            //int n = 5;
            //for (int i = n; i >= 1; i--) 
            //{
            //    //boşluklar
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k =1; k<=2*i-1; k++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            
            //}


            #endregion


            Console.Read();
        }
    }
}
