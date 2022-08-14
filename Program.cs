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

            // This is what codecademy hinted too. 
            char[] secretMessageArray = secretMessage.ToCharArray();

            // This is what I found on the internet. 
            // char[] secretMessageArray = new char[secretMessage.Length];
            // for (int i = 0; i < secretMessage.Length; i++)
            // {
            //     secretMessageArray[i] = secretMessage[i];
            // }


            foreach (char c in secretMessageArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}
