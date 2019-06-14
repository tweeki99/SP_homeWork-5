using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationHw
{
    public class User
    {
        public int Money { get; set; } = 100000;
        private object lockObject = new object();

        public void BeginTransaction()
        {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " начинает работу");
                Random random = new Random();
                for (int i = 0; i < 15; i++)
                {
                    int randomNumber = random.Next(100);

                    if (randomNumber < 50)
                        Money -= 15000;
                    else
                        Money += 15000;
                    Console.WriteLine(Money);
                }
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " закончил работу");
        }
        public void BeginSynchronizationTransaction()
        {
            lock (lockObject)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " начинает работу");
                Random random = new Random();
                for (int i = 0; i < 15; i++)
                {
                    int randomNumber = random.Next(100);
                    if (randomNumber < 50)
                        Money -= 15000;
                    else
                        Money += 15000;
                    Console.WriteLine(Money);
                }
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " закончил работу");
            }
        }
    }
}
