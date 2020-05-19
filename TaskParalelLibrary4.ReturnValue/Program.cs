using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalelLibrary4.ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir taskten dönüş alma
            //Task<Geri Donus Tipi>

            Task<bool> task = Task<bool>.Factory.StartNew(MyTask);
            Console.WriteLine("MyTask() boolean return: "+task.Result);
            Console.WriteLine("--------------");
            //İlk önce mytask çalışır bitince sumit fonksiyonu çalışır.
            Task<int> taskInt = Task<int>.Factory.StartNew(SumIt, 5);
            Console.WriteLine("SumIT int return "+taskInt.Result);
            task.Dispose();
            taskInt.Dispose();
            Console.WriteLine("Main Thread bitti");
            Console.ReadLine();
        }

        static bool MyTask()
        {
            Thread.Sleep(5000);
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int) v;
            int sum = 0;
            for (; x>10 ; x--)
            {
                sum += x;
            }
            Thread.Sleep(5000);
            return sum;
        }
    }
}
