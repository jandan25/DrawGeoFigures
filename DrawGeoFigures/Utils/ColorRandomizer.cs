using System;
using System.Drawing;

namespace DrawGeoFigures.Utils
{
    public abstract class ColorRandomizer
    {
        public static Color GetRandomColor()
        {
            var rand = new Random();
            const int max = byte.MaxValue + 1; // 256
            var r = rand.Next(max);
            var g = rand.Next(max);
            var b = rand.Next(max);
            var c = Color.FromArgb(r, g, b);
            
            return c;
        }
        
    }
}