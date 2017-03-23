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
        private Dictionary<Guid, Choice> choices = new Dictionary<Guid, Choice> ();
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
            else if(timeLeft.TotalSeconds == 0)
            {
                MessageBox.Show("Time Over. SUBMITTING !");
                quizTimer.Stop();
                Program.ServiceClient.SubmitQuizData(new QuizData
                {
                    RollNumber = Program.CurrentRollNumber,
                    QuestionChoiceList = choices
                });
                SubmitQuizButton.Enabled = false;
                MessageBox.Show($"{choices.Sum(x => (Convert.ToInt32(x.Value.IsCorrectChoice)))} marks obtained");
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
            SubmitQuizButton.Enabled = false;
            NextQuestionButton.Visible = true;
            PreviousQuestionButton.Visible = true;
            QuestionLabel.Visible = true;
            Choice1RadioButton.Visible = true;
            Choice2RadioButton.Visible = true;
            Choice3RadioButton.Visible = true;
            Choice4RadioButton.Visible = true;
            SetCurrentQuestion(quiz.QuestionsList.First());
        }
        public void SetCurrentQuestion(KeyValuePair<int,Question> kvp)
        {
            int questionIndex = kvp.Key;
            Question question = kvp.Value;
            if (quiz.QuestionsList.Count == 1)
            {
                NextQuestionButton.Enabled = false;
                PreviousQuestionButton.Enabled = false;
                SubmitQuizButton.Visible = true;
                SubmitQuizButton.Enabled = true;
            }
            else
            {
                if (questionIndex == 1)
                {
                    PreviousQuestionButton.Enabled = false;
                    NextQuestionButton.Enabled = true;
                    SubmitQuizButton.Visible = false;
                    SubmitQuizButton.Enabled = false;

                }
                else if (questionIndex == quiz.QuestionsList.Last().Key)
                {
                    NextQuestionButton.Enabled = false;
                    PreviousQuestionButton.Enabled = true;
                    SubmitQuizButton.Visible = true;
                    SubmitQuizButton.Enabled = true;
                }
                else
                {
                    NextQuestionButton.Enabled = true;
                    PreviousQuestionButton.Enabled = true;
                }
            }
            currentQuestion = question;
            currentQuestionNumber = questionIndex;
            QuestionLabel.Text = currentQuestion.QuestionText;
            Choice1RadioButton.Text = currentQuestion.Choices.ElementAt(0).ChoiceText;
            Choice2RadioButton.Text = currentQuestion.Choices.ElementAt(1).ChoiceText;
            Choice3RadioButton.Text = currentQuestion.Choices.ElementAt(2).ChoiceText;
            Choice4RadioButton.Text = currentQuestion.Choices.ElementAt(3).ChoiceText;
        }
        private void SubmitQuizButton_Click(object sender, EventArgs e)
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
                quizTimer.Stop();
                Program.ServiceClient.SubmitQuizData(new QuizData
                {
                    RollNumber = Program.CurrentRollNumber,
                    QuestionChoiceList = choices
                });
                SubmitQuizButton.Enabled = false;
                MessageBox.Show($"{choices.Sum(x => (Convert.ToInt32(x.Value.IsCorrectChoice)))} marks obtained");
            }
            catch
            {
                SubmitQuizButton.Enabled = true;
                MessageBox.Show("Invalid choice");
            }
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
                SetCurrentQuestion(quiz.QuestionsList.SingleOrDefault(x => x.Key == currentQuestionNumber - 1));
            }
            catch(Exception)
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
                SetCurrentQuestion(quiz.QuestionsList.SingleOrDefault(x => x.Key == currentQuestionNumber + 1));
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid choice");
            }
        }
    }
}
