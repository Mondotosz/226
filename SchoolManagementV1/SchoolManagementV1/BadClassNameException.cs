using System;

namespace SchoolManagement
{
    public class BadClassNameException : Exception
    {
        public BadClassNameException()
        {

        }
        public BadClassNameException(string message) : base(message)
        {

        }
        public BadClassNameException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
