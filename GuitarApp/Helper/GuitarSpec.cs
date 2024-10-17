using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Helper
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings { get; set; } 

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }
    }
}
