using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyCalculator.DataAccessLayer
{
    public enum CountryLifeExpectancy
    {
        SouthAfrica = 62,
        America = 88,
        China = 66
    }
    public class Questions
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }

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
