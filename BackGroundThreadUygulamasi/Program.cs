using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackGroundThreadUygulamasi
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
         IsBackground= true diyerek thread arka planda çalışır.
         */
            /*
             BackGround Thread (Arka Plan İş Parçacığı) 
             BackGround Thread işletim sistemine özel istekleri bildirmek için kullanılır.
             Yüksek öneme sahip olmayan işlemleri background threadler için kullanılır.
             işlemi bitince  CLR olarak otomatik kapatır.
             IsBackground=true diyerek thread arka planda çalışır.
            */

            Thread thread = new Thread(CalisacakMethod)
            {
                IsBackground = true
            };
            thread.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Ana Thread sona erdi");
            

            /*
             * IsBackgroud=true olduğunda
             *Ana thread 2 saniye bekledikten sonra Console kapanır.
             * Yani CalisacakMethod 4. döngüden sonra console kapanır.
             *
             * IsBackground=false olduğunda
             * Ana thread tüm threadlerin bitmesini bekleyektir.
             * thread işini bitirince console kapanır
             */






        }

       static void CalisacakMethod()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("İşlem : "+i);
                Thread.Sleep(500);
            }

            Console.WriteLine("CalisacakMethod threadi sona erdi");
            Console.ReadLine();
        }

    }
}
