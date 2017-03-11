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
    public class QuestionsController : Controller
    {
        private LiteDatabase _db;
        public QuestionsController(LiteDatabase db)
        {
            _db = db;
        }

        [HttpGet("questions")]
        public IEnumerable<Question> Get()
        {
            return _db.GetCollection<Question>("questions").FindAll();
        }

        [HttpGet("question/{id:guid}")]
        public Question Get(Guid id)
        {
            return _db.GetCollection<Question>("questions").FindById(id);
        }

        [HttpPost("question")]
        public void Post([FromBody]Question question)
        {
            _db.GetCollection<Question>("questions").Upsert(question);
        }

        [HttpPut("question")]
        public void Put([FromBody]Question question)
        {
            _db.GetCollection<Question>("questions").Upsert(question);
        }

        [HttpDelete("question/{id:guid}")]
        public void Delete(Guid id)
        {
            _db.GetCollection<Question>("questions").Delete(id);
        }
    }
}
