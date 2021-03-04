using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_Api.Exceptions;
using REST_Api.Models;
using REST_Api.Services;

namespace REST_Api.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        public IActionResult Students(string orderBy="secondName")
        {
            throw new StudentCouldNotDefendException("Student did not pass ASD exam");
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult Student(int id)
        {
            if (id == 1) return Ok("Alex");
            else if (id == 2) return Ok("Jane");
            else if (id == 3) return Ok("Justin");
            else return NotFound("Student Not Found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }




    }
}