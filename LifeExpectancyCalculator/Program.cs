using LifeExpectancyCalculator.BusinessLogicLayer;
using System;

namespace LifeExpectancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var multipleChoice = new MultipleChoiceLogic();
            multipleChoice.GetAge();
            multipleChoice.DisplayQuestion();
            Console.ReadLine();
        }
    }
}
