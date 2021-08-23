using System;

namespace HelloWorldCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld.Greeter.Greet("mon"));
        }
    }
}
