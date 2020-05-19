using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParalelInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            //aynı anda birden fazla fonksiyonu çalıştırma
            Console.WriteLine("Main Thread Başladı");
            Parallel.Invoke(My1,My2,My3);
            Console.WriteLine("Mail Thread Bitti");
            Console.ReadLine();

        }

        static void My1()
        {
            Console.WriteLine("My1 Başladı");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("My1 count is"+count);
            }

            Console.WriteLine("My1 Bitti");
        }
        static void My2()
        {
            Console.WriteLine("My2 Başladı");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("My2 count is" + count);
            }

            Console.WriteLine("My2 Bitti");
        }
        static void My3()
        {
            Console.WriteLine("My3 Başladı");
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("My3 count is" + count);
            }
            Console.WriteLine("My3 Bitti");
        }
    }
}
