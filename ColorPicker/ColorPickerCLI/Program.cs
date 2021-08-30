using System;
using ColorPicker;
using TintCLI;

namespace ColorPickerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color;
            var random = new Random();
            var bytes = new byte[3];
            for (int loop = 0; loop < 15; loop++)
            {
                random.NextBytes(bytes);
                color = new Color(bytes[0],bytes[1],bytes[2]);
                printColor(color);
            }

            void printColor(Color color)
            {
                Color complementaryColor = color.ContrastColor();
                Console.WriteLine(ConsoleExtensions.BackgroundColorCommand(color.red, color.green, color.blue) + ConsoleExtensions.ForegroundColorCommand(complementaryColor.red, complementaryColor.green, complementaryColor.blue) + "#{0:x2}{1:x2}{2:x2}" + ConsoleExtensions.ResetCommand, color.red, color.green, color.blue);
            }
        }
    }
}
