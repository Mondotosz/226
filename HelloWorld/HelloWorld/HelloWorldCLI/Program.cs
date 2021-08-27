using System;
using System.Collections.Generic;
using HelloWorld;

namespace HelloWorldCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Greeter.Greet("mon"));
            int value = 60;
            double wave;
            int padding = 60;
            double amplitude = 7;
            double scale = 0.5;

            for (int iteration = 0; iteration < value; iteration++)
            {
                wave = iteration * scale;
                Console.WriteLine("*".PadLeft(((int)(Math.Sin(wave)*amplitude)) +padding + 1));
            }
        }
    }
}
