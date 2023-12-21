using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.FeatherColor = "Red";
            myBird.CanFly = true;
            myBird.BeakLength = 0.2;
            myBird.Migrate = true;

            var myReptile = new Reptile(); 
            myReptile.Venomous = true;
            myReptile.LegCount = 0;
            myReptile.CanGrowTail = false;
            myReptile.Habitat = "Desert";
            myReptile.ScaleColor = "Brown";

            var myAnimal = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimal)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It has {animal.ScaleFeatherFur}");
                Console.WriteLine(" ");
            }    
        }
    }
}