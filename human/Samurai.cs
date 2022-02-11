using System;

namespace Humans
{
    class Samurai
    {
        // Fields for Samurai
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
        }

        public Samurai(string name, int str =3, int itl = 3, int dex = 3, int h = 200)
        {
            Name = name;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            health = h;
        }
        public int Meditate(Human target)
        {
            health = 200;
            return Health;
        }
    }
}