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
        private IEnumerable<Question> _questions;
        public QuestionsForm(IEnumerable<Question> questions)
        {
            _questions = questions;
            InitializeComponent();
        }
    }
}
