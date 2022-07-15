using System;
namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {
        }

        public string SkinColor { get; set; }

        public int LifeExpectancy { get; set; }

        public int NumberOfLegs { get; set; }

        public bool LiveInWater { get; set; }
    }
}

