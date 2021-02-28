using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Api.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
