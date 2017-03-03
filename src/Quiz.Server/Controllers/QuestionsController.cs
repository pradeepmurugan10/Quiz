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
    [Route("api/[controller]")]
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

        // GET api/values/5
        [HttpGet("question/{id:guid}")]
        public Question Get(Guid id)
        {
            return _db.GetCollection<Question>("questions").FindById(id);
        }

        // POST api/values
        [HttpPost("question")]
        public void Post([FromBody]Question question)
        {
            _db.GetCollection<Question>("questions").Upsert(question);
        }

        // PUT api/values/5
        [HttpPut("question")]
        public void Put([FromBody]Question question)
        {
            _db.GetCollection<Question>("questions").Upsert(question);
        }

        // DELETE api/values/5
        [HttpDelete("question/{id:guid}")]
        public void Delete(Guid id)
        {
            _db.GetCollection<Question>("questions").Delete(id);
        }
    }
}
