using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep_project_2
{
    internal class wrongInputException : Exception
    {
        public wrongInputException() { }
        public wrongInputException(string message) : base(message) { }
    }
}
