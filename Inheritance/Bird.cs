using System;
namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
        }

        public bool Migratory { get; set; }

        public bool BirdsOfPredator { get; set; }

        public string FeatherColor { get; set; }

        public int FlySpeed { get; set; }


    }
}

