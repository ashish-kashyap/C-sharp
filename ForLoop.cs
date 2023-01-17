using System;

namespace CSharpFundamentals
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            for(int a = 10; a < 25; a++) {
                a = a + a;
                Console.WriteLine("Value of a: {0}", a);
            }
        }  
    }
}