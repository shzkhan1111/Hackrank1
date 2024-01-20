using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public enum QuestionTypeEnum
    {
        Other,
        YesNo = 5,
        Number,
        Text
    }
    public class SurveyQuestion
    {
        public string QuestionText { get; }
        public QuestionTypeEnum TypeOfQuestion { get; }

        public SurveyQuestion(QuestionTypeEnum questionType, string text) =>
            (TypeOfQuestion, QuestionText) = (questionType, text);
    }
    public class SurveyRun {
        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();

        public void AddQuestions(QuestionTypeEnum questionType, string text) 
            => AddQuestions(new SurveyQuestion(questionType, text));

        public void AddQuestions(SurveyQuestion s) => surveyQuestions.Add(s);
    }

    public class SurveyResponse
    {
        //private Dictionary<int, string>? surveyResponses;
        //public bool AnswerServey(IEnumerable<SurveyQuestion> q)
        //{
        //    if (ConsentToSurvey())
        //    {
        //        surveyResponses = new Dictionary<int, string>();
        //        int index = 0;
        //        foreach (var question in q)
        //        {
        //            var ans = GenerateAnswer(q);
        //            if (ans != null)
        //            {
        //                surveyResponses.Add(index, ans);
        //            }
        //            index++;
        //        }
        //    }
        //    return surveyResponses != null;
        //}
        //private string? GenerateAnswer(SurveyQuestion question)
        //{
        //    switch (question.TypeOfQuestion)
        //    {
        //        case QuestionTypeEnum.YesNo:
        //            int n = randomGenerator.Next(-1, 2);
        //            return (n == -1) ? default : (n == 0) ? "No" : "Yes";
        //        case QuestionTypeEnum.Number:
        //            n = randomGenerator.Next(-30, 101);
        //            return (n < 0) ? default : n.ToString();
        //        case QuestionTypeEnum.Text:
        //        default:
        //            switch (randomGenerator.Next(0, 5))
        //            {
        //                case 0:
        //                    return default;
        //                case 1:
        //                    return "Red";
        //                case 2:
        //                    return "Green";
        //                case 3:
        //                    return "Blue";
        //            }
        //            return "Red. No, Green. Wait.. Blue... AAARGGGGGHHH!";
        //    }
        //}

        //private bool ConsentToSurvey() => randomGenerator.Next(0, 2) == 1;
        //public int Id { get; }
        //public SurveyResponse(int id) => Id = id;
        //private static readonly Random randomGenerator = new Random();
        //public static SurveyResponse GetRandom() => new SurveyResponse(randomGenerator.Next()); 
    }


}
