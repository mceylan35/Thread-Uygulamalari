using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalelLibrary3.ContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task=new Task(MyTask);
            Task taskContinue = task.ContinueWith(ContTask);
            task.Start();
            taskContinue.Wait();//Mytask fonksiyonu bitene kadar bekliyor sonra COunttask başlıyoe
            task.Dispose();
            taskContinue.Dispose();
            Console.WriteLine("Main Thread bitti");
            Console.ReadLine();
        }
        static void MyTask()
        {
            Console.WriteLine("MyTask() başladı");
            Console.WriteLine("Current ID " + Task.CurrentId);
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("MyTask() count :" + count);
            }

            Console.WriteLine("MyTask tamamlandı");
        }
        static void ContTask(Task t)
        {
            Console.WriteLine("Devam etme işlemi başladı");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Continuation count is "+count);

            }

            Console.WriteLine("Devam Etme işlemi bitti.");
        }
    }
}
