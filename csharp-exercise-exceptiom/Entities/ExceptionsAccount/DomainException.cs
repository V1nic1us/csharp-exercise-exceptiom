using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_exceptiom.Entities.Exceptions
{
    internal class DomainException: ApplicationException
    {
        public string Message { get; private set; }

        public DomainException(string message)
        {
            Message = message;
        }

        public override string ToString()
        {
            return Message;
        }
    }
}
