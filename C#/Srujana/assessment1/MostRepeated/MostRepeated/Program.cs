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
            List<string> FrequentWords = new List<string>();

            int index;
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());

            //Reading Array of String

            for (index = 0; index < length; index++)
            {
                Console.Write("Enter the string {0} : ", index + 1);
                StrArray[index] = Console.ReadLine();

            }

            // Counting the frquencies of string 

            for (index = 0; index < length; index++)
            {
                if (WordCount.ContainsKey(StrArray[index]))
                {
                    WordCount[StrArray[index]] += 1;
                }
                else
                {
                    WordCount.Add(StrArray[index], 1);
                }
            }

            // printing the word and its respective count

            foreach (KeyValuePair<string, int> WordCountPair in WordCount)
            {
                Console.Write("{0}:{1} ", WordCountPair.Key, WordCountPair.Value);
            }

            //Highest Frequency words

            int count = 0;
            foreach (KeyValuePair<string, int> keyValue in WordCount)
            {
                if (count < keyValue.Value)
                {
                    count = keyValue.Value;
                }
                if (keyValue.Value == count)
                {

                    FrequentWords.Add(keyValue.Key);
                }

            }
            Console.Write("\nMost Frequent Word(s): ");
            foreach (var ele in FrequentWords)
            {
                Console.Write(ele + " ");
            }


        }
    }
}
