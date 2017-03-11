using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Quiz.Common.Models;

namespace Quiz.Client
{
    public partial class AddQuestionForm : MetroForm
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            var choices = new Choice[]
              { new Choice(Choice1TextBox.Text, Choice1RadioButton.Checked),
                new Choice(Choice2TextBox.Text, Choice2RadioButton.Checked),
                new Choice(Choice3TextBox.Text, Choice3RadioButton.Checked),
                new Choice(Choice4TextBox.Text, Choice4RadioButton.Checked) };
            var question = new Question(QuestionTextTextBox.Text, choices);
            Program.ServiceClient.AddQuestion(question);
        }
    }
}
