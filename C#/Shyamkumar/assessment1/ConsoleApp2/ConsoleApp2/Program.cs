using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssessment1
{
  class Algoo

    {
       
        public static string Replace(string s)
        {
            s = s.Replace("a", "0");
            s = s.Replace("e", "1");
            s = s.Replace("i", "2");
            s = s.Replace("o", "3");
            s = s.Replace("u", "4");
            return s;
        }
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }

         static void Main(string[] args)
        {
            Console.WriteLine("enter text:");
            string str = Console.ReadLine();
            string str1 = Replace(str);
            string str2 = Reverse(str1);
            Console.WriteLine("encrypted:"+str2 + "aca");
            Console.WriteLine("decrypted original text:"+str );

        }


    }
}