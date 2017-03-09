﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiteDB;

namespace Quiz.Server.Controllers
{
    [Route("api/[controller]")]
    public class QuizInfoController : Controller
    {
        LiteDatabase _db;
        public QuizInfoController(LiteDatabase db)
        {
            _db = db;
        }
        [HttpGet("quiztime")]
        public int Get()
        {
            return _db.GetCollection<int>("quiztime").FindAll().First();
        }

        [HttpPut]
        [HttpPost]
        public void Post([FromBody]int time)
        {
            _db.GetCollection<int>("quiztime").Delete(x => true);
            _db.GetCollection<int>("quiztime").Upsert(time);
        }

    }
}
