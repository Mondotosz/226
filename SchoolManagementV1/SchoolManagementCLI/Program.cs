using SchoolManagement;
using System;

namespace SchoolManagementCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Kenan", "augsburger");
                student.ClassName = "SI-MI3z";
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.ClassName}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
