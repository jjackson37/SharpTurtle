using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SharpTurtle
{
    public partial class mainForm : Form
    {
        const int _MAXX = 470, _MINX = 0, _MAXY = 560, _MINY = 0;
        static float coordX, coordY;
        float newX = 5.0F, newY = 5.0F;
        List<string> lineList = new List<string>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            coordX = 5.0F;
            coordY = 5.0F;
            textBox1.Value = 10;
            angleInput.Value = 0;
            buttonSelectedBackground.BackColor = Color.White;
            buttonSelectedColor.BackColor = Color.Red;
            lineList.Clear();
            RedrawLines();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            ExecuteCommands(commandInput.Text);
        }

        private void ExecuteCommands(string commandString)
        {
            bool incorrectCommand = false;
            string errors = "Incorrect command(s) found and not executed";
            string[] commandArray = commandString.Split(';');
            foreach (string currentCommand in commandArray)
            {

                if (!(currentCommand.Contains("(")))
                {
                    incorrectCommand = true;
                    continue;
                }
                string commandToExecute = currentCommand.Split('(')[0].ToLower();
                string commandParameter = currentCommand.Split('(')[1].TrimEnd(')').ToLower();
                switch (commandToExecute)
                {
                    case "forward":
                        MoveTurtle(Convert.ToInt32(commandParameter), true);
                        break;
                    case "backward":
                        MoveTurtle(Convert.ToInt32(commandParameter), false);
                        break;
                    case "left":
                        for (int i = 0; i != Convert.ToInt32(commandParameter); i++)
                        {
                            if (angleInput.Value == 0)
                            {
                                angleInput.Value = 360;
                            }
                            angleInput.Value--;
                        }
                        break;
                    case "right":
                        for (int i = 0; i != Convert.ToInt32(commandParameter); i++)
                        {
                            if (angleInput.Value == 360)
                            {
                                angleInput.Value = 0;
                            }
                            angleInput.Value++;
                        }
                        break;
                    case "pen":
                        paintCheckBox.Checked = Convert.ToBoolean(commandParameter);
                        break;
                    default:
                        incorrectCommand = true;
                        break;
                }
            }
            RedrawLines();
            if (incorrectCommand)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string caption = "SharpTurtle";
                MessageBox.Show(errors, caption, buttons, MessageBoxIcon.Error);
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

        private void buttonBackgroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog selectColorDialog = new ColorDialog();
            selectColorDialog.AllowFullOpen = true;
            selectColorDialog.ShowHelp = true;
            selectColorDialog.Color = buttonSelectedBackground.BackColor;
            if (selectColorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonSelectedBackground.BackColor = selectColorDialog.Color;
                RedrawLines();
            }
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            RedrawLines();
        }

        private void angleInput_ValueChanged(object sender, EventArgs e)
        {
            if(angleInput.Value > 360)
            {
                angleInput.Value = 0;
            }
        }

        private void buttonExecute_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string commandFile in files)
            {
                string text = System.IO.File.ReadAllText(commandFile);
                ExecuteCommands(text);
            }
            
        }

        private void buttonExecute_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear the current drawing?", "Clear drawing?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                mainForm_Load(null, null);
            }
        }

        private void RedrawLines()
        {
            Pen drawingPen;
            Graphics formGraphics = CreateGraphics();
            formGraphics.Clear(buttonSelectedBackground.BackColor);
            foreach (string lineString in lineList)
            {
                string[] lineArray = lineString.Split(' ');
                Color lineColor = Color.FromArgb(Convert.ToInt32(lineArray[4]), Convert.ToInt32(lineArray[5]), Convert.ToInt32(lineArray[6]), Convert.ToInt32(lineArray[7]));
                drawingPen = new Pen(lineColor);
                float oldX = Convert.ToSingle(lineArray[0]), oldY = Convert.ToSingle(lineArray[1]), newX = Convert.ToSingle(lineArray[2]), newY = Convert.ToSingle(lineArray[3]);
                formGraphics.DrawLine(drawingPen, oldX, oldY, newX, newY);
                drawingPen.Dispose();
            }
            drawingPen = new Pen(buttonSelectedColor.BackColor);
            formGraphics.DrawEllipse(drawingPen, coordX - 3, coordY - 3, 6, 6);
            formGraphics.Dispose();
        }

        private void PenDraw(object sender, EventArgs e)
        {
            int drawLength = Convert.ToInt32(textBox1.Text);
            Button pressedButton = (Button)sender;
            switch (pressedButton.Name)
            {
                case "buttonUp":
                    MoveTurtle(drawLength, true);
                    break;
                case "buttonDown":
                    MoveTurtle(drawLength, false);
                    break;
            }
            RedrawLines();
        }

        private void CheckBoundires(float x, float y, bool forward)
        {
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
                    newX = _MAXX;
                }
                if (y <= _MINY)
                {
                    newY = _MINY;
                }
            }
            else if (angle == 315)
            {
                if (x <= _MINX)
                {
                    newX = _MINX;
                }
                if (y >= _MAXY)
                {
                    newY = _MAXY;
                }
            }
            else if (135 < angle & angle < 315)
            {
                if (x <= _MINX)
                {
                    newX = _MINX;
                }
                if (y <= _MINY)
                {
                    newY = _MINY;
                }
            }
            else
            {
                if (x >= _MAXX)
                {
                    newX = _MAXX;
                }
                if (y >= _MAXY)
                {
                    newY = _MAXY;
                }
            }
        }

        private void MoveTurtle(int drawLength, bool forward)
        {
            string addToList = Convert.ToString(coordX) + " " + Convert.ToString(coordY);
            double angleRadians = ((double)angleInput.Value % 360) * Math.PI / 180;
            newX = coordX;
            newY = coordY;
            if (forward)
            {
                for (int i = 0; i != drawLength; i++)
                {
                    newY = newY + (float)(1 * Math.Cos(angleRadians));
                    newX = newX + (float)(1 * Math.Sin(angleRadians));
                    CheckBoundires(newX, newY, true);
                }
            }
            else
            {
                for (int i = 0; i != drawLength; i++)
                {
                    
                    newY = newY - (float)(1 * Math.Cos(angleRadians));
                    newX = newX - (float)(1 * Math.Sin(angleRadians));
                    CheckBoundires(newX, newY, false);
                }
            }
            coordX = (float)Math.Round(newX, 1);
            coordY = (float)Math.Round(newY, 1);
            if (paintCheckBox.Checked)
            {
                addToList += (" " + Convert.ToString(coordX) + " " + Convert.ToString(coordY) + " "
                    + buttonSelectedColor.BackColor.A + " " + buttonSelectedColor.BackColor.R + " "
                    + buttonSelectedColor.BackColor.G + " " + buttonSelectedColor.BackColor.B);
                lineList.Add(addToList);
            }
        }
    }
}
