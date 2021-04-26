using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet_Forms.Models
{
    public class Cat : Pet
    {
        public double Weight { get; set; }

        public double Height { get; set; }

        public Cat(string name, string color) : base(name, color)
        {
            Weight = 1.5;
            Height = 9.0;
        }
    }
}
