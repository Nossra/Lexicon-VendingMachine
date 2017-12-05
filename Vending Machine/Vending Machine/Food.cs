using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Food : Item, IItems
    {
        bool isLCHF;
        bool isVegetarian;

        public bool IsLCHF { get => isLCHF; set => isLCHF = value; }
        public bool IsVegetarian { get => isVegetarian; set => isVegetarian = value; }

        public Food(string name, int price, int size, bool isLCHF, bool isVegetarian) : base(name, price, size)
        {
            this.isLCHF = isLCHF;
            this.isVegetarian = isVegetarian;
        }

        public void ShowMessage()
        {
            Console.WriteLine("This is a food.");
        }

        public void UseItem()
        {
            Console.WriteLine("You ate your item.");
        }
    }
}
