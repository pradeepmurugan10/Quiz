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
            quiz = Program.ServiceClient.GetQuiz() ?? new Common.Models.Quiz {
                QuestionsList = new SortedDictionary<int, Question> (),
                QuizDuration = TimeSpan.FromMinutes(45),
                QuizId = Guid.Parse("de5c69af-7c52-46be-b241-93ab9806f886"),
                QuizName = "Test" };
            QuestionsGrid.DataSource = QuizDataTable.Create(quiz.QuestionsList);
            QuestionsGrid.Columns["Question Id"].Visible = false;

        }

        private void ServerUpdateButton_Click(object sender, EventArgs e)
        {
            quiz.QuizName = QuizNameTextBox.Text;
            quiz.QuizDuration = (TimeSpan.FromMinutes(int.Parse(QuizDurationTextBox.Text)));
            foreach (DataGridViewRow row in QuestionsGrid.Rows)
            {
                Guid guid;
                try
                {
                    Guid.TryParse(row.Cells["Question Id"].Value.ToString(), out guid);


                    var choices = new Choice[]
                    {
                 new Choice { ChoiceText      = row.Cells["Choice 1 Text"].Value.ToString(),
                              IsCorrectChoice = ((DataGridViewCheckBoxCell)row.Cells["Choice 1 Correct"]).Selected
                            },
                 new Choice { ChoiceText      = row.Cells["Choice 2 Text"].Value.ToString(),
                              IsCorrectChoice = ((DataGridViewCheckBoxCell)row.Cells["Choice 2 Correct"]).Selected
                            },
                 new Choice {
                              ChoiceText      = row.Cells["Choice 3 Text"].Value.ToString(),
                              IsCorrectChoice = ((DataGridViewCheckBoxCell)row.Cells["Choice 3 Correct"]).Selected
                            },
                 new Choice {
                              ChoiceText      =  row.Cells["Choice 4 Text"].Value.ToString(),
                              IsCorrectChoice =   ((DataGridViewCheckBoxCell)row.Cells["Choice 4 Correct"]).Selected
                 }
                    };
                    quiz.QuestionsList[(int)row.Cells["Question Number"].Value] = new Question(
                        guid, (string)row.Cells["Question Text"].Value, choices);
                }
                catch (Exception)
                {
                    MessageBox.Show((string)row.Cells["Question Text"].Value);
                }
            }
            Program.ServiceClient.SubmitQuiz(quiz);
        }
    }
}
