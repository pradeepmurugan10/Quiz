using Quiz.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quiz.Client
{
    class QuizDataTable
    {
        public static DataTable CreateResults(IEnumerable<QuizData> quizData)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll Number", typeof(string));
            dt.Columns.Add("Register Number", typeof(string));
            dt.Columns.Add("Name",typeof(string));    
            dt.Columns.Add("Marks", typeof(int));
            foreach(var result in quizData)
            {
                dt.Rows.Add(result.RollNumber, result.RegisterNumber,result.StudentName, result.QuestionChoiceList.Sum(x => (Convert.ToInt32(x.Value.IsCorrectChoice))));
            }
            return dt;
        }
        public static DataTable OnlineStudents(IEnumerable<QuizData> students)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll Number", typeof(string));
            dt.Columns.Add("Register Number", typeof(string));
            dt.Columns.Add("Name", typeof(string));       
            foreach(var student in students)
            {
                dt.Rows.Add(student.RollNumber, student.RegisterNumber, student.StudentName);
            }
            return dt;
        }
        
        public static DataTable Create(SortedDictionary<int, Question> questions)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Question Number", typeof(int));
            dt.Columns.Add("Question Text", typeof(string));
            dt.Columns.Add("Choice 1 Text", typeof(string));
            dt.Columns.Add("Choice 1 Correct", typeof(bool));
            dt.Columns.Add("Choice 2 Text", typeof(string));
            dt.Columns.Add("Choice 2 Correct", typeof(bool));
            dt.Columns.Add("Choice 3 Text", typeof(string));
            dt.Columns.Add("Choice 3 Correct", typeof(bool));
            dt.Columns.Add("Choice 4 Text", typeof(string));
            dt.Columns.Add("Choice 4 Correct", typeof(bool));
            dt.Columns.Add("Question Id", typeof(string));
            
            foreach(DataColumn column in dt.Columns)
            {
                column.AllowDBNull = true;
            }
            
            foreach(var question in questions)
            {
                dt.Rows.Add(
                    question.Key,
                    question.Value.QuestionNumber,
                    question.Value.QuestionText,
                    question.Value.Choices.ElementAt(0).ChoiceText,
                    question.Value.Choices.ElementAt(0).IsCorrectChoice,
                    question.Value.Choices.ElementAt(1).ChoiceText,
                    question.Value.Choices.ElementAt(1).IsCorrectChoice,
                    question.Value.Choices.ElementAt(2).ChoiceText,
                    question.Value.Choices.ElementAt(2).IsCorrectChoice,
                    question.Value.Choices.ElementAt(3).ChoiceText,
                    question.Value.Choices.ElementAt(3).IsCorrectChoice,
                    question.Value.QuestionId.ToString()
                    );
            }
            return dt;
        }

    }
}
