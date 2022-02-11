using System;

namespace Humans
{
    class Wizard :Human
    {
     

        public Wizard(string name):base (name, 3,25,3,50)
        {
        }
        public void Heal(Human target)
        {
            int healAmt = -10 * Intelligence;    
            target.dealdamage (healAmt);
        }
        public override int Attack(Human target)
        {
            int dmg= Intelligence *5;
            target.dealdamage(dmg);
            this.dealdamage(dmg * -1);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage, and now has {Health} HP!");
            return target.Health;

        }
 
    }
}