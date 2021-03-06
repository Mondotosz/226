using System;
using System.Text.RegularExpressions;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace SchoolManagement
{
    public class Student
    {
        private string _lastName;
        private string _firstName;
        private string _classname;
        [Name("LastName")]
        public string LastName
        {
            get => _lastName;
            set
            { _lastName = value.ToUpper(); }
        }
        [Name("FirstName")]
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!isValidFirsName(value)) throw new BadFirstNameException("first name requires an uppercase");
                _firstName = value;
            }
        }
        [Name("ClassName")]
        public string ClassName
        {
            get => _classname;
            set
            {
                if (!isValidClassName(value)) throw new BadClassNameException("class name does not comply with our naming scheme");
                _classname = value;
            }
        }

        public Student(string FirstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = FirstName;
        }
        public Student(string FirstName, string lastName, string className)
        {
            this.LastName = lastName;
            this.FirstName = FirstName;
            this.ClassName = className;
        }

        public override String ToString()
        {
            return $"{FirstName} {LastName} ({ClassName})";
        }

        public String Serialize()
        {
            return $"{FirstName},{LastName},{ClassName}";
        }

        private bool isValidClassName(string className)
        {
            Regex regex = new Regex(@"^SI-(?:CA|MI|C)[1-4][a-z]$");
            return regex.IsMatch(className);
        }

        private bool isValidFirsName(string firstName)
        {
            return !string.IsNullOrEmpty(firstName) ? char.IsUpper(firstName[0]) : false;
        }
    }

    public sealed class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Map(m => m.FirstName);
            Map(m => m.LastName);
            Map(m => m.ClassName);
        }

    }
}
