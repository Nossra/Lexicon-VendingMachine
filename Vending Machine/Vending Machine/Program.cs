using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            User user = new User();
            Console.WriteLine("Add some money:");
            vm.PrintMoney();
            user.IncreaseBalance(); //Clears console
            user.PurchaseProduct();
            vm.ReturnChange(user.Balance);
            
            /*TODO
             * Implement validation for when your balance is too low for an item
             * Add another product type
             * Show message about how the product is used, being different for all product types.
             * Items should inherit methods to be overriden from an interface.
             * Examine item option to show everything about it.
             */
        }
    }
}
