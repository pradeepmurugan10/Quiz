using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz.Client
{
    static class Program
    {
        public static string CurrentRollNumber { get; set; }
        public static string CurrentRegistrationNumber { get; set; }
        public static string CurrentStudentname { get; set; }
        public static QuizRestClient ServiceClient { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuizLoginForm());
        }
    }
}
