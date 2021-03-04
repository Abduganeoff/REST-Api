using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Api.Exceptions
{
    public class StudentCouldNotDefendException : Exception
    {
        public StudentCouldNotDefendException(string message) : base(message)
        {
        }

        public StudentCouldNotDefendException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
