using System;
using System.Windows.Forms;
using DrawGeoFigures.Models;

namespace DrawGeoFigures
{
    public partial class Form1 : Form
    {
        private string _tempWidth;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {
            textBoxX.Text = DrawingPanel.PointToClient(Cursor.Position).X.ToString();
            textBoxY.Text = DrawingPanel.PointToClient(Cursor.Position).Y.ToString();

            var figure = new Rectangle(float.Parse(textBoxX.Text) - float.Parse(textBoxWidth.Text) / 2,
                float.Parse(textBoxY.Text) - float.Parse(textBoxHeight.Text) / 2,
                float.Parse(textBoxHeight.Text),
                float.Parse(textBoxWidth.Text));
            
            if (radioButtonEllipse.Checked)
            {
                var circle = new Circle(figure.X, figure.Y, figure.Height, figure.Width);
            
                circle.Draw(DrawingPanel);
            }

            else if (radioButtonRectangle.Checked)
            {
                var rectangle = new Rectangle(figure.X, figure.Y, figure.Height, figure.Width);
            
                rectangle.Draw(DrawingPanel);
            }

            else if (radioButtonTriangle.Checked)
            {
                var triangle = new Triangle(figure.X, figure.Y, figure.Height, figure.Width);
            
                triangle.Draw(DrawingPanel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void buttonSqCircle_Click(object sender, EventArgs e)
        {
            if (textBoxHeight.Text != textBoxWidth.Text)
            {
                _tempWidth = textBoxHeight.Text;
                textBoxHeight.Text = textBoxWidth.Text;
            }
            else
            {
                textBoxHeight.Text = _tempWidth;
            }
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox) sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}