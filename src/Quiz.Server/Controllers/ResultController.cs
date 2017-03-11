using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Common.Models;
using LiteDB;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Quiz.Server.Controllers
{
    [Route("api/[controller]")]
    public class ResultController : Controller
    {
        LiteDatabase _db;
        public ResultController(LiteDatabase db)
        {
            _db = db;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<QuizData> Get()
        {
            return _db.GetCollection<QuizData>("results").FindAll();
        }
        /*
        // GET api/values/5
        [HttpGet("{rollNumber:regex(^[a-zA-Z0-9_ ]*$)")]
        public QuizData Get(string rollNumber)
        {
            return _db.GetCollection<QuizData>("results").FindOne(x=> x.RollNumber == rollNumber);
        }
        */
        // POST api/values
        [HttpPost]
        public void Post([FromBody]QuizData data)
        {
            _db.GetCollection<QuizData>("results").Upsert(data);
        }

    }
}
