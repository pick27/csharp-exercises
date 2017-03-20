using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        protected static DateTime latestUpdate;
        protected static List<MenuItem> itemsOnMenu;
        protected static List<MenuItem> allItems;

        public DateTime LatestUpdate { get; set; }
        public List<MenuItem> ItemsOnMenu { get; set; }
        public List<MenuItem> AllItems { get; set; }

        public Menu()
        {
            latestUpdate = DateTime.Now;
            itemsOnMenu = new List<MenuItem>();
            allItems = new List<MenuItem>();
        }
        public void displayMenu()
        {
            StringBuilder wholeMenu = new StringBuilder();
            // last updated

            // appetizers

            // main courses

            // desserts

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
        protected static int nextUniqueId = 1;

        private string name;
        private decimal price;
        private string category; // appetizer, main course, dessert
        private bool newItem;
        private bool onMenu;
        private int uniqueId;
        private DateTime lastUpdate;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public bool NewItem { get; set; }
        public bool OnMenu { get; set; }
        public DateTime LastUpdate { get; set; }

        public MenuItem()
        {
            category = "main course";
            onMenu = false;
            newItem = false;
        }

        public void addMenuItem()
        {
            MenuItem menuItem = new MenuItem();
            uniqueId = nextUniqueId;
            nextUniqueId++;
            editMenuItem(menuItem.uniqueId);
        }

        public void editMenuItem(int uniqId)
        {

        }

        public void displayAll()
        {

        }

        public void displayMenuItem()
        {
            Console.WriteLine("name" + item.name);
            Console.WriteLine("------------------------\n");
        }

        public void deleteMenuItem(MenuItem item)
        {
            // only let them remove items that are not on Menu
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            string thingsToDo = "1) display menu \n2) display all menu items \n3) display a menu item \n4) add a menu item \n5) edit a menu item \n6) add item to menu \n7) remove item from menu \n8) remove item from list of menu items \n0) quit/exit the program \n";
            string done = "99";
            Console.WriteLine("About to try to create Menu object.");
            Menu menu = new Menu();
            Console.WriteLine("Hey it was created.");

            while (done != "0")
            {
                Console.WriteLine(thingsToDo);
                done = Console.ReadLine();
                if (done == "1")
                {
                    menu.displayMenu();
                }
                else if (done == "2")
                {
                    foreach(MenuItem item in menu.AllItems)
                    {
                        item.displayMenuItem();
                    }
                }
                else if (done == "3")
                {
                    // display item name/number to choose from
                    MenuItem item = new MenuItem();
                    item.displayMenuItem();
                }
                else if (done == "4")
                {
                    MenuItem item = new MenuItem();
                    item.addMenuItem();
                    menu.AllItems.Add(item);
                }
                else if (done == "5")
                {
                    // display item name/number to choose from
                    MenuItem item = new MenuItem();
                }
                else if (done == "6")
                {
                    // display item name/number to choose from
                    MenuItem item = new MenuItem();
                    menu.addItemToMenu(item);
                }
                else if (done == "7")
                {
                    // display item name/number to choose from
                    MenuItem item = new MenuItem();
                    menu.ItemsOnMenu.Remove(item);
                }
                else if (done == "8")  // remove item from list of menu items
                {
                    // display item name/number to choose from
                    MenuItem item = new MenuItem();
                    menu.AllItems.Remove(item);
                }
                else if (done == "0")
                {
                    Console.WriteLine("Thanks for testing the program");
                }
                else
                {
                    Console.WriteLine("what you talking about Willis.");
                }
            }
        }
    }
}
