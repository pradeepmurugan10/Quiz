using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Common.Models
{
    public class QuizData
    {
        public QuizData()
        { }
        public string RollNumber { get; set; }
        public string StudentName { get; set; }
        public string RegisterNumber { get; set; }
        public Dictionary<Guid,Choice> QuestionChoiceList { get; set; }
    }
}
