using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiteDB;

namespace Quiz.Server.Controllers
{
    [Route("api/quizinfo")]
    public class QuizInfoController : Controller
    {
       //LiteDatabase _db;
        public QuizInfoController()
        {
        //    _db = db;
        }
        [HttpGet("quiztime")]
        public int Get()
        {
            return Program.QuizDuration;
        }

        [HttpPost("quiztime/{time:int}")]
        public void Post([FromRoute]int time)
        {
            Program.QuizDuration = time;
        }

    }
}
