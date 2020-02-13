using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public enum TypesOfCategories
    {
        Fitness = 0,
        Health = 1
    }
    public enum TypesOfQuestions
    {
        Exercise = 5,
        BloodPressure = 7,
        Cholesterol= 3
    }

    public class MultipleChoiceQuestions : Questions
    {
        public TypesOfCategories MultipleChoiceQuestionsTypes { get; set; }
        public TypesOfQuestions QuestionTypes { get; set; }

        public MultipleChoiceQuestions()
        {

        }

        public MultipleChoiceQuestions(int questionid, string question, TypesOfCategories typesOfMultipleChoiceQuestions, TypesOfQuestions typesOfQuestions): base(questionid, question)
        {
            MultipleChoiceQuestionsTypes = typesOfMultipleChoiceQuestions;
            QuestionTypes = typesOfQuestions;
        }
    }
}
