using System.Drawing;
using System.Windows.Forms;
using DrawGeoFigures.Utils;

namespace DrawGeoFigures.Models
{
    public class Circle : Figure
    {
        public override void Draw(Panel panel)
        {
            var g = panel.CreateGraphics();
            var sb = new Pen(ColorRandomizer.GetRandomColor());
            g.DrawEllipse(sb, X, Y, Width, Height);
        }

        public Circle(float x, float y, float height, float width) : base(x, y, height, width)
        {
        }
    }
}