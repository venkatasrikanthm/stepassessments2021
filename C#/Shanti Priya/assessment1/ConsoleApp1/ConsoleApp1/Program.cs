using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Enter encrypt or decrypt");
            string value = Console.ReadLine();
            string val=value.ToLower();
            //int i = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case "encrypt":
                        Console.WriteLine("Enter input text");
                        string str = Console.ReadLine();
                        string res = Encrypt(str);
                        Console.WriteLine($"Encrypted value:{res}aca");
                        break;
                    case "decrypt":
                        Console.WriteLine("Enter input text");
                        string str1 = Console.ReadLine();
                        string result = Decrypt(str1);
                        Console.WriteLine($"Decrepted value:{result}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }

        public static string Encrypt(string str)
        {
            
            string strval = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strval = strval + str[i];
            }
            
            strval=strval.Replace('a', '0');
            strval=strval.Replace('e', '1');
            strval=strval.Replace('i', '2');
            strval=strval.Replace('o', '3');
            strval=strval.Replace('u', '4');
            return strval;
          
        }
        public static string Decrypt(string res)
        {
            string strval = "";
            for (int i = 0; i <= res.Length - 1; i++) 
            {
                strval = strval + res[i];
            }
            
            strval = strval.Replace('0', 'a');
            strval = strval.Replace('1', 'e');
            strval = strval.Replace('2', 'i');
            strval = strval.Replace('3', 'o');
            strval = strval.Replace('4', 'u');
            return strval;
        }
    }
}
