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
        private int quizTime;
        private Timer quizTimer = new Timer();
        private TimeSpan timeLeft;
        public Question CurrentQuestion { get; set; }
        public QuestionsForm(IList<Question> questions, int quizTime)
        {
            this.questions = questions;
            this.quizTime = quizTime;
            InitializeComponent();
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
            timeLeft = new TimeSpan(0, this.quizTime, 0);
            TimerLabel.Text = $"{this.quizTime} minutes left";
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));
            TimerLabel.Text = $"{(int)timeLeft.TotalMinutes} minutes left";
        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
            quizTimer.Start();
            StartQuizButton.Enabled = false;
        }
    }
}
