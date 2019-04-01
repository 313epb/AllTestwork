using System;

namespace ConsoleApp9
{
    public partial class Pclass
    {
        public Int32 i;

        partial void PartMethod()
        {
            Console.WriteLine($"{i} PClass1");
        }
    }
}