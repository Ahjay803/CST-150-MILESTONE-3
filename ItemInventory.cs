using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ALLEN ATKINS
//CST 150
//MILESTONE 3

namespace MILESTONE3CST150
{
    class InventoryItem
    {
        public string shoe { get; private set; }
        public string shoeDesign { get; private set; }
        public string color { get; private set; }
        public string shoeCategory  { get;  }

        public int shoesInStock { get; private set; }

        public int shoePurchased { get; set; } = 0;

        // constructor

        public InventoryItem(string shoeCategory,string shoe, string shoeDesign, string color, int shoesInStock)
        {

            this.shoe = shoe;
            this.shoeDesign = shoeDesign;
            this.color = color;
            this.shoesInStock = shoesInStock;
            this.shoeCategory = shoeCategory;
            
        }

        public void AddItem(int stock)
        {
            shoesInStock += stock;
        }

        public void RemoveItem(int stock)
        {
            shoePurchased -= stock;
        }

        public new string ToString()
        {
            return "Shoe Category: " + shoeCategory + " Shoe: " + shoe + " Shoe Design: " + shoeDesign + " Color: " + color + " Shoes in stock: " + shoesInStock;
        }
    }
}
