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
using LiteDB;

namespace Quiz.Client
{
    public partial class AddQuestionsForm : MetroForm
    {
        private IEnumerable<Question> question;
        private LiteDatabase _db;
       
        public AddQuestionsForm()
        {
            InitializeComponent();

        }
        private void AddQuestion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
