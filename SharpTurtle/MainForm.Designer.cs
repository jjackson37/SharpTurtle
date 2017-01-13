namespace SharpTurtle
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.buttonSelectedColor = new System.Windows.Forms.Button();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.paintCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDownLeft = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.buttonUpLeft = new System.Windows.Forms.Button();
            this.controlsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsBox
            // 
            this.controlsBox.Controls.Add(this.buttonUpLeft);
            this.controlsBox.Controls.Add(this.textBox1);
            this.controlsBox.Controls.Add(this.buttonDownRight);
            this.controlsBox.Controls.Add(this.buttonDownLeft);
            this.controlsBox.Controls.Add(this.buttonUpRight);
            this.controlsBox.Controls.Add(this.buttonSelectedColor);
            this.controlsBox.Controls.Add(this.buttonSelectColor);
            this.controlsBox.Controls.Add(this.buttonDown);
            this.controlsBox.Controls.Add(this.paintCheckBox);
            this.controlsBox.Controls.Add(this.buttonRight);
            this.controlsBox.Controls.Add(this.buttonLeft);
            this.controlsBox.Controls.Add(this.buttonUp);
            this.controlsBox.Location = new System.Drawing.Point(472, 5);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(200, 544);
            this.controlsBox.TabIndex = 0;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // buttonSelectedColor
            // 
            this.buttonSelectedColor.Enabled = false;
            this.buttonSelectedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectedColor.Location = new System.Drawing.Point(141, 287);
            this.buttonSelectedColor.Name = "buttonSelectedColor";
            this.buttonSelectedColor.Size = new System.Drawing.Size(44, 44);
            this.buttonSelectedColor.TabIndex = 0;
            this.buttonSelectedColor.UseVisualStyleBackColor = true;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(15, 285);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSelectColor.Size = new System.Drawing.Size(172, 48);
            this.buttonSelectColor.TabIndex = 6;
            this.buttonSelectColor.Text = "          Color Select";
            this.buttonSelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            // 
            // paintCheckBox
            // 
            this.paintCheckBox.AutoSize = true;
            this.paintCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCheckBox.Location = new System.Drawing.Point(33, 239);
            this.paintCheckBox.Name = "paintCheckBox";
            this.paintCheckBox.Size = new System.Drawing.Size(144, 29);
            this.paintCheckBox.TabIndex = 5;
            this.paintCheckBox.Text = "Brush down";
            this.paintCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(71, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 60);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(135, 85);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 60);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(7, 85);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(71, 151);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 60);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.penDraw);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.textBox1.Location = new System.Drawing.Point(71, 85);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 60);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1";
            // 
            // buttonDownLeft
            // 
            this.buttonDownLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownLeft.Location = new System.Drawing.Point(7, 151);
            this.buttonDownLeft.Name = "buttonDownLeft";
            this.buttonDownLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonDownLeft.TabIndex = 8;
            this.buttonDownLeft.Text = "↙";
            this.buttonDownLeft.UseVisualStyleBackColor = true;
            this.buttonDownLeft.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownRight.Location = new System.Drawing.Point(135, 151);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(60, 60);
            this.buttonDownRight.TabIndex = 9;
            this.buttonDownRight.Text = "↘";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpRight.Location = new System.Drawing.Point(135, 19);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(60, 60);
            this.buttonUpRight.TabIndex = 10;
            this.buttonUpRight.Text = "↗";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.penDraw);
            // 
            // buttonUpLeft
            // 
            this.buttonUpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpLeft.Location = new System.Drawing.Point(7, 19);
            this.buttonUpLeft.Name = "buttonUpLeft";
            this.buttonUpLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonUpLeft.TabIndex = 11;
            this.buttonUpLeft.Text = "↖";
            this.buttonUpLeft.UseVisualStyleBackColor = true;
            this.buttonUpLeft.Click += new System.EventHandler(this.penDraw);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.controlsBox);
            this.Name = "mainForm";
            this.Text = "SharpTurtle";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.controlsBox.ResumeLayout(false);
            this.controlsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.CheckBox paintCheckBox;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectedColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpLeft;
        private System.Windows.Forms.Button buttonDownRight;
        private System.Windows.Forms.Button buttonDownLeft;
        private System.Windows.Forms.Button buttonUpRight;
    }
}

