using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class User
    {
        int balance;
        bool isAddingMoney = true;
        int input;

        public int Balance
        {
            get => balance;
            set => balance = value;
        }

        public int Input { get => input; set => input = value; }

        public void IncreaseBalance()
        {
            while (isAddingMoney)
            {
                ConsoleKeyInfo s = Console.ReadKey(true);
                //Ridiculous switch case, but was a first draft and was pressed for time.
                //It worked so i let it be, otherwise I would change it to a normal for loop.
                switch (s.KeyChar)
                {
                    case '1':
                        Balance += VendingMachine.Denominations[0];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '2':
                        Balance += VendingMachine.Denominations[1];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '3':
                        Balance += VendingMachine.Denominations[2];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '4':
                        Balance += VendingMachine.Denominations[3];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '5':
                        Balance += VendingMachine.Denominations[4];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '6':
                        Balance += VendingMachine.Denominations[5];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '7':
                        Balance += VendingMachine.Denominations[6];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case '8':
                        Balance += VendingMachine.Denominations[7];
                        Console.WriteLine("Current Balance: " + Balance);
                        break;
                    case 'S':
                    case 's':
                        Console.Clear();
                        isAddingMoney = false;
                        break;
                    default:
                        Console.WriteLine("\nThere is no such denomination. Try again.");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private void Clear()
        {
            Console.ReadKey(true);
            Console.Clear();
            VendingMachine.PrintItemsForSale();
        }

        public bool Validate()
        {
            bool validating = true;
            
            while (validating)
            {
                ConsoleKeyInfo s = Console.ReadKey(true);
                if (s.KeyChar == 'y' || s.KeyChar == 'Y')
                {
                    validating = false;
                    return true;
                }
                else if (s.KeyChar == 'n' || s.KeyChar == 'N')
                {
                    validating = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("\nInvalid input");
                }
            }            
            return false;
        }

        public bool BalanceCheck()
        {
            if (Balance < VendingMachine.Items[Input-1].Price)
            {
                return false;
            }
            else
            {
                return true;
            }
        }   

        public void PurchaseProduct()
        {
            
            bool purchasing = true;
            VendingMachine.PrintItemsForSale();

            while (purchasing)
            {
                Console.WriteLine("YOUR BALANCE: " + Balance + "\n");                
                ConsoleKeyInfo s = Console.ReadKey(true);
                if (Char.IsDigit(s.KeyChar))
                {
                    Input = int.Parse(s.KeyChar.ToString());

                    if (Input >= 1 && Input <= VendingMachine.Items.Length)
                    {
                        Console.WriteLine("Do you want to buy " + VendingMachine.Items[Input - 1].Name + " for " + VendingMachine.Items[Input - 1].Price + "?\n"
                               + "Y. Yes\n"
                               + "N. No\n");
                        if (Validate())
                        {   if (BalanceCheck())
                            {
                                Balance -= VendingMachine.Items[Input - 1].Price;
                                Console.WriteLine("\nYou bought " + VendingMachine.Items[Input - 1].Name + ". Your balance is: " + Balance);
                                Clear();
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you can't afford that! Try something else or reclaim your change.");
                                Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You declined to buy: " + VendingMachine.Items[Input - 1].Name);
                            Clear();
                        }
                    }
                    else if (input <= 0 || input > VendingMachine.Items.Length)
                    {
                        Console.WriteLine("\nWe don't have that. Try again.");
                    }
                } else if (s.KeyChar == 's' || s.KeyChar == 'S')
                {
                    Console.WriteLine("Stopped purchasing stuff..");
                    Console.ReadKey(true);
                    purchasing = false;
                } else
                {
                    Console.WriteLine("\nWe don't have that. Try again.");
                }
            }
        }
        
    }
}
