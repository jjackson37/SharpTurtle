using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SharpTurtle
{
    public partial class mainForm : Form
    {
        const int _MAXX = 470, _MINX = 0, _MAXY = 560, _MINY = 0;
        static int coordX, coordY;
        float newX = 5, newY = 5;
        List<string> lineList = new List<string>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            coordX = 5;
            coordY = 5;
            RedrawLines();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string commandString = commandInput.Text;
            string[] commandArray = commandString.Split(';');
            foreach(string currentCommand in commandArray)
            {
                string commandToExecute = currentCommand.Split('(')[0].ToLower();
                string commandParameter = currentCommand.Split('(')[1].TrimEnd(')').ToLower();
                switch (commandToExecute)
                {
                    case "forward":

                        break;
                    case "backward":

                        break;
                    case "left":

                        break;
                    case "right":

                        break;
                    case "pen":
                        paintCheckBox.Checked = Convert.ToBoolean(commandParameter);
                        break;
                    default:
                        break;
                }
            }
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
                RedrawLines();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            coordX = 5;
            coordY = 5;
            lineList.Clear();
            RedrawLines();
        }

        private void RedrawLines()
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

        private void PenDraw(object sender, EventArgs e)
        {
            int drawLength = Convert.ToInt32(textBox1.Text);
            newX = coordX;
            newY = coordY;
            Button pressedButton = (Button)sender;
            string addToList = Convert.ToString(coordX) + " " + Convert.ToString(coordY);
            var angleRadians = ((int)angleInput.Value % 360) * Math.PI / 180;
            switch (pressedButton.Name)
            {
                case "buttonUp":
                    for (int i = 0; i != drawLength; i++)
                    {
                        newY = newY + (float)(1 * Math.Cos(angleRadians));
                        newX = newX + (float)(1 * Math.Sin(angleRadians));
                        if (CheckBoundires(newX, newY, true))
                        {
                            break;
                        }
                    }
                    coordX = (int)newX;
                    coordY = (int)newY;
                    break;
                case "buttonDown":
                    for (int i = 0; i != drawLength; i++)
                    {
                        newY = newY - (float)(1 * Math.Cos(angleRadians));
                        newX = newX - (float)(1 * Math.Sin(angleRadians));
                        if (CheckBoundires(newX, newY, false))
                        {
                            break;
                        }
                    }
                    coordX = (int)newX;
                    coordY = (int)newY;
                    break;
            }
            if (paintCheckBox.Checked)
            {
                addToList += (" " + Convert.ToString(coordX) + " " + Convert.ToString(coordY) + " "
                    + buttonSelectedColor.BackColor.A + " " + buttonSelectedColor.BackColor.R + " "
                    + buttonSelectedColor.BackColor.G + " " + buttonSelectedColor.BackColor.B);
                lineList.Add(addToList);
            }
            RedrawLines();
        }

        private bool CheckBoundires(float x, float y, bool forward)
        {
            bool boundryHit = false;
            int angle = 0;
            angle = (int)(angleInput.Value);
            if (!forward)
            {
                if (angle < 180)
                {
                    angle += 180;
                }
                else
                {
                    angle -= 180;
                }
            }
            if (angle == 135)
            {
                if (x >= _MAXX)
                {
                    boundryHit = true;
                    newX = _MAXX;
                }
                if (y <= _MINY)
                {
                    newY = _MINY;
                    boundryHit = true;
                }
            }
            else if (angle == 315)
            {
                if (x <= _MINX)
                {
                    boundryHit = true;
                    newX = _MINX;
                }
                if (y >= _MAXY)
                {
                    newY = _MAXY;
                    boundryHit = true;
                }
            }
            else if(135<angle & angle<315)
            {
                if (x <= _MINX)
                {
                    boundryHit = true;
                    newX = _MINX;
                }
                if (y <= _MINY)
                {
                    newY = _MINY;
                    boundryHit = true;
                }
            }
            else
            {
                if (x >= _MAXX)
                {
                    newX = _MAXX;
                    boundryHit = true;
                }
                if (y >= _MAXY)
                {
                    newY = _MAXY;
                    boundryHit = true;
                }
            }
            return boundryHit;
        }

    }
}
