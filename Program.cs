using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main (string[] args)
        {
            string userDecision = string.Empty;
            
            int totalCoffeeBill = 0;
            do
            {
                int selectionFromMenu = 0;
                Console.WriteLine("Please enter a coffee of your  choice?...");

                //Spacing for the menu
                Console.WriteLine("{0, -9}{1,-15}{2, 0}", "SR.NO", "Coffee", "Price");
                Console.WriteLine("{0, -9}{1,-15}{2, 0}", "1.", "Latte", "2$");
                Console.WriteLine("{0, -9}{1,-15}{2, 0}", "2.", "Cuppaccino", "5$");
                Console.WriteLine("{0, -9}{1,-15}{2, 0}", "3", "Brazil coffee", "8$");
                Console.WriteLine("{0, -9}{1,-15}{2, 0}", "4", "Fruppaccino", "11$");

                selectionFromMenu = int.Parse(Console.ReadLine());

                switch (selectionFromMenu)
                {
                    case 1:
                        totalCoffeeBill += 2;
                        break;
                    case 2:
                        totalCoffeeBill += 5;
                        break;
                    case 3:
                        totalCoffeeBill += 8;
                        break;
                    case 4:
                        totalCoffeeBill += 11;
                        break;
                    default:
                        Console.WriteLine("The selection you have entered is invalid");
                        break;


                }

                do
                {
                    Console.WriteLine("Do you want to add another item?...Yes or No");
                    userDecision = Console.ReadLine().ToUpper();

                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("The entry is invalid");
                    }
                } while (userDecision != "YES" && userDecision != "NO");

            }
            while (userDecision != "NO");


            Console.WriteLine("Thank You!!!");
            Console.WriteLine("Your total bill amount is: " + totalCoffeeBill + "$");
        }
    }
}