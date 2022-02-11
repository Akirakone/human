using System;

namespace Humans
{
    class Wizard
    {
        // Fields for Wizard
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
        }

        public Wizard(string name, int str =3, int itl = 25, int dex = 3, int h = 50)
        {
            Name = name;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            health = h;
        }

         public override int Attack(Human target) 
    {
                    
    }
    }
}