using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiteDB;
using Quiz.Common.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Quiz.Server.Controllers
{
    [Route("api")]
    public class QuizController : Controller
    {
        private LiteDatabase _db;
        public QuizController(LiteDatabase db)
        {
            _db = db;
        }
        [HttpPost("results")]
        public IEnumerable<QuizData> GetResults()
        {
            return _db.GetCollection<QuizData>("results").FindAll();
        }
        [HttpPost("result")]
        public void SubmitQuiz([FromBody]QuizData quizData)
        {
            _db.GetCollection<QuizData>("results").Insert(quizData);
        }
        [HttpGet("quizzes")]
        public IEnumerable<Common.Models.Quiz> GetQuizzes()
        {
            return _db.GetCollection<Common.Models.Quiz>("quizzes").FindAll();
        }
        [HttpGet("quiz/{id:guid}")]
        public Common.Models.Quiz GetQuiz([FromRoute]Guid id)
        {
            return _db.GetCollection<Common.Models.Quiz>("quizzes").FindById(id);
        }

        [HttpPost("quiz")]
        public void SubmitQuiz([FromBody]Common.Models.Quiz quiz)
        {
            _db.GetCollection<Common.Models.Quiz>("quizzes").Insert(quiz);
        }
        [HttpPut("quiz")]
        public void UpsertQuiz([FromBody]Common.Models.Quiz quiz)
        {
            _db.GetCollection<Common.Models.Quiz>("quizzes").Upsert(quiz);
        }

        [HttpDelete("quiz/{id:guid}")]
        public void Delete([FromRoute]Guid id)
        {
            _db.GetCollection<Common.Models.Quiz>("quizzes").Delete(id);
        }

        [HttpDelete("quizzes")]
        public void Delete()
        {
            _db.GetCollection<Common.Models.Quiz>("quizzes").Delete(_ => true);
        }
    }
}
