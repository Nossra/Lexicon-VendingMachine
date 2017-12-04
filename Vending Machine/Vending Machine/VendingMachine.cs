using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class VendingMachine
    {
        static int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        static Item[] items;
        
        public static Item[] Items { get => items; set => items = value; }
        public static int[] Denominations { get => denominations; private set => denominations = value; }

        public VendingMachine()
        {
            items = new Item[]
            {
                new Drink("Fanta", 100, 33, true, false),
                new Drink("Apelsin MER", 120, 500, false, true),
                new Food("Snickers", 115, 55, false, false),
                new Food("LCHF Sandwich", 125, 80, true, false),
                new Drink("PowerKing ZERO", 107, 350, true, false),
                new Food("Eggs Benedict", 110, 2, true, true)
            };
        }

        public void PrintMoney()
        {
            for (int i = 0; i < Denominations.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Denominations[i]);
            } 
        }        

        public static void PrintItemsForSale()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Items[i].Name + ", PRICE: " + Items[i].Price + ":-,  SIZE: " + Items[i].Size);
            }
            Console.WriteLine("\nS. Stop using the vendor machine.\n");
        }

        public void ReturnChange(int Balance)
        {
            Console.WriteLine("\nReturning change..\n" + Balance + " returns..");
            //loop the same code as much as there are numbers of denominations
            for (int j = 1; j <= Denominations.Length; j++)
            {
                //As long as the users balance is higher than the highest denomination, reduce the balance with that denomination.
                //The code repeats from the highest denomination to the lowest.
                int x = 0;
                for (int i = Balance; i >= Denominations[Denominations.Length - j]; i -= Denominations[Denominations.Length - j])
                {
                    x++; //increment x to count how many times it iterates = its the amount of bills for that denomination.
                    Balance -= Denominations[Denominations.Length - j];
                }
                if (!(x == 0))
                {
                    Console.WriteLine(x + " x " + Denominations[Denominations.Length - j]);
                }
            }
            Console.WriteLine("\nThank you for visiting our vending machine, Have a good day!");
        }
    }
}
