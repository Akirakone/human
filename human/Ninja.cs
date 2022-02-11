using System;

namespace Humans
{
    class Ninja:Human
    {

       

        public Ninja(string name):base(name,3,3,175,100)
        {
         
        }
      

        public int Steal(Human target)
        {
            target.dealdamage(5);
            this.dealdamage(-5);
            return Health;
        }
        public override int Attack(Human target)
        {
            int dmg= Dexterity *5;
            target.Dexterity -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} Dexterity!");
            return target.Health;

        }
    }
}