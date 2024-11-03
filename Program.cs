using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ekrana girilen sayıya kadar tek sayıları yazdır
            //    Console.Write("lütfen bir sayı giriniz:");
            //    int sayac =int.Parse(Console.ReadLine());
            //    for (int i = 0; i <= sayac; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);

            //        }
            //    }
            //}
            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını kendi aralarında yazdır

            //           int tektop = 0;
            //           int çifttop = 0;
            //           for(int i = 0; i <= 1000; i++)
            //           {
            //               if (i % 2 == 1)
            //               {
            //                   tektop += i;
            //               }
            //               else
            //               {
            //                   çifttop += i;
            //               }


            //           }

            //Console.WriteLine("tek toplam :" + tektop);
            //               Console.WriteLine("çift toplam :" +çifttop);

            //---------------------------------------------------
            // döngülerle kullanılacak iki tane komut var break continue
            // break sadece çalışılmasını istenilmeyen satırı çalıştırmaz


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;//123 yazar 4 de döngü sonlanır
                    Console.WriteLine(i);

                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                   continue;//12356789   4 ü atlar ve döngü devam eder
                    Console.WriteLine(i);

                }
            }


        }
    }
}
