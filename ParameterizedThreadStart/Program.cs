using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThreadStart
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
        IsBackground= true; diyerek thread arka planda çalışır. Ana programa etki etmez
        */
        /*
         * Parameterized Thread Start
         * Bir threadin parametreli olarak başlatılması sağlar.
         * Delegate kullanarak yaparız.
         */
         AddParams ap=new AddParams(10,20);

         Thread t=new Thread(new System.Threading.ParameterizedThreadStart(Add));
         t.Start(ap);

        Console.ReadLine();


        }

        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("Id of thread in main(): {0}",Thread.CurrentThread.ManagedThreadId); //main threadin idsini al
                AddParams ap=(AddParams)data;
                Console.WriteLine("{0} + {1} = {2}",ap.a,ap.b,ap.a+ap.b );
            }
        }
    }

    class AddParams
    {
        public int a { get; set; }
        public int b { get; set; }

        public AddParams(int num1, int num2)
        {
            this.a = num1;
            this.b = num2;
        }
    }
}
