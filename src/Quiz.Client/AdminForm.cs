using MetroFramework.Forms;
using Quiz.Common.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz.Client
{
    public partial class AdminForm : MetroForm
    {
        Common.Models.Quiz quiz;
        public AdminForm()
        {
            InitializeComponent();
            quiz = new Common.Models.Quiz {
                QuestionsList = new SortedDictionary<int, Question> (),
                QuizDuration = TimeSpan.FromMinutes(45),
                QuizId = new Guid(),
                QuizName = "Testing" };
            QuestionsGrid.DataSource = QuizDataTable.Create(quiz.QuestionsList);
            QuestionsGrid.Columns["Question Id"].Visible = false;

        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            (new AddQuestionForm()).ShowDialog();
        }

        private void DurationUpdateButton_Click(object sender, EventArgs e)
        {
           quiz.QuizDuration = (TimeSpan.FromMinutes(int.Parse(QuizDurationTextBox.Text)));
        }

        private void ServerUpdateButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in QuestionsGrid.Rows)
            {
                var guid = string.IsNullOrWhiteSpace(row.Cells["Question Id"].Value.ToString()) ? Guid.Parse(row.Cells["Question Id"].Value.ToString()) : Guid.NewGuid();
                var choices = new Choice[]
                {
                 new Choice { ChoiceText      = (string) row.Cells["Choice 1 Text"].Value,
                              IsCorrectChoice = (bool) row.Cells["Choice 1 Correct"].Value
                            },
                 new Choice { ChoiceText = (string) row.Cells["Choice 2 Text"].Value,
                              IsCorrectChoice =  (bool) row.Cells["Choice 2 Correct"].Value
                            },
                 new Choice {
                              ChoiceText = (string) row.Cells["Choice 3 Text"].Value,
                              IsCorrectChoice = (bool) row.Cells["Choice 3 Correct"].Value
                            },
                 new Choice {
                     ChoiceText = (string) row.Cells["Choice 4 Text"].Value,
                     IsCorrectChoice =  (bool) row.Cells["Choice 4 Correct"].Value
                 }
                };
                quiz.QuestionsList[(int)row.Cells["Question Number"].Value] = new Question(
                    guid, (string)row.Cells["Question Text"].Value, choices);

            }
        }
    }
}
