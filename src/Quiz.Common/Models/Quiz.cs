using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Common.Models
{
    public class Quiz
    {
        public Quiz()
        {

        }
        public static Guid DefaultQuizId = new Guid(); // 00000000-0000-0000-0000-000000000000
        public Guid QuizId { get; set; }
        public string QuizName { get; set; }
        public SortedDictionary<int, Question> QuestionsList { get; set; }
        public TimeSpan QuizDuration { get; set; }
    }
}
