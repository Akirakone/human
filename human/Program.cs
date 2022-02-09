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
            Console.WriteLine(akira.Health);
            akira.Attack(ousmane);
            Console.WriteLine($"{ousmane.Name} was attacked by {akira.Name}! {ousmane.Name} health is now {ousmane.Health}");
        }
        

        }

    }
}
