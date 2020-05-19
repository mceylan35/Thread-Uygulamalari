using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalelLibrary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task=new Task(MyTask);
            Thread t = Thread.CurrentThread;//şuanki threadi al main thread
            Console.WriteLine("Main Thread ID: "+t.ManagedThreadId);
            Console.WriteLine("ID: "+task.Id);
            task.Start();
            for (int i = 0; i < 60; i++)
            {
                    Console.Write(".");
                    Thread.Sleep(100);
            }

            task.Wait();
            Console.WriteLine("Main thread bitti");

            Console.ReadLine();
        }

        static void MyTask()
        {
            Console.WriteLine("MyTask() başladı");
            Console.WriteLine("Current ID "+ Task.CurrentId);
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("MyTask() count :"+count);
            }

            Console.WriteLine("MyTask tamamlandı");
        }
    }
}
