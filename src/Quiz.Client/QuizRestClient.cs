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
        public void SubmitResult(QuizData result)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("result", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(result);
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error adding question to server", response.ErrorException);
            }
        }
        public List<QuizData> GetResults()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<List<QuizData>>(request);
            if (response.ErrorException != null)
            {
                return response.Data;
            }
            else
            {
                throw new ApplicationException("Error retreiving question list from server", response.ErrorException);
            }
        }
        public void UpdateTestDuration(TimeSpan testDuration)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest($"quizinfo/quiztime/{Math.Round(testDuration.TotalMinutes)}", Method.POST);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error updating test duration server", response.ErrorException);
            }
        }
        public TimeSpan GetTestDuration()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("quizinfo/quiztime", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<int>(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error getting quiz info from server", response.ErrorException);
            }
            else
            {
                return TimeSpan.FromMinutes(response.Data);
            }
        }
        public void AddQuestion(Question question)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("question", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(question);
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error adding question to server", response.ErrorException);
            }
        }
        public List<Question> GetQuestions()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<List<Question>>(request);
            if(response.ErrorException != null)
            {
                return response.Data;
            }
            else
            {
                throw new ApplicationException("Error retreiving question list from server", response.ErrorException);
            }
        }
    }
}
