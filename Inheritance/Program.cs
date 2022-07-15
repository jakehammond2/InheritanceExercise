using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            var Bird1 = new Bird();

            Bird1.Name = "hawk";
            Bird1.Age = 6;
            Bird1.Species = "bird";
            Bird1.Mammal = false;
            Bird1.Migratory = false;
            Bird1.BirdsOfPredator = true;
            Bird1.FeatherColor = "grey";
            Bird1.FlySpeed = 120;

            var Reptile1 = new Reptile();

            Reptile1.Name = "Iguana";
            Reptile1.Age = 3;
            Reptile1.Species = "Lizzard";
            Reptile1.Mammal = false;
            Reptile1.SkinColor = "Green";
            Reptile1.NumberOfLegs = 4;
            Reptile1.LiveInWater = false;
            Reptile1.LifeExpectancy = 15;



            Console.WriteLine($"We now have a {Reptile1.Name}. It is {Reptile1.Age} years old and has a " +
                $"life expectancy of {Reptile1.LifeExpectancy}. It's species type is {Reptile1.Species} and {Reptile1.Mammal} " +
                $"it is not a mammal. It's skin color is {Reptile1.SkinColor}, has {Reptile1.NumberOfLegs} legs, and {Reptile1.LiveInWater} " +
                $"it does not live in water.\n");

            Console.WriteLine($"We now have a {Bird1.Name}. It is {Bird1.Age} years old and has a " +
                $"fly speed up to {Bird1.FlySpeed}mph. It's species type is {Bird1.Species}, and {Bird1.Migratory} " +
                $"it is not a migratory bird. It's feather color is {Bird1.FeatherColor}. It is {Bird1.BirdsOfPredator} that they are predators." +
                $"It is {Bird1.Mammal} that they are mammals.\n");




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
