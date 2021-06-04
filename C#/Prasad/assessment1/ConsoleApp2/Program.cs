using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int globalItemValue;
        static List<int> values = new List<int>();
        static int globalId;
        static int globalItemName;
        static int globalItemN;
        static int globalItemNumber;
        static string orderNameForOrderStatus;
        static int randomTimeForOrderStatus;
        static Dictionary<string, int> options = new Dictionary<string, int>()
        {
            {"Showmenu",1 },
            {"OrderItem",2 },
            {"SeeOrderStatus",3},
            {"Exit",4 }
        };

        static Dictionary<string, int> items = new Dictionary<string, int>()
        {
            {"Idly",1 },
            {"Dosa",2 },
            {"Uthappam",3},
            {"Bread & Omlette",4},
            {"Poha",5},
            {"Pasta",6},
            {"Exit",7 }
        };

        static Dictionary<string, int> restaurantItems = new Dictionary<string, int>()
        {
            {"Idly",11 },
            {"Dosa",22 },
            {"Uthappam",33},
            {"Bread & Omlette",44},
            {"Poha",55},
            {"Pasta",66}
        };

        static Dictionary<string, int> preparationTime = new Dictionary<string, int>()
        {
            {"Idly",5 },
            {"Dosa",10 },
            {"Uthappam",10 },
            {"Bread & Omlette" ,15},
            {"Poha",5},
            {"Pasta",10}
        };

        public static void Show(Dictionary<string, int> dict)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict.ElementAt(i).Key + "-" + dict.ElementAt(i).Value);
            }
        }

        public static int RandomNumGenerator()
        {
            Random rnd = new Random();
            int value = rnd.Next(5, 30);
            Console.Write(value);
            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------->>>>>>>>>>> Welcome to automated token system <<<<<<<<<<---------");
            Console.WriteLine("Choose one option:");
            Show(options);
        InvalidInput1:
            try
            {
                Console.Write("Enter:");
                globalId = Convert.ToInt32(Console.ReadLine());
                if (globalId > 4 || globalId <= 0)
                {
                    Console.WriteLine("Please Enter a valid Input");
                    goto InvalidInput1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a valid Input");
                goto InvalidInput1;
            }

            Console.WriteLine("-----------------------------------------");
            switch (globalId)
            {
                case 1:
                    Console.WriteLine("These are the items and rates:");
                    Show(restaurantItems);
                    Console.WriteLine("-----------------------------------------");
                    goto case 2;
                case 2:
                    Console.WriteLine("Select the item:");
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine(items.ElementAt(i).Value + "-" + items.ElementAt(i).Key);
                    }
                InvalidInput2:
                    try
                    {
                        Console.Write("Enter:");
                        globalItemName = Convert.ToInt32(Console.ReadLine());
                        var myKey = items.FirstOrDefault(items => items.Key == "Exit").Value;
                        if (globalItemName == myKey)
                        {
                            goto case 4;
                        }
                        else if (globalItemName >= items.Count || globalItemName <= 0)
                        {
                            Console.WriteLine("Please Enter a valid Input");
                            goto InvalidInput2;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a valid Input");
                        goto InvalidInput2;
                    }

                    Console.WriteLine("-----------------------------------------");
                    Console.Write("Random time generator is:");
                    int randomTime = RandomNumGenerator();
                    Console.WriteLine();
                    if (randomTime < preparationTime.ElementAt(globalItemName - 1).Value)
                    {
                        Console.WriteLine("Sorry, your order couldn’t not be placed. You can choose from the following.");
                        for (int i = 0; i < preparationTime.Count; i++)
                        {
                            if (randomTime >= preparationTime.ElementAt(i).Value)
                            {
                                Console.WriteLine(items.ElementAt(i).Value + "-" + preparationTime.ElementAt(i).Key);
                                values.Add(items.ElementAt(i).Value);
                            }
                        }
                    InvalidInput4:
                        try
                        {
                            Console.Write("Enter:");
                            globalItemNumber = Convert.ToInt32(Console.ReadLine());
                            foreach (var i in values)
                            {
                                if (i == globalItemNumber)
                                {
                                    //globalItemValue = items.FirstOrDefault(items => items.Value == globalItemNumber).Value;
                                    Console.WriteLine("Your order has been successfully placed.Enjoy your meal.");
                                    Console.WriteLine("Order Status:\n{0} - Will be ready in {1} minutes", items.ElementAt(globalItemNumber - 1).Key, randomTime);
                                    Console.ReadKey();
                                    break;
                                }
                                if (values.IndexOf(i) == values.Count - 1)
                                {
                                    if (i != globalItemNumber)
                                    {
                                        Console.WriteLine("Please Enter a valid Input");
                                        goto InvalidInput4;
                                    }
                                }
                                else if (values.IndexOf(i) < values.Count)
                                {
                                    continue;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please Enter a valid Input");
                            goto InvalidInput4;
                        }
                    }
                    Console.WriteLine("-----------------------------------------");
                    if (randomTime >= preparationTime.ElementAt(globalItemName - 1).Value)
                    {
                        Console.WriteLine("Your order has been successfully placed. Enjoy your meal.");
                        orderNameForOrderStatus = preparationTime.ElementAt(globalItemName - 1).Key;
                        randomTimeForOrderStatus = randomTime;

                        for (int i = 0; i < options.Count; i++)
                        {
                            if (options.ElementAt(i).Value == 3 || options.ElementAt(i).Value == 4)
                            {
                                Console.WriteLine(options.ElementAt(i).Value + "-" + options.ElementAt(i).Key);

                            }
                        }
                    InvalidInput3:
                        try
                        {
                            Console.Write("Enter:");
                            globalItemN = Convert.ToInt32(Console.ReadLine());
                            if (globalItemN == 3)
                            {
                                goto case 5;
                            }
                            else if (globalItemN == 4)
                            {
                                goto case 4;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter a valid Input");
                                goto InvalidInput3;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please Enter a valid Input");
                            goto InvalidInput3;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("You are not Ordered any thing. Please Select the Order");
                    goto case 2;
                case 4:
                    Console.WriteLine("--------->>>>>>>>>>> Thank you for Visiting. Visit Again <<<<<<<<<<---------");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Order Status:\n{0} - Will be ready in {1} minutes", orderNameForOrderStatus, randomTimeForOrderStatus);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
