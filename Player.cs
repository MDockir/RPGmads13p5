using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmads13p5
{
    internal enum PlayerType
    {
        Elver,
        Human
    }

    internal class Player : Base
    {
        List<Equipment> equipment = new List<Equipment>();

        // Constructor for creating a Player instance with specified attributes
        public Player(string name, int hP, int xP, PlayerType playerType) : base(name, hP, xP)
        {
            this.PlayerType = playerType;
        }

        public PlayerType PlayerType { get; set; }

        public override void Attack()
        {
            Console.WriteLine($"{Name} is attacking");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine($"{Name} is using a special ability!");
            // Add special ability logic here
        }

        // Method to equip an item to the player and display information about it
        public void Equip(Equipment item)
        {
            equipment.Add(item);
            Console.WriteLine($"{Name} has equipped {item.Name}. Attack bonus: {item.AttackBonus}");
        }

        // Method to use all equipped items and display information about them
        public void UseEquippedItems()
        {
            foreach (var item in equipment)
            {
                Console.WriteLine($"{Name} is using {item.Name}. Attack bonus: {item.AttackBonus}");
            }
        }


        // Method to simulate a level up by adding experience points (XP)
        public void LevelUp()
        {
            XP1 += 50; // Assuming 50 XP needed to level up
            Console.WriteLine($"{Name} leveled up! Current XP: {XP1}");
        }

        // Overridden ToString method to provide a string representation of the player
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
