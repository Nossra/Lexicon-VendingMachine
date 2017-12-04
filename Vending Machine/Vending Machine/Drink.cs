using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Drink : Item
    {
        bool isCarbonated;
        bool includesStraw;

        public bool IsCarbonated { get => isCarbonated; set => isCarbonated = value; }
        public bool IncludesStraw { get => includesStraw; set => includesStraw = value; }

        public Drink(string name, int price, int size, bool isCarbonated, bool includesStraw) : base(name, price, size)
        {
            this.isCarbonated = isCarbonated;
            this.includesStraw = includesStraw;
        }
    }
}
