using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AnimalException : Exception
    {
        public AnimalException(string messange) : base(messange) { }
    }

    public class InvalidAgeException : AnimalException
    {
        public InvalidAgeException() : base("Invalid age input") { }
    }

    public class InvalidWeightException : AnimalException
    {
        public InvalidWeightException() : base("Invalid weight input") { }
    }
}
