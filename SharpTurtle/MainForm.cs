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
        static System.Drawing.Drawing2D.GraphicsState currentDrawing;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            buttonExecute.Text = "Execute";
            coordX = 5.0F;
            coordY = 5.0F;
            textBox1.Value = 10;
            angleInput.Value = 0;
            buttonSelectedBackground.BackColor = Color.White;
            buttonSelectedColor.BackColor = Color.Red;
            currentDrawing = null;
            RedrawLines();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            buttonExecute.Text = "Processing...";
            ExecuteCommands(commandInput.Text);
            buttonExecute.Text = "Execute";
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
                    case "color":
                        buttonSelectedColor.BackColor = Color.FromName(commandParameter);
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
            buttonExecute.Text = "Processing...";
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string commandFile in files)
            {
                string text = System.IO.File.ReadAllText(commandFile);
                ExecuteCommands(text);
            }
            buttonExecute.Text = "Execute";
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
            Color lineColor = buttonSelectedColor.BackColor;
            Pen drawingPen = new Pen(lineColor);
            Graphics formGraphics = CreateGraphics();
            formGraphics.Clear(buttonSelectedBackground.BackColor);
            if (currentDrawing != null)
            {
                formGraphics.Restore(currentDrawing);
            }
            if (paintCheckBox.Checked)
            {
                formGraphics.DrawLine(drawingPen, coordX, coordY, (float)Math.Round(newX, 1), (float)Math.Round(newY, 1));
            }
            formGraphics.Save();
            coordY = (float)Math.Round(newY, 1);
            coordX = (float)Math.Round(newX, 1);
            formGraphics.DrawEllipse(drawingPen, coordX - 3, coordY - 3, 6, 6);
            drawingPen.Dispose();
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
            RedrawLines();
        }
    }
}
