using System;

namespace SchoolManagement
{
    public class BadFirstNameException : Exception
    {
        public BadFirstNameException()
        {

        }
        public BadFirstNameException(string message) : base(message)
        {

        }
        public BadFirstNameException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
