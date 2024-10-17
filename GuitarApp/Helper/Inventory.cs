using GuitarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Helper
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood, numStrings);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchedGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                GuitarSpec guitarSpec = guitar.Spec;

                if (searchSpec.Builder != guitarSpec.Builder)
                    continue;
                if ((searchSpec.Model != null) && (!searchSpec.Model.Equals(guitarSpec.Model)))
                    continue;
                if (searchSpec.Type != guitarSpec.Type)
                    continue;
                if (searchSpec.BackWood != guitarSpec.BackWood)
                    continue;
                if (searchSpec.TopWood != guitarSpec.TopWood)
                    continue;
                if (searchSpec.NumStrings != guitarSpec.NumStrings)
                    continue;

                matchedGuitars.Add(guitar);
            }
            return matchedGuitars;
        }
    }
}
