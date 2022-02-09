using System;

namespace Humans
{
    class Human
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

        public Human(string name, int str =3, int itl = 3, int dex = 3, int h = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            health = h;
        }



        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= 5 * Strength;
            return target.Health;

        }
    }
}
