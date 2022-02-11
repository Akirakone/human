using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
             {
            Human akira = new Human("Akira");
            Human ousmane = new Human ("Ousmane");
            Ninja troy = new Ninja ("Troy");
            Samurai crystal = new Samurai ("Crystal");
            Wizard Amy = new Wizard ("Amy");

            Console.WriteLine(akira.Health);
            akira.Attack(ousmane);
            Console.WriteLine($" {ousmane.Name} health is now {ousmane.Health}");
            Console.WriteLine(crystal.Health);
            Console.WriteLine(crystal.Meditate());
            crystal.Attack(troy);
            Amy.Attack(troy);
        }
        

        }

    }
}
