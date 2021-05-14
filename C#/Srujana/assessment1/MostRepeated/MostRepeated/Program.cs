using System;
using System.Collections.Generic;

namespace MostRepeated
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] StrArray = new string[10];
            Dictionary<string, int> WordCount = new Dictionary<string, int>();

            int i;
            Console.WriteLine("Enter the lenght of the array: ");
            int length = int.Parse(Console.ReadLine());

            //Reading Array of String

            for (i = 0; i < length; i++)
            {
                StrArray[i]=Console.ReadLine();

            }

            // Counting the frquencies of string 

            for (i = 0; i < length; i++)
            {
                if (WordCount.ContainsKey(StrArray[i]))
                {
                    WordCount[StrArray[i]] += 1;
                }
                else
                {
                    WordCount.Add(StrArray[i],1);
                }
            }
            
            // printing the word and its respective count

            foreach(KeyValuePair<string,int> WordCountPair in WordCount)
            {
                Console.WriteLine("{0}:{1}", WordCountPair.Key, WordCountPair.Value);
            }

            //Highest Frequency

            String Word = "";
            int count = 0;
            foreach(KeyValuePair<string, int> keyValue in WordCount)
            {
                if (count < keyValue.Value)
                {
                    count = keyValue.Value;
                    Word = keyValue.Key;
                }
            }
            
            Console.WriteLine("Most Frequent Word = {0} {1}" ,Word,count);
        }
    }
}
