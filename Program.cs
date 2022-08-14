﻿using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the secret message");
            string message = Console.ReadLine().ToLower();
            Encrypt(message);

        }

        static void Encrypt(string secretMessage)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            char[] secretMessageArray = secretMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessageArray.Length];


            for (int i = 0; i < secretMessageArray.Length; i++)
            {   
                if (Char.IsPunctuation(secretMessageArray[i]))
                {
                    continue;
                } else
                {
                    char letter =  secretMessageArray[i];

                    int alphabetPosition = Array.IndexOf(alphabet, letter);
                    int alphabetPositionPlus3 = (alphabetPosition + 3) % alphabet.Length;

                    encryptedMessage[i] = alphabet[alphabetPositionPlus3];
                }

            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
