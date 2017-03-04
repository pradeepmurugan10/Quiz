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
        public QuizLoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           // var client = new RestClient(ServerIPTextBox.Text+ "/api");
            //new QuestionsForm(client.Execute<List<Question>>(new RestRequest("questions")).Data, client.Execute<int>(new RestRequest("quiztime")).Data);
            this.Hide();
            QuestionsForm qform = new QuestionsForm(null,45);
            qform.ShowDialog();
            this.Close();
        }
    }
}
