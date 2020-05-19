using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread başladı");
            int[] data =new int[100000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            data[1000] = -1;
            data[15000] = -2;
            data[16000] = -3;
            data[671000] = -4;
            data[8105060] = -5;
            data[99081000] = -6;
            data[671000] = -7;
            data[8021000] = -8;
            data[89421000] = -9;
            data[15234000] = -10;
            var result = from val in data.AsParallel().AsOrdered()
                         where val < 0
                         select val;
            //var result = from val in data.OrderBy(i=>i)
            //             where val < 0
            //             select val;
            foreach (var v in result)
            {
                Console.WriteLine(v+ " ");
            }

            Console.WriteLine("Main thread bitti");
            Console.ReadLine();
        }
    }
}
