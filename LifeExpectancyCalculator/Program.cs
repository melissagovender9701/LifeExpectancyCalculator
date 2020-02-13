using LifeExpectancyCalculator.BusinessLogicLayer;
using System;

namespace LifeExpectancyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculatorLogic = new CalculatorLogic();
            calculatorLogic.Start();
            var multipleChoice = new MultipleChoiceLogic();
            multipleChoice.DisplayQuestion();
            var yesorno = new YesOrNoLogic();
            yesorno.DisplayQuestion();
            calculatorLogic.CalculateLifeExpectancy();

            Console.ReadLine();
        }
    }
}
