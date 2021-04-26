using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet_Forms.Models
{
    public class Dog : Pet
    {

        public double Weight { get; set; }

        public double Height { get; set; }

        public Dog(string name, string color) : base(name, color)
        {
            Weight = 2.0;
            Height = 10.0;
        }
    }
}
