using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        private static DateTime latestUpdate;
        private static List<MenuItem> itemsOnMenu;

        public DateTime LatestUpdate { get; set; }
        public List<MenuItem> ItemsOnMenu { get; set; }

        public void displayMenu()
        {
            StringBuilder wholeMenu = new StringBuilder();
            Console.WriteLine(wholeMenu);
        }

        public void addItemToMenu(MenuItem item)
        {
            ItemsOnMenu.Add(item);
            LatestUpdate = DateTime.Now;
        }

        public void removeItemFromMenu(MenuItem item)
        {
            ItemsOnMenu.Remove(item);
            LatestUpdate = DateTime.Now;
        }
    }


    public class MenuItem
    {
        private string name;
        private double price;
        private string category;
        private bool newItem;
        private bool onMenu;
        private DateTime lastUpdate;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set;  }
        public bool NewItem { get; set; }
        public bool OnMenu { get; set; }
        public DateTime LastUpdate { get; set; }

        public void editMenuItem()
        {

        }

        public void displayAll()
        {

        }

        public void deleteMenuItem()
        {
            // only let them remove items that are not on Menu
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
