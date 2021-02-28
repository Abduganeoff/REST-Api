using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace REST_Api.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string Students(string orderBy="secondName")
        {
            return $"Alex, Jane, Justin sortBy={orderBy}";
        }

        [HttpGet("{id}")]
        public string Student(int id)
        {
            return "Alex";
        }


    }
}