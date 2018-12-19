using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static int res = 1;
        static object o = new object();

        static void Main(string[] args)
        {
            
            for (int i=1;i<10;i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Multip));
                thread.Start(i);
            }

            Console.ReadLine();
        }

        static public void Multip(object a)
        {
            lock (o)
            {
                res = res * (int)a;
                Console.WriteLine($"Результат:{res}, Множитель:{(int)a}");
            }
            
        }
    }
}
