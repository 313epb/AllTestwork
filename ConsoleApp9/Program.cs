using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(++i);
            Console.ReadLine();
        }

        static int Sum(int a, int b, out int c)
        {
            c = 8;
            return a + b;
        }

        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }

        private static void Calc()
        {
            int result = 0;
            var x = 5;
            int y = 0;
            try
            {
                result = x / y;
            }
            catch (MyCustomException e)
            {
                Console.WriteLine("Catch DivideByZeroException");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch Exception");
            }
            finally
            {
                throw new MyCustomException();
            }
        }
    }

    class MyCustomException : DivideByZeroException
    {

    }

    public class A
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class B : A
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class C : B
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }

    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
}
