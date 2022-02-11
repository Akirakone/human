using System;

namespace Humans
{
    class Ninja
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
        }

        public Ninja(string name, int str =3, int itl = 3, int dex = 175, int h = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            health = h;
        }

        public int Steal(Human target)
        {
            target.health -= (-5);
            health += (5);
            return Health;
        }
    }
}