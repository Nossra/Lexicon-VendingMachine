using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    abstract class Item
    {
        string name;
        int price;
        int size;

        public int Price { get => price; set => price = value; }
        public int Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }

        public Item(string name, int price, int size)
        {
            this.name = name;
            this.price = price;
            this.size = size;
        }
    }
}
