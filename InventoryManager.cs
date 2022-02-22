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
    class InventoryManger
    {
        const int SHOE_COLLECTION_SIZE = 100;
        InventoryItem[] shoeCollection = new InventoryItem[SHOE_COLLECTION_SIZE];
        private int shoeInventory = 0;

        public InventoryManger()
        {
            shoeCollection[0] = new InventoryItem("Lowtops", "Nike AF1", "Low", "Black", 10);
            shoeCollection[1] = new InventoryItem("Lowtops", "Nike AF1", "Low", "White", 10);
            shoeCollection[2] = new InventoryItem("Hightops", "Nike AF1", "High", "Black", 10);
            shoeCollection[3] = new InventoryItem("Hightops", "Nike AF1", "High", "White", 10);
            shoeInventory = 4;
        }

        public void AddItem(string shoeCategory, string shoe, string shoeDesign, string color, int shoeesInStock)
        {
            shoeCollection[shoeInventory] = new InventoryItem(shoeCategory, shoe, shoeDesign, color, shoeesInStock);
            shoeInventory++;
        }

        public void RemoveItem(int index)
        {
            for(int i = 0; (i + index) <= (shoeCollection.Length - 1); i++)
            {
                if ((index + i) == (shoeCollection.Length - 1))
                {
                    shoeCollection[index + i] = null;
                }
                else
                {
                    shoeCollection[index + i] = shoeCollection[index + i + 1];
                }
            }
            shoeInventory--;
        }
        public void Restockshoe(int index, int shoeesInStock)
        {
            shoeCollection[index].AddItem(shoeesInStock);
        }

        public void DisplayShoes()
        {
            for (int i = 0; i < shoeInventory; i++)
            {
                Console.WriteLine(shoeCollection[i].ToString());
            }
        }    

        public string DisplaySearchShoe(int index)
        {
            return shoeCollection[index].ToString();
        }

        public int ShoeSearch(string searchShoe, string foundShoe)
        {
            switch (searchShoe)
            {
                case "shoe":
                    for (int index = 0; index < shoeCollection.Length; index++)
                    {
                        if (shoeCollection[index].shoe == foundShoe)
                        {
                            return index;
                        }
                        if(index == shoeCollection.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
                case "shoeStock":
                    for(int index = 0; index < shoeCollection.Length; index++)
                    {
                        if(shoeCollection[index].shoesInStock == int.Parse(foundShoe))
                        {
                            return index;
                        }
                        if(index == shoeCollection.Length - 1)
                        {
                            return -1;
                        }
                    }
                    break;
            }
            return -1;
        }
    }
}
