using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz.Client
{
    static class Program
    {
        public static RestClient ServiceClient { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddQuestionForm());
        }
    }
}
