using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Quiz.Common.Models;

namespace Quiz.Client
{
    public partial class QuizLoginForm : MetroForm
    {
        public const string superUser = "666693";
        public QuizLoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Program.ServiceClient = new QuizRestClient("http://" + ServerIPTextBox.Text);
            Program.CurrentRollNumber = RollNumberTextBox.Text;
            if(RollNumberTextBox.Text == superUser)
            {
                LoadAdminUI();
            }
            else
            {
                LoadQuizUI();
            }
        }
        private void LoadAdminUI()
        {
            (new AdminForm()).Show();
            Hide();
        }
        private void LoadQuizUI()
        {
            (new QuestionsForm()).Show();
            Hide();
        }
    }
}
