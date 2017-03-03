using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Common.Models
{
    public class Choice
    {
        public string ChoiceText { get; set; }
        public bool IsCorrectChoice { get; set; } = true;
        public Choice() { }
        public Choice(string choiceText, bool isCorrectChoice = true)
        {
            ChoiceText = choiceText;
            IsCorrectChoice = isCorrectChoice;
        }
    }
}
