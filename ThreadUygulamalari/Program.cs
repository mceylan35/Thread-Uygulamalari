using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadUygulamalari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             IsAlive  : Thread'in çalışma durumunu verir. thread yaşıyor mu ölümü olduğunu verir.
             Name     : Threadin adını verir ya da atama işlemi yaparız.
             Priority : Threadin çalışma önceliğini atama yaparak bildiririz. ya da öncelik bilgisini alırız.
             Abort    : ThreadAbortException hatasını atarak thread çalışmasını iptal eder.
             Resume   : Beklemeye geçirilmiş threadin çalışmasını devam etmesini sağlar. Dispose olmuyor
             Sleep    : Belirtilen süre kadar beklemeye geçer.
             Suspend  : Thread'i geçici süre durdurur. Resume ile devam ettirebiliriz.

             */
            Console.WriteLine("Main thread starting");
            IsParcacigi isci=new IsParcacigi("Child 1");
            Thread newThread =new Thread(isci.Run);
            
            newThread.Start();
            do
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            } while (isci.Count!=10);
            Console.WriteLine("Main thread ending");
            Console.ReadLine();
        }
    }

    class IsParcacigi
    {
        public int Count { get; set; }
        public Thread thread { get; set; }

        public IsParcacigi(string name)
        {
            Count = 0;
            thread = new Thread(this.Run)
            {
                Name = name
            };
            thread.Start();
        }

        public void Run()
        {
            Console.WriteLine(thread.Name +" starting");
            do
            {
             Thread.Sleep(500);
             Console.WriteLine("In "+ thread.Name+" Count is "+Count);
             Count++;

            } while (Count<=10);

            Console.WriteLine(thread.Name+"Sonlandırıldı");
        }
    }
}
