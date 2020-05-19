using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Paralel Programming: TPL
             * Birden fazla işlemciniz bulunduğu donanımlarda yazılımın gücünü daha etkili bir şekide
             * kullabilmek için belli iş süreçlerini işlemleri farklı işlemcilere dağıtarak aynı anda
             * yapılabilmesini sağlar.
             */
            /* c# ta görev task tabanlıdır.
             Neler Yapılabilir?
             Yeni görevler oluşturmak, bu görevleri başlatmak, duraklatmak ve sonlandırmak mümkündür.
             Bir görevin bittiği yerden başka bir görevi başlatmak mümkündür
             Başarıyla yerine getirilen görevlerin sonucunda değerler döndürmek mümkündür.
             Bir görev kendi içinde alt görevler başlatılabilir.
             Görevler aynı veya farklı thread'ler tarafından yerine getirilebilirler.

             */
            Console.WriteLine("Main Thread başladı");

            Task task = Task.Factory.StartNew(()=>
            {
                Console.WriteLine("Görev Başladı.");
                for (int count = 0; count < 20; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Task count is {0}",count);
                }
            });
            Console.WriteLine("Durum"+task.Status.ToString());
            //task bitene kadar bekletme işlemi
            task.Wait();
            Console.WriteLine("Durum : "+task.Status.ToString());
            task.Dispose();// ramden sil
            Console.WriteLine("Main Thread bitti");
            Console.ReadKey();
        }
    }
}
