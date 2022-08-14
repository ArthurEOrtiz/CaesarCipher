using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.WriteLine("Enter the secret message");
            string secretMessage = Console.ReadLine();

            Console.WriteLine(secretMessage);
        }
    }
}
