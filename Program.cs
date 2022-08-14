using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the secret message");
            string message = Console.ReadLine().ToLower();
            string secretMessage = Encrypt(message);


            Console.WriteLine($"your entry has encrypted into \"{secretMessage}\", please enter key number to decrypt message");
            string enteredKey = Console.ReadLine();
            int key = Convert.ToInt32(enteredKey);
            string decrypted = Decrypt(secretMessage, key);
            Console.WriteLine(decrypted);

        }

        static string Encrypt(string secretMessage)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            char[] secretMessageArray = secretMessage.ToCharArray();

            char[] encryptedMessageArray = new char[secretMessageArray.Length];


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

                    encryptedMessageArray[i] = alphabet[alphabetPositionPlus3];
                }

            }

            string encryptedMessage = string.Join("", encryptedMessageArray);

            return encryptedMessage;
        }

        static string Decrypt(string secretMessage, int key)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            char[] secretMessageArray = secretMessage.ToCharArray();

            char[] decryptedMessageArray = new char[secretMessageArray.Length];



            for (int i = 0; i < secretMessageArray.Length; i++)
            {   
                if (Char.IsPunctuation(secretMessageArray[i]))
                {
                    continue;
                } else
                {
                    char letter =  secretMessageArray[i];

                    int alphabetPosition = Array.IndexOf(alphabet, letter);
                    int alphabetPositionPlus3 = (alphabetPosition - key) % alphabet.Length;

                    decryptedMessageArray[i] = alphabet[alphabetPositionPlus3];
                }

            }

            string decryptedMessage = string.Join("", decryptedMessageArray);

            return decryptedMessage;
        }
    }
}
