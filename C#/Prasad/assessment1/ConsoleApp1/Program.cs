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
        public static List<int> TakeList(int len, int listNum)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter the elements of List{0}:", listNum);
                try
                {
                    takeList.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You are Entered a wrong input. Please Enter a valid input.");
                    i = --i;
                }
            }
            Console.WriteLine("___________________________");
            return takeList;
        }

        public static int EnterListLength(int listNum)
        {
            int length;
        again2:
            try
            {
                Console.Write("Enter The length of List{0}:", listNum);
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("___________________________");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You are Entered a wrong input. Please Enter a valid input.");
                goto again2;
            }
            return length;
        }

        static List<int> uList = new List<int>();
        public static List<int> JoinList(List<int> list1, List<int> list2)
        {
            foreach (var i in list1)
            {
                uList.Add(i);
            }
            foreach (var j in list2)
            {
                uList.Add(j);
            }
            return uList;
        }
        public static List<int> RemoveDuplicates(List<int> list)
        {
            foreach (var i in list.ToList())
            {
                int sum = 0;
                foreach (var j in list.ToList())
                {
                    if (i == j)
                    {
                        sum += 1;
                    }
                }
                if (sum > 1)
                {
                    list.Remove(i);
                }
            }
            return list;
        }
        public static void Sort(List<int> list)
        {
            int temp = 0;
            for (int i = 0; i <= list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Console.WriteLine("Output:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int length1 = EnterListLength(1);
            List<int> list1 = TakeList(length1, 1);
            int length2 = EnterListLength(2);
            List<int> list2 = TakeList(length2, 2);

            JoinList(list1, list2);
            RemoveDuplicates(uList);
            Sort(uList);
        }
    }
}
