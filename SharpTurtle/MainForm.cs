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

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
