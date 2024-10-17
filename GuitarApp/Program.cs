using GuitarApp.Helper;
using GuitarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = GuitarApp.Helper.Type;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddGuitar("101", 1000, Builder.FENDER, "Stratocaster", Type.ACOUSTIC, Wood.MAHOGANY, Wood.MAPLE, 6);
            inventory.AddGuitar("102", 1200, Builder.MARTIN, "D-28", Type.ACOUSTIC, Wood.MAHOGANY, Wood.MAPLE, 12);
            inventory.AddGuitar("103", 1500, Builder.MARTIN, "D-28", Type.ACOUSTIC, Wood.MAHOGANY, Wood.MAPLE, 12);

            GuitarSpec searchSpec = new GuitarSpec(Builder.MARTIN, "D-28", Type.ACOUSTIC, Wood.MAHOGANY, Wood.MAPLE, 12);

            List<Guitar> matchingGuitars = inventory.Search(searchSpec);

            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Matching guitars found");
                Console.WriteLine("Total Matched Guitars Founded : " + matchingGuitars.Count);
                Console.WriteLine();
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine($"Serial Number: {guitar.SerialNumber}\n" +
                        $"Price: {guitar.Price}\n" +
                        $"Model: {guitar.Spec.Model}\n");
                }
            }
            else
            {
                Console.WriteLine("No matching guitars found");
            }
        }
    }
}
