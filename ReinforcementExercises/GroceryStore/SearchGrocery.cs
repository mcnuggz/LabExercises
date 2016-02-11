using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class SearchGrocery
    {
        
        public void SearchStore()
        {
            Console.WriteLine("What can I help you find today?");
            string searchQuery = Console.ReadLine().ToLower();
            switch (searchQuery)
            {
                case "bread":
                    Console.WriteLine("Bread is located on Aisle 3. You can also find ");
                    break;
                case:
                    Console.WriteLine("Bread is located on Aisle 3.");
                    break;
                case:
                    Console.WriteLine("Bread is located on Aisle 3.");
                    break;
                case:
                    Console.WriteLine("Bread is located on Aisle 3.");
                    break;
                default:
                    Console.WriteLine("Can't find what you are looking for.");
                    break;
            }
        }
    }
}
