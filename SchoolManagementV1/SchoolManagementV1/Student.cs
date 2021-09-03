using System;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace SchoolManagement
{
    public class Student
    {
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value.ToUpper();
            }
        }
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!isValidFirsName(value)) throw new Exception("first name requires an uppercase");
                _firstName = value;
            }
        }
        private string _classname;
        public string ClassName
        {
            get => _classname;
            set
            {
                if (!isValidClassName(value)) throw new Exception("class name does not comply with our naming scheme");
                _classname = value;
            }
        }
        public Student(string FirstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = FirstName;
        }

        private bool isValidClassName(string className)
        {
            Regex regex = new Regex(@"^SI-(?:CA|MI|C)[1-4][a-z]$");
            return regex.IsMatch(className);
        }

        private bool isValidFirsName(string firstName)
        {
            return char.IsUpper(firstName[0]);
        }
    }
}
