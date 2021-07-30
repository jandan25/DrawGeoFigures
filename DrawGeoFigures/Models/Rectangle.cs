using System.Drawing;
using System.Windows.Forms;
using DrawGeoFigures.Utils;

namespace DrawGeoFigures.Models
{
    public class Rectangle : Figure
    {
        public Rectangle(float x, float y, float height, float width) : base(x, y, height, width)
        {
        }
        
        public override void Draw(Panel panel)
        {
            var g = panel.CreateGraphics();
            var sb = new Pen(ColorRandomizer.GetRandomColor());
            g.DrawRectangle(sb, X, Y, Width, Height);
        }

   
    }
}