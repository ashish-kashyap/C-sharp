using System;

namespace CSharpFundamentals {
    class ForEach {
        static void Main(string[] args) {
            var name = "Ashish Kashyap";

    //        for(var i = 0; i < name.Length; i++) {
    //          Console.WriteLine(name[i]);
    //        }

            foreach(var character in name) {
                Console.WriteLine(character);
            }
        }
    }
}