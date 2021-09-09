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
                if (exception is BadClassNameException)
                {
                    Console.WriteLine("Votre nom de classe n'est pas conforme à la nomenclature!");
                } else if(exception is BadFirstNameException){
                    Console.WriteLine("Le prenom ne correspond pas a la nomeclature!");
                } 
                
            }
        }
    }
}
