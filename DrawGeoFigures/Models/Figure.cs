using System.Windows.Forms;

namespace DrawGeoFigures.Models
{
    public abstract class Figure
    {
        protected Figure(float x, float y, float height, float width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public float X { get; private set; }
        public float Y { get; private set; }
        public float Height { get; set; }
        public float Width { get; set; }

        public virtual void Draw(Panel paintEventArgs)
        {
            
        }
    }
}