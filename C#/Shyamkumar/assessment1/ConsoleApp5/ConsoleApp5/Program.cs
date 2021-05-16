using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssessment1
{
    class Algorithm
    {
        public static string Encrypt(string input)
        {
            string sampleString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sampleString += input[i];
            }
            sampleString = sampleString.Replace("a", "0");
            sampleString = sampleString.Replace("e", "1");
            sampleString = sampleString.Replace("i", "2");
            sampleString = sampleString.Replace("o", "3");
            sampleString = sampleString.Replace("u", "4");
            string encrypt = sampleString + "aca";
            return encrypt;
        }
        public static string Decrypt(string input)
        {
            string sampleString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sampleString += input[i];
            }
            sampleString = sampleString.Replace("0", "a");
            sampleString = sampleString.Replace("1", "e");
            sampleString = sampleString.Replace("2", "i");
            sampleString = sampleString.Replace("3", "o");
            sampleString = sampleString.Replace("4", "u");
            return sampleString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter encrypt or decrypt:");
            string input = Console.ReadLine();
            if (input == "encrypt")
            {
                Console.WriteLine("enter text:");
                string samplestring = Console.ReadLine();
                string samplestring1 = Encrypt(samplestring);
                Console.WriteLine("encrpted:" + samplestring1);
            }
            else if (input == "decrypt")
            {
                Console.WriteLine("enter text:");
                string samplestring = Console.ReadLine();
                string samplestring2 = Decrypt(samplestring);
                Console.WriteLine("decrypted original text:" + samplestring2);
            }
           else
            {
                Console.WriteLine("invalid text:");

            }
            Console.WriteLine(" enter any key to exit:");
            Console.ReadLine();
        }
        
    }
}

