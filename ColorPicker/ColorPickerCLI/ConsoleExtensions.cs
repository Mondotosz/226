using System;
using System.Runtime.InteropServices;

namespace TintCLI
{
    public class ConsoleExtensions
    {
        public static string ForegroundColorCommand(byte red, byte green, byte blue)
        {
            return $"\x1b[38;2;{red};{green};{blue}m";
        }

        public static string BackgroundColorCommand(byte red, byte green, byte blue)
        {
            return $"\x1b[48;2;{red};{green};{blue}m";
        }

        public static string ResetCommand = "\x1b[0m";



        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleMode(IntPtr handle, out int mode);
        [DllImport("kernel32.dll", SetLastError = true)]

        public static extern IntPtr GetStdHandle(int handle);
        // this static constructor is needed on non-unix machines, as the VT100 color codes are not always enabled by default.
        // see https://github.com/Unknown6656/Unknown6656.Core/blob/master/Unknown6656.Core/Controls/Console/ConsoleExtensions.cs
        static ConsoleExtensions()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var handle = GetStdHandle(-11);
                int mode;

                GetConsoleMode(handle, out mode);
                SetConsoleMode(handle, mode | 0x4);
            }
        }
    }
}
