using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[] { 1, 2, 5, 6, -5, -9, 15, 542 };
            var teklar = from s in sayilar where s % 2 != 0 select s;
            Console.WriteLine("sayılar dizisindeki tek sayıları yaz");
            foreach (var item in teklar)
            {
                Console.WriteLine("Tek sayılar: "+item);

            }
            Console.WriteLine("\n");

            var ciftler = sayilar.Where(x =>x%2 == 0);
            Console.WriteLine("Sayılar dizisindeki çift sayılar: ");
            foreach (var item in ciftler)
            {
                Console.WriteLine("çift sayılar: "+item);
            }
            Console.ReadLine();


            ciftler.ToList().ForEach(x =>
                {
                    if (x > 0)
                    {
                        Console.WriteLine(x + " ");
                    }
                });
        }


        //sıfırdan büyük olan çift sayıları getirsin

        

    }
}
