using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        private static int sample1, cost = 0;
        public static int quantity;
        public static string value;
        public static int sample2 = 1;
        public static int Calculation(string item, int quantity)
        {
            switch (item)
            {
                case "paste":
                    cost = cost + quantity * 80;
                    return cost;
                case "shampoo":
                    cost = cost + quantity * 120;
                    return cost;
                case "chips":
                    cost = cost + quantity * 30;
                    return cost;
                case "milk":
                    cost = cost + quantity * 30;
                    return cost;
                case "rice":
                    cost = cost + quantity * 800;
                    return cost;
                case "drink":
                    cost = cost + quantity * 40;
                    return cost;
                default:
                    int sample2 = 0;
                    return sample2;
            }
        }
        static int Main(string[] args)
        {
            Console.WriteLine("Welcome to Minimart:");
            Console.WriteLine("menu:\n\n");
            Console.WriteLine("1.paste\t\tprice=80 rs");
            Console.WriteLine("2.shampoo\tprice=120 rs");
            Console.WriteLine("3.chips\t\t price=30 rs");
            Console.WriteLine("4.milk\t\tprice=30 rs");
            Console.WriteLine("5.rice\t\tprice=800 rs");
            Console.WriteLine("6.drink\t\tprice=40 rs");
            while (sample1 == 0)
            {
                Console.WriteLine("would you like to buy any item: ");
                string wish = Console.ReadLine();
                if (wish == "no")
                {
                    Console.WriteLine("thank you ");
                    sample1 = 1;
                }
                else if (wish == "yes")
                {
                    while (sample2 == 1)
                    {
                        Console.WriteLine("what would you like to buy:");
                        string item = Console.ReadLine();
                        if (item == "paste" || item == "shampoo" || item == "rice" || item == "milk" || item == "chips" || item == "drink")
                        {
                            while (sample2 == 1)
                            {
                                Console.WriteLine("please enter quantity: ");
                                value = Console.ReadLine();
                                int parsevariable;
                                if (int.TryParse(value, out parsevariable))
                                {
                                    quantity = Convert.ToInt32(value);
                                    int cost = Calculation(item, quantity);
                                    while (sample2 == 1)
                                    {
                                        Console.WriteLine("your bill: " + cost);
                                        Console.WriteLine("do you need anything Wish: ");
                                        string Wish = Console.ReadLine();
                                        if (Wish == "no")
                                        {
                                            break;
                                        }
                                        else if (Wish == "yes")
                                        {
                                            Console.WriteLine("what item needed: ");

                                            string Item = Console.ReadLine();
                                            Console.WriteLine("please enter quantity: ");
                                            value = Console.ReadLine();
                                            int parsevariable2;
                                            if (int.TryParse(value, out parsevariable2))
                                            {
                                                quantity = Convert.ToInt32(value);
                                                cost = Calculation(Item, quantity);
                                            }
                                            else
                                            {
                                                Console.WriteLine("invalid  say integers");
                                            }
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
                                    Console.WriteLine("invalid  say integer ");
                                }
                            }
                            Console.WriteLine("Thank you total bill: " + cost);
                            return sample2 = 0;
                        }
                        else
                        {
                            Console.WriteLine("Invalid say menu items only ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid say yes or no");
                }
            }
            return 0;
        }
    }
}
