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
        //public int answer;
        public string Answer { get; set; }

        public List<string> AnswersList = new List<string> { };

        public MultipleChoiceLogic()
        {
            MultipleChoiceQuestionsList = new List<MultipleChoiceQuestions>()
            {
                new MultipleChoiceQuestions(1,"How often do you exercise? (1). Daily  (2). Weekly  (3). Monthly  (4). Never",TypesOfCategories.Fitness,QuestionCategory.Exercise),
                new MultipleChoiceQuestions(1,"How long do you usually exercise for? (1). 1 hour  (2). 30 mins  (3). 15 mins  (4). 5mins",TypesOfCategories.Fitness,QuestionCategory.Exercise),
                new MultipleChoiceQuestions(3,"What is your blood pressure like? (1). Normal  (2). Medicated  (3). High  (4). Not Sure", TypesOfCategories.Health,QuestionCategory.BloodPressure),
                new MultipleChoiceQuestions(4,"What is your Cholesterol like? (1). Normal (2). Medicated  (3). High  (4). Not Sure", TypesOfCategories.Health,QuestionCategory.Cholesterol)
            };
        }

        public int DisplayQuestion()
        {


            int value;
            foreach (var questions in MultipleChoiceQuestionsList)
            {
                var countFitness = Convert.ToInt32(questions.MultipleChoiceQuestionsTypes.Equals(TypesOfCategories.Fitness));
                if (questions.MultipleChoiceQuestionsTypes.Equals(TypesOfCategories.Fitness))
                {
                    Console.WriteLine("\n*****************Fitness Questions*****************");
                    for (int i = 0; i < countFitness; i++)
                    {
                        Console.WriteLine(questions.Question);
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    while (!int.TryParse(Answer, out value) || !value.Equals(1) && !value.Equals(2) && !value.Equals(3) && !value.Equals(4) && value != null)
                    {
                        Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    countFitness++;

                }
                else if (questions.MultipleChoiceQuestionsTypes.Equals(TypesOfCategories.Health))
                {
                    var countHealth = Convert.ToInt32(questions.MultipleChoiceQuestionsTypes.Equals(TypesOfCategories.Health));
                    Console.WriteLine("\n*****************Health Questions*****************");
                    for (int i = 0; i < countHealth; i++)
                    {
                        Console.WriteLine(questions.Question);
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    while (!int.TryParse(Answer, out value) || !value.Equals(1) && !value.Equals(2) && !value.Equals(3) && !value.Equals(4) && value != null)
                        {
                        Console.WriteLine("Oopsey! Wrong input, please could you enter that again?");
                        Answer = Console.ReadLine();
                        AnswersList.Add(Answer);
                    }
                    countHealth++;
                }
            }
            return 0;
        }

        public int GetAnswer()
        {
            foreach (var answer in AnswersList)
            {
                if (answer.Equals("1") || answer.Equals("2"))
                {
                    return 2;
                }
                else if (answer.Equals("3") || answer.Equals("4"))
                {
                    return 4;
                }
            }
            return 0;
        }
    }
}
