using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    { 
        static Dictionary<string, int> items = new Dictionary<string, int>()
        {         {"paste",60 },{ "chips",30},{ "rice",50},{"shampoo",80 },{"drink",40}
            };
      public static void Method()
        {      
            while (true)
            {
                Console.WriteLine("what would you like to buy:");
                string item1 = Console.ReadLine();
                string item = item1.ToLower();
               if(items.ContainsKey(item))
                {
                    while (true)
                    {
                        Console.WriteLine("please enter quantity: ");
                        value = Console.ReadLine();
                        if (int.TryParse(value, out int parsevariable))
                        {
                            quantity = parsevariable;
                            int cost = Calculation(item, quantity);
                            Console.WriteLine("your bill: " + cost);
                            while (true)
                            {
                                Console.WriteLine("would you like to buy other item: ");
                                string wish2 = Console.ReadLine();
                                if (wish2.ToUpper() == "NO")
                                {
                                    Console.WriteLine("thank you");
                                    Console.WriteLine("your bill: " + cost);
                                    break;
                                }
                                else if (wish2.ToUpper() == "YES")
                                {
                                     Method();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("invalid say yes or no ");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("enter integers");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("invalid  say menu items only");
                }
            }    
      }
      public static int quantity,cost=0;
        public static string value;
        public static int Calculation(string item, int quantity)
        {
            if (items.TryGetValue(item, out int price))
            {
                                cost = cost + quantity * price;
              }
            return cost;
                }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minimart:");
            Console.WriteLine("menu:\n\n");
                     for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}\t\t price: {1}",items.ElementAt(i).Key,items.ElementAt(i).Value);
            }
            while (true)
            {
                Console.WriteLine("would you like to buy any item: ");
                string wish = Console.ReadLine();
                if ( wish.ToUpper() == "NO")
                {
                    Console.WriteLine("thank you ");
                    break;
                }
                else if (wish.ToUpper() == "YES")
                {
                                       Method();
                    break;
                }
                else
                {
                    Console.WriteLine("invalid say yes or no");
                }
                           }
            Console.WriteLine("enter a key to exit");
            Console.ReadLine();
        }
    }
}
