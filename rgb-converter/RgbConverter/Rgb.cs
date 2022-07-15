using System;
using System.Globalization;

namespace RgbConverter
{
    public static class Rgb
    {
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            if (red < 0)
            {
               red = 0;
            }
            else if (green < 0)
            {
                green = 0;
            }
            else if (blue < 0)
            {
                blue = 0;
            } 
            else if (red > 255)
            {
                red = 255;
            }
            else if (green > 255)
            {
                green = 255;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

            CultureInfo inVar = CultureInfo.InvariantCulture;
            string rgb = red.ToString("X2", inVar) + green.ToString("X2", inVar) + blue.ToString("X2", inVar);
            return rgb;
        }
    }
}
