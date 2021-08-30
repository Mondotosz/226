using System;

namespace ColorPicker
{
    public class Color
    {
        public Byte red;
        public Byte green;
        public Byte blue;

        public Color(Byte red, Byte green, Byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public Color ComplementaryColor()
        {
            return new Color((byte)(255 - this.red), (byte)(255 - this.green), (byte)(255 - this.blue));
        }

        public Color ContrastColor()
        {
            byte contrast = (Luminescence() <= 127) ? (byte)255 : (byte)0;
            return new Color(contrast, contrast, contrast);
        }

        public byte Luminescence()
        {
            return (byte)((red + green + blue) / 3);
        }

    }
}
