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
                student.className = "SI-MI3z";
                Console.WriteLine($"{student.firstName} {student.lastName} {student.className}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
