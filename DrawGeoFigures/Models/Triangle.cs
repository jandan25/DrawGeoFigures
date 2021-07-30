using System.Drawing;
using System.Windows.Forms;
using DrawGeoFigures.Utils;

namespace DrawGeoFigures.Models
{
    public class Triangle : Figure
    {
        private Point[] TrianglePoints { get; set; }
        public Triangle(float x, float y, float height, float width) : base(x, y, height, width)
        {
            TrianglePoints = new Point[]
            {
                new Point((int) x, (int) (y + height)),
                new Point((int) (x + width / 2), (int) y),
                new Point((int) (x + height), (int) (y + width))
            };
        }
        
        public override void Draw(Panel panel)
        {
            var g = panel.CreateGraphics();
            var sb = new Pen(ColorRandomizer.GetRandomColor());
            g.DrawPolygon(sb, TrianglePoints);
        }
    }
}