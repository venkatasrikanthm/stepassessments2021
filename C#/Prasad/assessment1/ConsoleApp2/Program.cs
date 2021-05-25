using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

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
            int value = rnd.Next(5,30);
            Console.Write(value);
            return value;
        } 



        static void Main(string[] args)
        {
            
            
            Console.WriteLine("--------->>>>>>>>>>> Welcome to automated token system <<<<<<<<<<---------");
            Console.WriteLine("Choose one option:");
            Show(options);
            Console.Write("Enter:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            switch (id)
            {

                case 1:
                    Console.WriteLine("These are the items and rates:");
                    Show(restaurantItems);
                    Console.WriteLine("-----------------------------------------");
                    goto case 2;
                case 2:
                    Console.WriteLine("Select the item:");
                    for (int i=0;i< items.Count; i++)
                    {
                        Console.WriteLine(items.ElementAt(i).Value + "-" + items.ElementAt(i).Key);
                    }
                    Console.Write("Enter:");
                    int itemName = Convert.ToInt32(Console.ReadLine());
                    var myKey = items.FirstOrDefault(items => items.Key == "Exit").Value;
                    if (itemName == myKey)
                    {
                        goto case 4;
                    }
                    Console.WriteLine("-----------------------------------------");
                    Console.Write("Random time generator is:");
                    int randomTime = RandomNumGenerator();
                    Console.WriteLine();
                    if (randomTime < preparationTime.ElementAt(itemName - 1).Value)
                    {
                        Console.WriteLine("Sorry, your order couldn’t not be placed. You can choose from the following.");
                        for (int i = 0; i < preparationTime.Count; i++)
                        {
                            if (randomTime >= preparationTime.ElementAt(i).Value)
                            {
                                Console.WriteLine(items.ElementAt(i).Value + "-"+preparationTime.ElementAt(i).Key);
                                
                            }
                        }
                        Console.Write("Enter:");
                        int itemNumber = Convert.ToInt32(Console.ReadLine());
                        var itemValue= items.FirstOrDefault(items => items.Value == itemNumber).Value;
                        Console.WriteLine("Your order has been successfully placed.Enjoy your meal.");
                        Console.WriteLine("Order Status:\n{0} - Will be ready in {1} minutes", items.ElementAt(itemNumber).Key, itemValue);

                    }
                    Console.WriteLine("-----------------------------------------");
                    if (randomTime >= preparationTime.ElementAt(itemName - 1).Value)
                    {
                        Console.WriteLine("Your order has been successfully placed. Enjoy your meal.");
                        orderNameForOrderStatus = preparationTime.ElementAt(itemName - 1).Key;
                        randomTimeForOrderStatus = randomTime;
    
                        for (int i = 0; i < options.Count; i++)
                        {
                            if (options.ElementAt(i).Value==3 || options.ElementAt(i).Value == 4)
                            {
                                Console.WriteLine(options.ElementAt(i).Value + "-" + options.ElementAt(i).Key);

                            }
                        }
                        Console.Write("Enter:");
                        int itemN = Convert.ToInt32(Console.ReadLine());
                        if (itemN == 3)
                        {
                            goto case 3;
                        }
                        if (itemN == 4)
                        {
                            goto case 4;
                        }
                    }
                    
                    
                    break;
                case 3:
                    Console.WriteLine("Order Status:\n{0} - Will be ready in {1} minutes", orderNameForOrderStatus, randomTimeForOrderStatus);
                    break;
                case 4:
                    Console.WriteLine("--------->>>>>>>>>>> Thank you for Visiting. Visit Again <<<<<<<<<<---------");
                    break;





            }


        }
    }
}
