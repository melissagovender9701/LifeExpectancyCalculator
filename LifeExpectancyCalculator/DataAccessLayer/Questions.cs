using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public enum TypesOfQuestions
    {
        MultipleChoice,
        YesOrNo
    }
    public enum TypesOfCategories
    {
        Fitness = 0,
        Health = 1
    }

    public enum QuestionCategory
    {
        Exercise = 5,
        BloodPressure = 7,
        Cholesterol = 3,
        Smoke = 10,
        Drink = 5,
        Seatbelt = 1
    }
    public class Questions
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public TypesOfQuestions QuestionType { get; set; }

        public Questions()
        {

        }

        public Questions(int questionid, string question)
        {
            QuestionID = questionid;
            Question = question;
        }
    }
}
