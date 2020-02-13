using LifeExpectancyCalculator.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.BusinessLogicLayer
{
    public class CalculatorLogic
    {
        public CalculatorLogic()
        {

        }
        public CalculatorLogic(int age, AverageExpectancyByCountry expectancyByCountry)
        {

        }
        public int age;
        public string country = "";
        public int avglifeexpectancy;
        public void Start()
        {
            Console.WriteLine("******************************* LIFE EXPECTANCY CALCULATOR *******************************");
            Console.WriteLine("\n\nWARNING: ONLY GOD KNOWS WHEN YOU'RE GOING TO DIE...");
            Console.WriteLine("PS: I'M NOT GOD, THIS INFORMATION MAY NOT BE TRUE!\nBUT PLEASE TAKE THIS QUIZ, IT COULD HELP YOU CHANGE SOME OF YOUR BAD HABITS :)");
            PersonalQuestions();
        }

        public void PersonalQuestions()
        {
            Console.WriteLine("\n*****************Personal Questions*****************");
            GetAverageLifeExpectancy();
            GetAge();
        }

        public int GetAverageLifeExpectancy()
        {
            Console.WriteLine($"What country are you from? Please see a list of available countries below to enter:\n");
            foreach (string s in Enum.GetNames(typeof(AverageExpectancyByCountry)))
            {
                Console.WriteLine($"{s}\n");
            }
            country = Console.ReadLine();
            AverageExpectancyByCountry result;
            while (!Enum.TryParse(country, out result))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                country = Console.ReadLine();
            }
            switch (result)
            {
                case AverageExpectancyByCountry.America:
                    avglifeexpectancy = (int)AverageExpectancyByCountry.America;
                    Console.WriteLine($"\nFun Fact: The average life expectancy of an average person in your country is {avglifeexpectancy}");
                    break;
                case AverageExpectancyByCountry.China:
                    avglifeexpectancy = (int)AverageExpectancyByCountry.China;
                    Console.WriteLine($"\nFun Fact: The average life expectancy of an average person in your country is {avglifeexpectancy}");
                    break;
                case AverageExpectancyByCountry.SouthAfrica:
                    avglifeexpectancy = (int)AverageExpectancyByCountry.SouthAfrica;
                    Console.WriteLine($"\nFun Fact: The average life expectancy of an average person in your country is {avglifeexpectancy}");
                    break;
            }
            return avglifeexpectancy;
        }

        public int GetAge()
        {
            Console.WriteLine("\nHow old are you?");
            var ageAsString = Console.ReadLine();
            while (!int.TryParse(ageAsString, out age))
            {
                Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                ageAsString = Console.ReadLine();
            }
            Console.WriteLine($"You are {age} years old");
            return age;
        }

        public int CalculateLifeExpectancy()
        {
            var multipleChoiceLogic = new MultipleChoiceLogic();
            int expectancy = avglifeexpectancy - age - multipleChoiceLogic.GetAnswer();
            Console.WriteLine($"You are expected to live till the age of: {expectancy}");
            return 0;
        }

    }
}
