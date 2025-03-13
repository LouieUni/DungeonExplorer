using System;

namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private string item; // No nullable types
        public string Name { get; private set; } // Added room name

        // Constructor now includes the room name and description
        public Room(string name, string description, string item = "None") // Default item is "None"
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Room name cannot be empty.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Room description cannot be empty.");

            this.Name = name;
            this.description = description;
            this.item = item;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetItem()
        {
            return item;
        }

        // Method to take an item from the room
        public string TakeItem()
        {
            if (item != "None")
            {
                string takenItem = item;
                item = "None"; // No items left after pickup
                return takenItem;
            }
            return "No items left to take.";
        }
    }
}