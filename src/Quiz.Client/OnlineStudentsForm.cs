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
    public partial class OnlineStudentsForm : MetroForm
    {
        public OnlineStudentsForm():this(Program.ServiceClient.GetOnlineStudents()){}
        public OnlineStudentsForm(IEnumerable<QuizData> students)
        {
            InitializeComponent();
            OnlineStudentsGrid.DataSource = QuizDataTable.OnlineStudents(students);
        }
    }
}
