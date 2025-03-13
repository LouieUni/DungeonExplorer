using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        // Property to store player's name
        public string Name { get; private set; }

        // Property to store player's health
        public int Health { get; private set; }

        private List<string> inventory = new List<string>(); // List to store player's inventory

        
        public Player(string name, int health = 100)
        {
            // Check if the player provided an empty or null name and default it to "Adventurer"
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Adventurer";
            }

            // Assign the player's name and health
            Name = name;
            Health = health;
        }

        // Method to allow the player to pick up an item
        public void PickUpItem(string item)
        {
           
            if (inventory.Count == 0)
            {
                // Add the item to the inventory if the player has no items
                inventory.Add(item);
                Console.WriteLine($"You picked up: {item}");
            }
            else
            {
                // If player tries to pick up more than one item, display a message
                Console.WriteLine("You can only carry one item at a time!");
            }
        }

        
        public string InventoryContents()
        {
            
            // If the inventory is empty, return "No items"
            return inventory.Count > 0 ? string.Join(", ", inventory) : "No items";
        }

        // display the player's current status 
        public void DisplayStatus()
        {
            // Output the player's name, health, and inventory to the console
            Console.WriteLine($"Player: {Name} | Health: {Health} | Inventory: {InventoryContents()}");
        }
    }
}