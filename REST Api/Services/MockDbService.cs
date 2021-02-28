using REST_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Api.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdNumber=1, FirstName="Rizo", SecondName="Abduganeoff", IndexNumber="s2020"},
                new Student{IdNumber=2, FirstName="Muhammad", SecondName="Rizo", IndexNumber="s2021"},
                new Student{IdNumber=3, FirstName="Jason", SecondName="Stetham", IndexNumber="s2022"}
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
