﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Common.Models
{
    public class QuizData
    {
        public string RollNumber { get; set; }
        public Dictionary<Question,Choice> QuestionChoiceList { get; set; }
    }
}