using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationHw
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new User();
            for (int i = 0; i < 10; i++)
            {
                var thread = new Thread(account.BeginTransaction);
                thread.Start();
            }
            Console.ReadLine();
        }
    }
}