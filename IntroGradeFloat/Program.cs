using System;

namespace IntroObject
{
    class Program
    {
        static void Main(string[] args)
        {
            float mark = 0;

            Print(mark);
            
            mark = Fill();

            Print(mark);
            
            Square(mark);

            Print(mark);
        }

        static void Print(float mark)
        {
            Console.WriteLine(mark);
        }

        static float Fill()
        {
            float mark;
            Console.Write("Veuillez saisir un nombre: ");
            mark = float.Parse(Console.ReadLine());
            return mark;
        }

        static void Square(float mark)
        {
            mark = mark * mark;
            Print(mark);
        }
    }
}
