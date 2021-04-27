using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet_Forms.Models
{
    public class Pet
    {
        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Color { get; set; }

        public Pet(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
