using System;

namespace CSharpFundamental {
    class While {
        static void Main(string[] args) {
            while(true) {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                 
                break;
                    

              
            }
        }
    }
}