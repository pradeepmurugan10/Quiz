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
        public AdminForm()
        {
            InitializeComponent();
           // QuestionsDataGrid.DataSource = client.Execute<List<Question>>(new RestRequest("questions")).Data;
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            (new AddQuestionForm()).ShowDialog();
        }

        private void DurationSubmitButton_Click(object sender, EventArgs e)
        {
            Program.ServiceClient.UpdateTestDuration(TimeSpan.FromMinutes(int.Parse(DurationTextBox.Text)));
        }
    }
}
