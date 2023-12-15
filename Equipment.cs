using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmads13p5
{
    internal class Equipment
    {

        // Fields to store the name, weight, and attack bonus of the equipment
        string name;
        double weight;
        int attackBonus;

        public Equipment()
        {
        }

        // Constructor with parameters to initialize the equipment's properties
        public Equipment(string name, double weight, int attackBonus)
        {
            Name = name;
            Weight = weight;
            AttackBonus = attackBonus;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int AttackBonus { get => attackBonus; set => attackBonus = value; }
    }
}