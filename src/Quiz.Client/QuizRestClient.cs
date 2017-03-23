using Quiz.Common.Models;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz.Client
{
    class QuizRestClient
    {
        RestClient innerClient;
        public QuizRestClient(string IPAddress)
        {
            innerClient = new RestClient(IPAddress + "/api");
            innerClient.AddHandler("application/json", NewtonsoftJsonSerializer.Default);
            innerClient.AddHandler("text/json", NewtonsoftJsonSerializer.Default);
            innerClient.AddHandler("text/x-json", NewtonsoftJsonSerializer.Default);
            innerClient.AddHandler("text/javascript", NewtonsoftJsonSerializer.Default);
            innerClient.AddHandler("*+json", NewtonsoftJsonSerializer.Default);
        }
        #region Results
        public IEnumerable<QuizData> GetQuizData()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("results", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = innerClient.Execute<List<QuizData>>(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error retreiving quiz result data from server", response.ErrorException);

            }
            else
            {
                return response.Data;
            }
        }

        public void SubmitQuizData(QuizData quizData)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("result", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(quizData);
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error submitting quiz result data to server", response.ErrorException);
            }
        }
        #endregion
        #region Quiz
        public void SubmitQuiz(Common.Models.Quiz quiz)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("quiz", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(quiz);
            var response = innerClient.Execute(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error submitting quiz data from server", response.ErrorException);
            }
        }
        public Common.Models.Quiz GetQuiz() => GetQuiz(Guid.Parse("de5c69af-7c52-46be-b241-93ab9806f886"));
        public Common.Models.Quiz GetQuiz(Guid quizId)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest($"quiz/{quizId.ToString()}", Method.GET);
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
        #endregion
    }
}
