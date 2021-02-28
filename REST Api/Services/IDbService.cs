using REST_Api.Models;
using System.Collections.Generic;

namespace REST_Api.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
