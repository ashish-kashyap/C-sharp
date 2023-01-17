using System;

namespace CSharpFundamentals
{
    class DoWHile
    {
        static void Main(string[] args)
        {
            int number = 10;

            do {
                Console.WriteLine("Value of a: {0}", number);
                number = number + 1;
            }
            while(number < 20);
            Console.ReadLine();
        }
    }
}