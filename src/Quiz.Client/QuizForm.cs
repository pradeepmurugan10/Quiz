using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quiz.Common.Models;

namespace Quiz.Client
{
    public partial class QuizForm : MetroForm
    {
        private Common.Models.Quiz quiz;
        private Timer quizTimer = new Timer();
        private TimeSpan timeLeft;
        private Question currentQuestion;
        private int currentQuestionNumber = 1;
        public Dictionary<Guid, Choice> choices;
        public QuizForm(Common.Models.Quiz quiz)
        {
            this.quiz = quiz;
            timeLeft = this.quiz.QuizDuration;
            //TimerLabel.Text = $"{Math.Round(timeLeft.TotalMinutes)} minutes left";
        }
        public QuizForm() : this(Program.ServiceClient.GetQuiz())
        {
            InitializeComponent();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
        }
        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));
            if (timeLeft.TotalMinutes > 1)
            {
                TimerLabel.Text = $"{Math.Round(timeLeft.TotalMinutes)} minutes left";
            }
            else
            {
                TimerLabel.ForeColor = Color.Red;
                TimerLabel.Text = $"AUTO SUBMIT IN {Math.Round(timeLeft.TotalSeconds)} seconds";
            }
        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
            quizTimer.Start();
            StartQuizButton.Enabled = false;
            StartQuizButton.Visible = false;
            QuestionLabel.Visible = true;
            Choice1RadioButton.Visible =  true;
            Choice2RadioButton.Visible = true;
            Choice3RadioButton.Visible = true;
            Choice4RadioButton.Visible = true;
            SetCurrentQuestion(quiz.QuestionsList[1],currentQuestionNumber); // INDEX STARTS FROM 1 FOR QUESTIONS LIST
        }
        public void SetCurrentQuestion(Question question, int questionIndex)
        {
           // int questionIndex  = quiz.QuestionsList.SingleOrDefault(x => x.Value == question).Key;
            if(questionIndex == 1)
            {
                PreviousQuestionButton.Enabled = false;
            }
            else if (questionIndex == quiz.QuestionsList.Last().Key)
            {
                NextQuestionButton.Enabled = false;
            }
            else
            {
                NextQuestionButton.Enabled = false;
                PreviousQuestionButton.Enabled = false;
            }
            currentQuestion = question;
            QuestionLabel.Text = currentQuestion.QuestionText;
            Choice1RadioButton.Text = currentQuestion.Choices.ElementAt(0).ChoiceText;
            Choice2RadioButton.Text = currentQuestion.Choices.ElementAt(1).ChoiceText;
            Choice3RadioButton.Text = currentQuestion.Choices.ElementAt(2).ChoiceText;
            Choice4RadioButton.Text = currentQuestion.Choices.ElementAt(3).ChoiceText;
        }
        private void SubmitQuizButton_Click(object sender, EventArgs e)
        {
            Program.ServiceClient.SubmitQuizData(new QuizData
            { RollNumber = Program.CurrentRollNumber,
                QuestionChoiceList = choices
            });

        }

        private void PreviousQuestionButton_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            try
            {
                switch (checkedButton.Name)
                {
                    case nameof(Choice1RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(0)); break; }
                    case nameof(Choice2RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(1)); break; }
                    case nameof(Choice3RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(2)); break; }
                    case nameof(Choice4RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(3)); break; }
                    default: { MessageBox.Show("Invalid choice"); break; }
                }
                --currentQuestionNumber;
                SetCurrentQuestion(quiz.QuestionsList[currentQuestionNumber], currentQuestionNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid choice");
            }
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            try
            {
                switch (checkedButton.Name)
                {
                    case nameof(Choice1RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(0)); break; }
                    case nameof(Choice2RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(1)); break; }
                    case nameof(Choice3RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(2)); break; }
                    case nameof(Choice4RadioButton):
                        { choices.Add(currentQuestion.QuestionId, currentQuestion.Choices.ElementAt(3)); break; }
                    default: { MessageBox.Show("Invalid choice"); break; }
                }
                ++currentQuestionNumber;
                SetCurrentQuestion(quiz.QuestionsList[currentQuestionNumber], currentQuestionNumber);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid choice");
            }
        }
    }
}
