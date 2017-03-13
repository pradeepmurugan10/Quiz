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
              {
                 new Choice { ChoiceText = Choice1TextBox.Text, IsCorrectChoice = Choice1RadioButton.Checked },
                 new Choice { ChoiceText = Choice2TextBox.Text, IsCorrectChoice = Choice2RadioButton.Checked },
                 new Choice { ChoiceText = Choice3TextBox.Text, IsCorrectChoice = Choice3RadioButton.Checked },
                 new Choice { ChoiceText = Choice4TextBox.Text, IsCorrectChoice = Choice4RadioButton.Checked }
              };
            var question = new Question(QuestionTextTextBox.Text, choices);
           // Program.ServiceClient.AddQuestion(question);
        }
    }
}
