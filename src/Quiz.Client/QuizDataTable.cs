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
        public static DataTable Create(Dictionary<int, Question> questions)
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

        }
    }
}
