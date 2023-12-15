using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmads13p5
{
    internal abstract class Base
    {
        string name;
        int HP;
        int XP;

        // Protected constructor to initialize the base attributes of the entity
        protected Base(string name, int hP1, int xP1)
        {
            Name = name;
            HP1 = hP1;
            XP1 = xP1;
        }

        public string Name { get => name; set => name = value; }
        public int HP1 { get => HP; set => HP = value; }
        public int XP1 { get => XP; set => XP = value; }

        public abstract void Attack();

        // Method to simulate the entity taking damage and display the remaining HP
        public void Damage(int amount)
        {
            HP1 -= amount;
            Console.WriteLine($"{Name} took {amount} damage. Remaining HP: {HP1}");
        }

        // Method to check if the entity is dead based on its remaining HP
        public bool IsDead()
        {
            return HP1 <= 0;
        }
    }


}
