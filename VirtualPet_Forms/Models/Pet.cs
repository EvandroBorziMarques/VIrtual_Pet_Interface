using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet_Forms.Models
{
    public class Pet
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public Pet(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
