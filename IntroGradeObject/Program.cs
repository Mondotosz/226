using System;

namespace IntroObject
{
    class Grade
    {
        public float value = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Grade mark = null;

            Print(mark);
            
            mark = Fill();

            Print(mark);
            
            Square(mark);

            Print(mark);
        }

        static void Print(Grade mark)
        {
            Console.WriteLine(mark.value);
        }

        static Grade Fill()
        {
            Grade mark = new Grade();
            Console.Write("Veuillez saisir un nombre: ");
            mark.value = float.Parse(Console.ReadLine());
            return mark;
        }

        static void Square(Grade mark)
        {
            mark.value = mark.value * mark.value;
            Print(mark);
        }
    }
}
