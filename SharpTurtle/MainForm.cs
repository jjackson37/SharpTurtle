using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SharpTurtle
{
    public partial class mainForm : Form
    {
        const int maxX = 470, minX = 0, maxY = 560, minY = 0;
        static int coordX, coordY;
        List<string> lineList = new List<string>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            coordX = 5;
            coordY = 5;
            redrawLines();
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog selectColorDialog = new ColorDialog();
            selectColorDialog.AllowFullOpen = true;
            selectColorDialog.ShowHelp = true;
            selectColorDialog.Color = buttonSelectedColor.BackColor;
            if (selectColorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonSelectedColor.BackColor = selectColorDialog.Color;
                redrawLines();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            coordX = 5;
            coordY = 5;
            lineList.Clear();
            redrawLines();
        }

        private void redrawLines()
        {
            Pen drawingPen;
            Graphics formGraphics = CreateGraphics();
            formGraphics.Clear(Color.White);
            foreach (string lineString in lineList)
            {
                string[] lineArray = lineString.Split(' ');
                Color lineColor = Color.FromArgb(Convert.ToInt32(lineArray[4]), Convert.ToInt32(lineArray[5]), Convert.ToInt32(lineArray[6]), Convert.ToInt32(lineArray[7]));
                drawingPen = new Pen(lineColor);
                formGraphics.DrawLine(drawingPen, Convert.ToInt32(lineArray[0]), Convert.ToInt32(lineArray[1]), Convert.ToInt32(lineArray[2]), Convert.ToInt32(lineArray[3]));
                drawingPen.Dispose();
            }
            drawingPen = new Pen(buttonSelectedColor.BackColor);
            formGraphics.DrawEllipse(drawingPen, coordX - 3, coordY - 3, 6, 6);
            formGraphics.Dispose();
        }

        private void penDraw(object sender, EventArgs e)
        {
            int drawLength = Convert.ToInt32(textBox1.Text);
            Button pressedButton = (Button)sender;
            string addToList = Convert.ToString(coordX) + " " + Convert.ToString(coordY);
            switch (pressedButton.Name)
            {
                case "buttonUp":
                    if (coordY - drawLength > minY)
                        coordY -= drawLength;
                    else
                        coordY = minY;
                    break;
                case "buttonDown":
                    if (coordY + drawLength < maxY)
                        coordY += drawLength;
                    else
                        coordY = maxY;
                    break;
            }
            if (paintCheckBox.Checked)
            {
                addToList += (" " + Convert.ToString(coordX) + " " + Convert.ToString(coordY) + " "
                    + buttonSelectedColor.BackColor.A + " " + buttonSelectedColor.BackColor.R + " "
                    + buttonSelectedColor.BackColor.G + " " + buttonSelectedColor.BackColor.B);
                lineList.Add(addToList);
            }
            redrawLines();
        }

    }
}
