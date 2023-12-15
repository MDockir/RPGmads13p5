using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmads13p5
{
    internal class Monster : Base
    {
        // Constructor for creating a Monster instance with specified attributes
        public Monster(string name, int hP, int xP) : base(name, hP, xP)
        {
        }

        // Override of the Attack method to display a message when the monster attacks
        public override void Attack()
        {
            Console.WriteLine($"{Name} is attacking");
        }

        // Method to simulate the monster taking damage and display the remaining HP
        public void Damage(int amount)
        {
            HP1 -= amount;
            Console.WriteLine($"{Name} took {amount} damage. Remaining HP: {HP1}");
        }

        // Method to check if the monster is dead based on its remaining HP
        public bool IsDead()
        {
            return HP1 <= 0;
        }
    }
}

    
