using LifeExpectancyCalculator.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeExpectancyCalculator.BusinessLogicLayer
{
    public class MultipleChoiceLogic
    {
        public List<MultipleChoiceQuestions> MultipleChoiceQuestionsList { get; set; }
        public MultipleChoiceLogic()
        {
            MultipleChoiceQuestionsList = new List<MultipleChoiceQuestions>()
            {
                new MultipleChoiceQuestions(1,"How often do you exercise? 1. Daily 2. Weekly 3. Monthly 4. Never",TypesOfCategories.Fitness,TypesOfQuestions.Exercise),
                new MultipleChoiceQuestions(3,"How is your blood pressure? 1. Normal 2. Medicated 3. High 4. Not Sure", TypesOfCategories.Health,TypesOfQuestions.BloodPressure),
                new MultipleChoiceQuestions(4,"How is your cholesterol/HDL? 1. Normal 2. Medicated 3. Not Sure", TypesOfCategories.Health,TypesOfQuestions.Cholesterol)
            };
        }

        //public void sortList()
        //{
        //    var sortedList = MultipleChoiceQuestionsList
        //        .OrderBy(x => x.QuestionTypes,
        //                new EnumComparer<QuestionTypes> {
        //                        QuestionTypes.kMidRange,
        //                        QuestionTypes.kHighRange})
        //                        .ToList();
        //}
        public int GetAge()
        {
            int age = 0;
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
            return age;
        }

        public int GetCountry()
        {
            int country = 0;
            Console.WriteLine("What country are you from? 1.America, 2.South Africa 3.China");
            country = int.Parse(Console.ReadLine());
            if (country.Equals(1))
            {
                return (int)CountryLifeExpectancy.America;
            }
            else if (country.Equals(2))
            {
                return (int)CountryLifeExpectancy.SouthAfrica;
            }
            else if (country.Equals(3))
            {
                return (int)CountryLifeExpectancy.China;
            }
            return 0;
        }


        public int DisplayQuestion()
        {
            foreach (var questions in MultipleChoiceQuestionsList) 
            {
                if (questions.MultipleChoiceQuestionsTypes.Equals(TypesOfCategories.Fitness))
                {
                    Console.WriteLine(questions.Question);
                    int answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            return 0;
        }
    }
}
