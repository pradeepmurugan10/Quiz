using Quiz.Common.Models;
using RestSharp;
using RestSharp.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz.Client
{
    class QuizRestClient
    {
        RestClient innerClient;
        public QuizRestClient(string IPAddress)
        {

        }
        public void AddQuestion(Question question)
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET);
            var response = innerClient.Execute(new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET));
            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error adding question to server", response.ErrorException);
            }
        }
        public List<Question> GetQuestions()
        {
            var request = new RestSharp.Newtonsoft.Json.RestRequest("questions", Method.GET);
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
