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
    public partial class QuizEditorForm : MetroForm
    {
        Common.Models.Quiz quiz;
        public QuizEditorForm()
        {
            InitializeComponent();
            quiz = Program.ServiceClient.GetQuiz() ?? new Common.Models.Quiz
            {
                QuestionsList = new SortedDictionary<int, Question>(),
                QuizDuration = TimeSpan.FromMinutes(45),
                QuizId = Guid.Parse("de5c69af-7c52-46be-b241-93ab9806f886"),
                QuizName = "Test"
            };

            QuestionsGrid.DataSource = QuizDataTable.Create(quiz.QuestionsList);
            QuizNameTextBox.Text = quiz.QuizName;
            QuizDurationTextBox.Text = (Math.Round(quiz.QuizDuration.TotalMinutes)).ToString();
            foreach (DataGridViewColumn column in QuestionsGrid.Columns)
            {
                if (column is DataGridViewCheckBoxColumn)
                {

                    ((DataGridViewCheckBoxColumn)column).IndeterminateValue = false;
                    ((DataGridViewCheckBoxColumn)column).FalseValue = false;
                    ((DataGridViewCheckBoxColumn)column).TrueValue = true;
                    ((DataGridViewCheckBoxColumn)column).ThreeState = false;
                }
            }
            QuestionsGrid.Columns["Question Id"].ReadOnly = true;


        }

        private void ServerUpdateButton_Click(object sender, EventArgs e)
        {
            quiz.QuizName = QuizNameTextBox.Text;
            quiz.QuizDuration = (TimeSpan.FromMinutes(int.Parse(QuizDurationTextBox.Text)));
            foreach (DataGridViewRow row in QuestionsGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["Question Id"].Value == null)
                    {
                        row.Cells["Question Id"].Value = Guid.NewGuid().ToString();
                    }
                    Guid guid;
                    if (!Guid.TryParse(row.Cells["Question Id"].Value.ToString(), out guid))
                    {
                        guid = Guid.NewGuid();
                        row.Cells["Question Id"].Value = guid.ToString();
                    }
                    var choices = new Choice[]
                    {
                 new Choice { ChoiceText      = row.Cells["Choice 1 Text"].Value.ToString(),
                              IsCorrectChoice = (((DataGridViewCheckBoxCell)row.Cells["Choice 1 Correct"]).Value != null && (bool)((DataGridViewCheckBoxCell)row.Cells["Choice 1 Correct"]).Value)
                            },
                 new Choice { ChoiceText      = row.Cells["Choice 2 Text"].Value.ToString(),
                              IsCorrectChoice = (((DataGridViewCheckBoxCell)row.Cells["Choice 2 Correct"]).Value != null && (bool)((DataGridViewCheckBoxCell)row.Cells["Choice 2 Correct"]).Value)
                            },
                 new Choice {
                              ChoiceText      = row.Cells["Choice 3 Text"].Value.ToString(),
                              IsCorrectChoice = (((DataGridViewCheckBoxCell)row.Cells["Choice 3 Correct"]).Value != null && (bool)((DataGridViewCheckBoxCell)row.Cells["Choice 3 Correct"]).Value)
                            },
                 new Choice {
                              ChoiceText      =  row.Cells["Choice 4 Text"].Value.ToString(),
                              IsCorrectChoice =  (((DataGridViewCheckBoxCell)row.Cells["Choice 4 Correct"]).Value != null && (bool)((DataGridViewCheckBoxCell)row.Cells["Choice 4 Correct"]).Value)
                 }
                    };
                    quiz.QuestionsList[(int)row.Cells["Question Number"].Value] = new Question(
                    guid, (string)row.Cells["Question Text"].Value, choices);
                }
            }
            Program.ServiceClient.SubmitQuiz(quiz);
        }
    }
}
