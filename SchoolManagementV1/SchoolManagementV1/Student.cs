using System;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace SchoolManagement
{
    public class Student
    {
        private string _lastName;
        public string lastName
        {
            get => _lastName;
            set
            {
                _lastName = value.ToUpper();
            }
        }
        private string _firstName;
        public string firstName
        {
            get => _firstName;
            set
            {
                if (!IsValidFirsName(value)) throw new Exception("first name requires an uppercase");
                _firstName = value;
            }
        }
        private string _classname;
        public string className
        {
            get => _classname;
            set
            {
                if (!IsValidClassName(value)) throw new Exception("class name does not comply with our naming scheme");
                _classname = value;
            }
        }
        public Student(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        private bool IsValidClassName(string className)
        {
            Regex regex = new Regex(@"^SI-(?:CA|MI|C)[1-4][a-z]$");
            return regex.IsMatch(className);
        }

        private bool IsValidFirsName(string firstName)
        {
            return char.IsUpper(firstName[0]);
        }
    }
}
