using LifeExpectancyCalculator.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeExpectancyCalculator.BusinessLogicLayer
{
    public class YesOrNoLogic
    {
        public List<YesOrNoQuestions> YesOrNoQuestionsList { get; set; }
        //public int answer;
        public string Answer { get; set; }

        public List<string> AnswersList = new List<string> { };

        public YesOrNoLogic()
        {
            YesOrNoQuestionsList = new List<YesOrNoQuestions>()
            {
                new YesOrNoQuestions(1,"Do you Smoke? Y/N",TypesOfCategories.Health,QuestionCategory.Smoke),
                new YesOrNoQuestions(1,"Do you Drink? Y/N",TypesOfCategories.Health,QuestionCategory.Drink),
                new YesOrNoQuestions(3,"Do you wear a seatbelt? Y/N", TypesOfCategories.Health,QuestionCategory.Seatbelt),
            };
        }

        public int DisplayQuestion()
        {


            int value;
            foreach (var questions in YesOrNoQuestionsList)
            {
                var countFitness = Convert.ToInt32(questions.YesOrNoQuestionsTypes.Equals(TypesOfCategories.Fitness));
                if (questions.YesOrNoQuestionsTypes.Equals(TypesOfCategories.Fitness))
                {
                    Console.WriteLine("\n*****************Fitness Questions*****************");
                    for (int i = 0; i < countFitness; i++)
                    {
                        Console.WriteLine(questions.Question);
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    while (!int.TryParse(Answer, out value))
                    {
                        Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    countFitness++;

                }
                else if (questions.YesOrNoQuestionsTypes.Equals(TypesOfCategories.Health))
                {
                    var countHealth = Convert.ToInt32(questions.YesOrNoQuestionsTypes.Equals(TypesOfCategories.Health));
                    Console.WriteLine("\n*****************Health Questions*****************");
                    for (int i = 0; i < countHealth; i++)
                    {
                        Console.WriteLine(questions.Question);
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    while (!int.TryParse(Answer, out value))
                    {
                        Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    countHealth++;
                }
            }

            // AnswersList.ForEach(Console.WriteLine);
            return 0;
        }

        public int GetAnswer()
        {
            foreach (var answer in AnswersList)
            {
                if (answer.Equals("Y"))
                { 
                    return 2;
                }
                else if (answer.Equals("N"))
                {
                    return 4;
                }
            }
            return 0;
        }
    }
}
