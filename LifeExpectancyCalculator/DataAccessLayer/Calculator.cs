using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public enum AverageExpectancyByCountry
    {
        SouthAfrica = 62,
        America = 88,
        China = 66
    }

    public class Calculator
    {
        public int Age { get; set; }
        public AverageExpectancyByCountry Expectancy { get; set; }

        public Calculator()
        {

        }

        public Calculator(int age, AverageExpectancyByCountry expectancyByCountry)
        {
            Age = age;
            Expectancy = expectancyByCountry;
        }
    }
}
