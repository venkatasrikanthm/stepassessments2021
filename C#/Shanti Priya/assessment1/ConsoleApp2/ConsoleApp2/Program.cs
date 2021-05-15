using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int pin_num = 3579;
        public static int Amount = 10000;
        public static void Main(string[] args)
        {


            
                Console.WriteLine("Welcome to ATM Service:");
                Console.WriteLine("Enter 4 digit Pin Number");
                try
                {
                     int pin = int.Parse(Console.ReadLine());
                
                if (pin == pin_num)
                {
                    
                    checkpin();
                }


                else
                {

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("You have entered the wrong pin.Try again");
                        pin = int.Parse(Console.ReadLine());
                        if (pin == pin_num)
                        {
                            checkpin();
                        }
                    }
                    Console.WriteLine("You account has been blocked");
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Only Digits Accepted for pin");
                }
            }
        

            public static void checkpin()
            {
            Console.WriteLine("1.Check balance");
            Console.WriteLine("2.withdraw money");
            Console.WriteLine("3.deposit money");
            Console.WriteLine("4.change PIN number");
            Console.WriteLine("5.Cancel");
            Console.WriteLine("ENTER YOUR CHOICE : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithDraw();
                        break;
                    case 3:
                        Deposit();
                        break;
                    case 4:
                        ChangePin();
                        break;
                    case 5:
                        Console.WriteLine("Thank you");
                        break;
                }
            


            Console.WriteLine("Do u want another transaction");
            string res = Console.ReadLine();
            if (res == "yes")
                checkpin();
            else
                Console.WriteLine("Thank you for using ATM service");
        }

        public static void CheckBalance()
        {
            Console.WriteLine($"Your Current balance is {Amount}");
        }


        public static void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            try
            {
                int amount = int.Parse(Console.ReadLine());
                if (amount % 100 != 0)
                {
                    Console.WriteLine("\n Please enter the amount in the above 100");
                }
                else if (amount > Amount)
                {
                    Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                }
                else
                {
                    Amount = Amount - amount;
                    Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                    Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", Amount);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Amount must be in digits");
            }
        }
        public static void Deposit()
        {

            Console.WriteLine("Enter the deposit money");
            try
            {
                int deposit = int.Parse(Console.ReadLine());
                Amount = Amount + deposit;
                Console.WriteLine("Your amount has been deposited successfully.");
                Console.WriteLine("Your total balance is {0}", Amount);

            }
            catch (Exception e)
            {
                Console.WriteLine("Amount must be in digits");
            }
        }

            /*else
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("You have entered the wrong pin.Try again:");
                    pin = Convert.ToInt32(Console.ReadLine());
                    if (pin == pin_num)
                    {
                        Console.WriteLine("Enter your 4 digit Pin Number");
                         pin = Convert.ToInt32(Console.ReadLine());
                        if (pin == pin_num)
                        {
                            Console.WriteLine("Enter the deposit money");
                            int deposit = int.Parse(Console.ReadLine());
                            Amount = Amount + deposit;
                            Console.WriteLine("Your amount has been deposited successfully.");
                            Console.WriteLine("Your total balance is {0}", Amount);
                        }
                    }
                }
                Console.WriteLine("Your Account is Blocked");

            }
        }*/
        public static void ChangePin()
        {
           
                    Console.WriteLine("Enter New pin");
                    int newpin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Renter  pin");
                    int newpin1 = Convert.ToInt32(Console.ReadLine());
                    if (newpin == newpin1)
                        Console.WriteLine("Your pin changes Successfully");
                    else
                        Console.WriteLine("Your re-entered pin doesn't match");
        }            
    }
 }
