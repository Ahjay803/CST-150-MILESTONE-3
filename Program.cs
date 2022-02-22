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
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManger sInventory = new InventoryManger();
            Console.WriteLine("The current shoe inventory for SNEAK KNCT: ");
            sInventory.DisplayShoes();
            sInventory.AddItem("Mid", "Air Jordan 13", "Mid", "Black", 10);
            Console.WriteLine("\n");
            Console.WriteLine("Current Shoe Inventory for SNEAK KNCT: ");
            sInventory.DisplayShoes();
            Console.WriteLine("\n");
            sInventory.RemoveItem(2);
            Console.WriteLine("\n");
            Console.WriteLine("Current Shoe Inventory for SNEAK KNCT: ");
            sInventory.DisplayShoes();
            Console.WriteLine("\n");
            Console.WriteLine("Current Shoe Inventory after restocking Nike AF1 Black Low: ");
            sInventory.Restockshoe(0, 10);
            sInventory.DisplayShoes();
            Console.WriteLine("\n");
            Console.WriteLine("Searching for Air Jordan 13s: ");
            Console.WriteLine(sInventory.DisplaySearchShoe(sInventory.ShoeSearch("shoe", "Air Jordan 13")));
            Console.WriteLine("\n");
            Console.WriteLine("Searching for Shoe Inventory with 20 pairs in stock: ");
            Console.WriteLine(sInventory.DisplaySearchShoe(sInventory.ShoeSearch("shoeStock", "20")));


            Console.ReadLine();
        }
    }
}
