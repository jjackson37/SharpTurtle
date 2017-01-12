using System;
using System.Windows.Forms;

namespace SharpTurtle
{
    public partial class mainForm : Form
    {
        const int MinX = 0, MinY = 0, MaxX = 9, MaxY = 10;
        int coordX = 0, coordY = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog selectColorDialog = new ColorDialog();
            selectColorDialog.AllowFullOpen = true;
            selectColorDialog.ShowHelp = true;
            selectColorDialog.Color = buttonSelectedColor.BackColor;
            if (selectColorDialog.ShowDialog() == DialogResult.OK)
                buttonSelectedColor.BackColor = selectColorDialog.Color;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            getButton().FlatAppearance.BorderSize = 5;
        }

        private void moveButtonClicked(object sender, EventArgs e)
        {
            getButton().FlatAppearance.BorderSize = 1;
            Button buttonClicked = (Button)sender;
            switch (buttonClicked.Name)
            {
                case "buttonUp":
                    if (coordY != MinY)
                    {
                        coordY--;
                        paintButton(getButton());
                    }
                    break;
                case "buttonDown":
                    if (coordY != MaxY)
                    {
                        coordY++;
                        paintButton(getButton());
                    }
                    break;
                case "buttonLeft":
                    if (coordX != MinX)
                    {
                        coordX--;
                        paintButton(getButton());
                    }
                    break;
                case "buttonRight":
                    if (coordX != MaxX)
                    {
                        coordX++;
                        paintButton(getButton());
                    }
                    break;
            }
            getButton().FlatAppearance.BorderSize = 5;
        }

        private void paintButton(Button selectedButton)
        {
            if(paintCheckBox.Checked)
            {
                selectedButton.BackColor = buttonSelectedColor.BackColor;
            }
        }

        private Button getButton()
        {
            Button returnButton = null;
            string tileName = "button" + coordX + coordY;
            foreach (Button loopButton in drawingPanel.Controls)
            {
                if (loopButton.Name.Equals(tileName))
                {
                    returnButton = loopButton;
                }
            }
            return returnButton;
        }
    }
}
