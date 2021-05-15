using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private const string V = "aca";

        static void Main(string[] args)
        {

            Console.WriteLine("Enter encrypt or decrypt");
            string value = Console.ReadLine();
            Console.WriteLine("Enter input string");
            string str = Console.ReadLine();
            if (value == "encrypt")
            {
                string res = Encrypt(str);
                Console.WriteLine($"Encrypted value:{res}aca");

            }
            else if (value == "decrypt")
            {
                string res = Encrypt(str);
                Console.WriteLine($"Encrypted value:{res}aca");
                string result = Decrypt(Encrypt(str));
                Console.WriteLine($"Decrepted value:{result}");

            }
            else
                Console.WriteLine("Invalid choice");


        }

        public static string Encrypt(string str)
        {
            string strval = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strval = strval + str[i];
            }
            if (strval.Contains('a'))
                strval=strval.Replace('a', '1');
            if (strval.Contains('e'))
                strval=strval.Replace('e', '2');
            if (strval.Contains('i'))
                strval=strval.Replace('i', '3');
            if (strval.Contains('o'))
                strval=strval.Replace('o', '4');
            if (strval.Contains('u'))
                strval=strval.Replace('u', '5');
            return strval;
          
        }
        public static string Decrypt(string res)
        {
            string strval = "";
            for (int i = res.Length - 1; i >= 0; i--)
            {
                strval = strval + res[i];
            }
            if (strval.Contains('1'))
                strval = strval.Replace('1', 'a');
            if (strval.Contains('2'))
                strval = strval.Replace('2', 'e');
            if (strval.Contains('3'))
                strval = strval.Replace('3', 'i');
            if (strval.Contains('4'))
                strval = strval.Replace('4', 'o');
            if (strval.Contains('5'))
                strval = strval.Replace('5', 'u');
            return strval;
        }
    }
}
