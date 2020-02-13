using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public class YesOrNoQuestions : Questions
    {
        public TypesOfCategories YesOrNoQuestionsTypes { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
        public string UserAnswer { get; set; }

        public YesOrNoQuestions()
        {

        }

        public YesOrNoQuestions(int questionid, string question, TypesOfCategories typesOfMultipleChoiceQuestions, QuestionCategory typesOfQuestions) : base(questionid, question)
        {
            YesOrNoQuestionsTypes = typesOfMultipleChoiceQuestions;
            QuestionCategory = typesOfQuestions;
        }
    }
}
