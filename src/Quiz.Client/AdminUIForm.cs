using MetroFramework.Forms;
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
    public partial class AdminUIForm : MetroForm
    {
        public AdminUIForm()
        {
            InitializeComponent();
        }

        private void EditQuizButton_Click(object sender, EventArgs e)
        {
            (new QuizEditorForm()).Show();
        }

        private void ViewResultsButton_Click(object sender, EventArgs e)
        {
            (new ResultsViewForm()).Show();
        }

        private void ViewOnlineStudentsbutton_Click(object sender, EventArgs e)
        {
            (new OnlineStudentsForm()).Show();
        }
    }
}
