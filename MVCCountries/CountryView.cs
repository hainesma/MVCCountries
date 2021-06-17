using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryView
    {
        
        public Country DisplayCountry { get; set; }
        public CountryView(Country Country)
        {
            Country = DisplayCountry;
        }
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Region);
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
