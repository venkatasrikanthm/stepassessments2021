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
            string sample1 = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sample1 += input[i];
            }
            sample1 = sample1.Replace("a", "0");
            sample1 = sample1.Replace("e", "1");
            sample1 = sample1.Replace("i", "2");
            sample1 = sample1.Replace("o", "3");
            sample1 = sample1.Replace("u", "4");
            string encrypt = sample1 + "aca";
            return encrypt;
        }
        public static string Decrypt(string input)
        {
            string sample1 = "";
            for (int i = input.Length - 4; i >= 0; i--)
            {
                sample1 += input[i];
            }
            sample1 = sample1.Replace("0", "a");
            sample1 = sample1.Replace("1", "e");
            sample1 = sample1.Replace("2", "i");
            sample1 = sample1.Replace("3", "o");
            sample1 = sample1.Replace("4", "u");
            return sample1;
        }
        static int Main(string[] args)
        {
            int real = 1;
            while (real == 1)
            {
                Console.WriteLine("enter encrypt or decrypt or exit:");

                string encrypt = Console.ReadLine();
                if (encrypt == "exit")
                {
                    real = 0;
                    return real;
                }
                else if (encrypt == "encrypt" || encrypt == "decrypt")
                {
                    Console.WriteLine("enter text:");
                    string str = Console.ReadLine();

                    switch (encrypt)
                    {
                        case "encrypt":
                            string str1 = Encrypt(str);
                            Console.WriteLine("encrypted:" + str1);
                                                        break;
                        case "decrypt":
                            string str2 = Decrypt(str);
                            Console.WriteLine("decrypted original text:" + str2);
                            break;
                        case "exit":
                            real = 0;
                            return real;
                        default:
                            Console.WriteLine("enter encrypt or decrypt or exit:");
                            break;
                    }
                }
            }
                       return 0;
        }
    }

}