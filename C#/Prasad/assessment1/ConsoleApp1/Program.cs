using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        
        static List<int> takeList = new List<int>();
        public static  List<int> TakeList(int len,int listNum)
        {
            again1:
            try
            {
                for (int i = 0; i < len; i++)
                {
                    Console.Write("Enter the elements of List{0}:", listNum);
                    takeList.Add(Convert.ToInt32(Console.ReadLine()));
                }

            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Exception caught:{0}", e);
                Console.WriteLine("Enter a valid input");
                goto again1;
            }
            
            Console.WriteLine("___________________________");
            return takeList;
        }



        
        public static int  EnterListLength(int listNum)
        {
            int length;
            again2:
            try
            {
                Console.Write("Enter The length of List{0}:", listNum);
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("___________________________");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Exception caught:{0}", e);
                Console.WriteLine("Enter a valid input");
                goto again2;

            }
            
            return length;
        }


        static void Main(string[] args)
        {
            int length1 = EnterListLength(1);
            List<int> list1= TakeList(length1,1);
            int length2 = EnterListLength(2);
            List<int> list2 = TakeList(length2,2);
           
            //Removing the duplicate elements and merging of two lists and sorting
            List<int> uList = list1.Union(list2).ToList();
            uList.Sort();
            Console.WriteLine(string.Join(", ", uList));

        }
    }
}
