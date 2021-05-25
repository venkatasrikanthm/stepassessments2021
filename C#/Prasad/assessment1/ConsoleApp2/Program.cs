using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        

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
                                Console.WriteLine(preparationTime.ElementAt(i).Key);
                            }
                        }
                    }
                    Console.WriteLine("-----------------------------------------");
                    if (randomTime >= preparationTime.ElementAt(itemName - 1).Value)
                    {
                        Console.WriteLine("Your order has been successfully placed. Enjoy your meal.");
                        Console.WriteLine("Order Status:\n{0} - Will be ready in {1} minutes", preparationTime.ElementAt(itemName - 1).Key, randomTime);
                    }

                        break;
                case 3:
                    Console.WriteLine("Please select an order:");
                    goto case 1;
                case 4:
                    Console.WriteLine("--------->>>>>>>>>>> Thank you for Visiting. Visit Again <<<<<<<<<<---------");
                    break;





            }


        }
    }
}
