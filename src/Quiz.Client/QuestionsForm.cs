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
    public partial class QuestionsForm : MetroForm
    {
        private IEnumerable<Question> questions;
        private Timer quizTimer = new Timer();
        private TimeSpan timeLeft;
        private Question currentQuestion;
        public QuestionsForm()
        {
            InitializeComponent();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
            timeLeft = Program.ServiceClient.GetTestDuration();
            questions = Program.ServiceClient.GetQuestions();
            TimerLabel.Text = $"{timeLeft.Minutes} minutes left";
        }
        public QuestionsForm(IEnumerable<Question> questions, TimeSpan testDuration)
        {
            this.questions = questions;
            InitializeComponent();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
            timeLeft = testDuration;
            TimerLabel.Text = $"{timeLeft.Minutes} minutes left";
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));
            TimerLabel.Text = $"{Math.Round(timeLeft.TotalMinutes)} minutes left";
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
        }

    }
}
