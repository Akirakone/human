using System;

namespace Humans
{
    class Samurai:Human
    {

        // Samurai should have a default health of 200	
         public Samurai(string name) :base(name,3,3,3,200)
        {
     
        }
        
        
        public int Meditate()
        {
            int amountToHeal=200-this.Health;
            this.dealdamage(amountToHeal*-1) ;
            return Health;
        }
        public override int Attack(Human target)
        {
            int targetHealth= base.Attack(target);
            if (targetHealth <50 )
            {
            target.dealdamage(target.Health);
            Console.WriteLine($"{target.Name} has been K.O by {Name}!");
            }
            return targetHealth;

        }
    }
}