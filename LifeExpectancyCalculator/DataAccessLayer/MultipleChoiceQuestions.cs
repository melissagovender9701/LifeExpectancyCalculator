using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public class MultipleChoiceQuestions : Questions
    {
        public TypesOfCategories MultipleChoiceQuestionsTypes { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
        public string UserAnswer { get; set; }

        public MultipleChoiceQuestions()
        {

        }

        public MultipleChoiceQuestions(int questionid, string question, TypesOfCategories typesOfMultipleChoiceQuestions, QuestionCategory typesOfQuestions) : base(questionid, question)
        {
            MultipleChoiceQuestionsTypes = typesOfMultipleChoiceQuestions;
            QuestionCategory = typesOfQuestions;
        }
    }
}
