using System;
using ColorPicker;

namespace ColorPickerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(255, 0, 0);
            printColor(color);
            void printColor(Color color)
            {
                Console.WriteLine("#{0:x2}{1:x2}{2:x2}", color.red, color.green, color.blue);
                Console.WriteLine($"#{Convert.ToString(color.red, 16).PadLeft(2, '0')}{Convert.ToString(color.green, 16).PadLeft(2, '0')}{Convert.ToString(color.blue, 16).PadLeft(2, '0')}");
            }
        }
    }
}
