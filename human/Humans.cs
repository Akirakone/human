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

        public void dealdamage(int amount)
        {
           health -= amount;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg= Strength *3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;

        }
    }
}
