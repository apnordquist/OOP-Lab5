using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class InvalidRadiusException : Exception
    {
        //constructors
        public InvalidRadiusException() : base() { } //no argument
        public InvalidRadiusException(string message) : base(message) { } //message from Circle class
        public InvalidRadiusException(string message, Exception inner) : base(message,inner) { } // message and innerException
    }
}
