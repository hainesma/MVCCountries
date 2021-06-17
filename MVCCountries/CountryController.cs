using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            // Confused about Display vs DisplayCountry
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list.");
            clv.Display();
        }

    }
}
