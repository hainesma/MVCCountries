using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    // This is the model
    class Country
    {
        public enum Continent
        {
            NorthAmerica,
            SouthAmerica,
            Europe,
            Africa,
            Asia,
            Australia,
            Antarctica
        }

        public string Name { get; set; }
        public Continent Region { get; set; }
        public List<string> Colors { get; set; }
    }
}
