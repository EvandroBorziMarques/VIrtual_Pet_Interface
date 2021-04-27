using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet_Forms.Models
{
    public class Dog : Pet
    {

        [JsonProperty(Order = 3)]
        public double Weight { get; set; }

        [JsonProperty(Order = 4)]
        public double Height { get; set; }

        public Dog(string name, string color) : base(name, color)
        {            
            Weight = 2.0;
            Height = 10.0;
        }

        //Método de alimentar o Pet
        public void comer()
        {
            Weight += 0.5;

            if (Height >= 20)
            {
                Height = Height;
                return;
            }
            Height += 3;
        }

        public void passear()
        {
            Weight -= 0.3;
        }

        public void dormir()
        {
            Weight -= 0.1;
        }
    }
}
