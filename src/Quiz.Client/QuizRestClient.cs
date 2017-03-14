using Quiz.Common.Models;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Quiz.Client
{
    class QuizRestClient
    {
        RestClient innerClient;
        public QuizRestClient(string IPAddress)
        {
            innerClient = new RestClient(IPAddress + "/api");
        }
        public void SubmitQuizData(QuizData quizData, int rollNumber)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest($"quiz/submit/{rollNumber}", Method.POST);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error submitting quiz data to server", response.ErrorException);
            }
        }
        public void SubmitQuiz(Common.Models.Quiz quiz)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest($"quiz", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(quiz);
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error retreiving quiz data from server", response.ErrorException);
            }
        }
        public Common.Models.Quiz GetQuiz()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest($"quiz/{new Guid().ToString()}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<Common.Models.Quiz>(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error retreiving quiz data from server", response.ErrorException);
            }
            else
            {
                return response.Data;
            }
        }
        public Dictionary<int,QuizData> GetQuizData()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<Dictionary<int, QuizData>>(request);
            if (response.ErrorException != null)
            {
                return response.Data;
            }
            else
            {
                throw new ApplicationException("Error retreiving quiz data from server", response.ErrorException);
            }
        }
    }
}
