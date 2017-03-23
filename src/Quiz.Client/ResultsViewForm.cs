using MetroFramework.Forms;
using Quiz.Common.Models;
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
    public partial class ResultsViewForm : MetroForm
    {
        public ResultsViewForm() : this (Program.ServiceClient.GetQuizData()) { }
        public ResultsViewForm(IEnumerable<QuizData> results)
        {
            InitializeComponent();
            ResultsGrid.DataSource = QuizDataTable.CreateResults(results);
        }
    }
}
