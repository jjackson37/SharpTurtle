using System;
using System.Windows.Forms;

namespace SharpTurtle
{
    public partial class mainForm : Form
    {
        const int MinX = 0, MinY = 0, MaxX = 9, MaxY = 10;
        int coordX = 5, coordY = 5;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void penDraw(object sender, EventArgs e)
        {
            try
            {
                int drawLength = Convert.ToInt32(textBox1.Text);
                System.Drawing.Pen drawingPen;
                drawingPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics = CreateGraphics();
                Button pressedButton = (Button)sender;
                switch (pressedButton.Name)
                {
                    case "buttonUp":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX, coordY - drawLength);
                        coordY -= drawLength;
                        break;
                    case "buttonUpLeft":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX - drawLength, coordY - drawLength);
                        coordY -= drawLength;
                        coordX -= drawLength;
                        break;
                    case "buttonUpRight":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX + drawLength, coordY - drawLength);
                        coordY -= drawLength;
                        coordX += drawLength;
                        break;
                    case "buttonDown":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX, coordY + drawLength);
                        coordY += drawLength;
                        break;
                    case "buttonDownLeft":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX - drawLength, coordY + drawLength);
                        coordY += drawLength;
                        coordX -= drawLength;
                        break;
                    case "buttonDownRight":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX + drawLength, coordY + drawLength);
                        coordY += drawLength;
                        coordX += drawLength;
                        break;
                    case "buttonLeft":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX - drawLength, coordY);
                        coordX -= drawLength;
                        break;
                    case "buttonRight":
                        formGraphics.DrawLine(drawingPen, coordX, coordY, coordX + drawLength, coordY);
                        coordX += drawLength;
                        break;
                }
                drawingPen.Dispose();
                formGraphics.Dispose();
            }
            catch
            {

            }
        }
    }
}
