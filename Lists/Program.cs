using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> items_on_ground = new List<String>();
            List<String> inventory = new List<String>();
            List<String> items_equipped = new List<String>();

            items_on_ground.Add("Apple");
            items_on_ground.Add("Pistol");
            items_on_ground.Add("Water");
            items_on_ground.Add("Flashlight");

            void PickUp(string item)
            {
                if (items_on_ground.Contains(item))
                {
                    items_on_ground.Remove(item);
                    inventory.Add(item);
                }

            }

            void Drop(string item)
            {
                if (inventory.Contains(item))
                {
                    inventory.Remove(item);
                    items_on_ground.Add(item);
                }
                else if (items_equipped.Contains(item))
                {
                    items_equipped.Remove(item);
                    items_on_ground.Add(item);
                }
            }

            void Use(string item)
            {
                if (inventory.Contains(item))
                {
                    inventory.Remove(item);
                    items_equipped.Add(item);
                }
            }

            void ClearInventory()
            {
                inventory.Clear();
            }

            void ShowInventory()
            {
                foreach (String item in inventory)
                {
                    Console.WriteLine(item);
                }
            }

            //

            PickUp("Apple");
            ShowInventory();
            Use("Apple");
            ShowInventory();

            //

            Console.ReadKey(false);
        }
    }
}
