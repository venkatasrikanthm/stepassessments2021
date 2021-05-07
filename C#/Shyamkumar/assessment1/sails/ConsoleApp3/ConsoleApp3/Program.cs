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
        private static int t,c = 0;
         public static int q;
        public static string e;
        public static int x = 1;
        public static int Calc(string v,int q)
        {
            switch (v)
            {
                case "paste":
                    c = c + q * 80;
                    return c;
                case "shampoo":
                    c = c + q * 120;
                    return c;
                case "chips":
                    c = c + q * 30;
                    return c;
                case "milk":
                    c = c + q * 30;
                    return c;
                case "rice":
                    c = c + q * 800;
                    return c;
                case "drink":
                    c = c + q *40;
                    return c;

                default:
                    Console.WriteLine("say menu items only:");
                    int x = 0;
                    return x;
                    
                   
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minimart:");
            Console.WriteLine("menu: ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("1.paste          price=80 rs");
            Console.WriteLine("2.shampoo        price=120 rs");
            Console.WriteLine("3.chips          price=30 rs");
            Console.WriteLine("4.milk           price=30 rs");
            Console.WriteLine("5.rice           price=800 rs");
            Console.WriteLine("6.drink          price=40 rs");



            while (t==0)
            { 
            Console.WriteLine("would you like to buy any item: ");
            string d = Console.ReadLine();
                if (d == "no")
                {
                    Console.WriteLine("thank you ");
                    t = 1;
                }
                else if (d == "yes")
                {
                    Console.WriteLine("what would you like to buy:");

                    string v = Console.ReadLine();

                    Console.WriteLine("please enter quantity: ");
                    e = Console.ReadLine();
                    int g;
                    if (int.TryParse(e, out g))
                    {


                        q = Convert.ToInt32(e);

                        int c = Calc(v, q);

                        while (x == 1)

                        {
                            Console.WriteLine("do you need anything: ");
                            string l = Console.ReadLine();
                            if (l == "no")
                            {
                                //Console.WriteLine("thank you ");
                                break;

                            }
                            else if (l == "yes")
                            {
                                Console.WriteLine("what item needed: ");

                                string y = Console.ReadLine();
                                Console.WriteLine("please enter quantity: ");
                                e = Console.ReadLine();
                                int f;
                                if (int.TryParse(e, out f))
                                {


                                    q = Convert.ToInt32(e);


                                    c = Calc(y, q);
                                }
                                else
                                {
                                    Console.WriteLine("invalid  say itegers");


                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid say yes or oo ");


                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("invalid  say integer ");
                    }

                    Console.WriteLine("Thank you total bill: " + c);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid say yes or no");

                }
            }
        }
    }
}
