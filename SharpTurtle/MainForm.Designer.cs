﻿namespace SharpTurtle
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
            this.buttonSelectedBackground = new System.Windows.Forms.Button();
            this.buttonBackgroundColour = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.NumericUpDown();
            this.paintCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angleInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSelectedColor = new System.Windows.Forms.Button();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.commandInput = new System.Windows.Forms.TextBox();
            this.controlsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsBox
            // 
            this.controlsBox.BackColor = System.Drawing.SystemColors.Control;
            this.controlsBox.Controls.Add(this.buttonSelectedBackground);
            this.controlsBox.Controls.Add(this.buttonBackgroundColour);
            this.controlsBox.Controls.Add(this.buttonExecute);
            this.controlsBox.Controls.Add(this.textBox1);
            this.controlsBox.Controls.Add(this.paintCheckBox);
            this.controlsBox.Controls.Add(this.label2);
            this.controlsBox.Controls.Add(this.angleInput);
            this.controlsBox.Controls.Add(this.label1);
            this.controlsBox.Controls.Add(this.buttonReset);
            this.controlsBox.Controls.Add(this.buttonSelectedColor);
            this.controlsBox.Controls.Add(this.buttonSelectColor);
            this.controlsBox.Controls.Add(this.buttonDown);
            this.controlsBox.Controls.Add(this.buttonUp);
            this.controlsBox.Location = new System.Drawing.Point(472, 5);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(200, 660);
            this.controlsBox.TabIndex = 0;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // buttonSelectedBackground
            // 
            this.buttonSelectedBackground.BackColor = System.Drawing.Color.Red;
            this.buttonSelectedBackground.Enabled = false;
            this.buttonSelectedBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectedBackground.Location = new System.Drawing.Point(141, 425);
            this.buttonSelectedBackground.Name = "buttonSelectedBackground";
            this.buttonSelectedBackground.Size = new System.Drawing.Size(44, 44);
            this.buttonSelectedBackground.TabIndex = 18;
            this.buttonSelectedBackground.UseVisualStyleBackColor = false;
            // 
            // buttonBackgroundColour
            // 
            this.buttonBackgroundColour.Location = new System.Drawing.Point(15, 423);
            this.buttonBackgroundColour.Name = "buttonBackgroundColour";
            this.buttonBackgroundColour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBackgroundColour.Size = new System.Drawing.Size(172, 48);
            this.buttonBackgroundColour.TabIndex = 19;
            this.buttonBackgroundColour.Text = "Background Color Select";
            this.buttonBackgroundColour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackgroundColour.UseVisualStyleBackColor = true;
            this.buttonBackgroundColour.Click += new System.EventHandler(this.buttonBackgroundColour_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.AllowDrop = true;
            this.buttonExecute.Location = new System.Drawing.Point(7, 571);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(91, 83);
            this.buttonExecute.TabIndex = 17;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            this.buttonExecute.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonExecute_DragDrop);
            this.buttonExecute.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonExecute_DragEnter);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.textBox1.Location = new System.Drawing.Point(17, 196);
            this.textBox1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 60);
            this.textBox1.TabIndex = 16;
            this.textBox1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // paintCheckBox
            // 
            this.paintCheckBox.AutoSize = true;
            this.paintCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCheckBox.Location = new System.Drawing.Point(17, 477);
            this.paintCheckBox.Name = "paintCheckBox";
            this.paintCheckBox.Size = new System.Drawing.Size(138, 29);
            this.paintCheckBox.TabIndex = 5;
            this.paintCheckBox.Text = "Pen down?";
            this.paintCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Distance:";
            // 
            // angleInput
            // 
            this.angleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.angleInput.Location = new System.Drawing.Point(17, 275);
            this.angleInput.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleInput.Name = "angleInput";
            this.angleInput.Size = new System.Drawing.Size(170, 60);
            this.angleInput.TabIndex = 14;
            this.angleInput.ValueChanged += new System.EventHandler(this.angleInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Angle:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(104, 571);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 83);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSelectedColor
            // 
            this.buttonSelectedColor.BackColor = System.Drawing.Color.Red;
            this.buttonSelectedColor.Enabled = false;
            this.buttonSelectedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectedColor.Location = new System.Drawing.Point(141, 371);
            this.buttonSelectedColor.Name = "buttonSelectedColor";
            this.buttonSelectedColor.Size = new System.Drawing.Size(44, 44);
            this.buttonSelectedColor.TabIndex = 0;
            this.buttonSelectedColor.UseVisualStyleBackColor = false;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(15, 369);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSelectColor.Size = new System.Drawing.Size(172, 48);
            this.buttonSelectColor.TabIndex = 6;
            this.buttonSelectColor.Text = "       Line Color Select";
            this.buttonSelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(17, 85);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(170, 60);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Reverse";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.PenDraw);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(17, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(170, 60);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Forward";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.PenDraw);
            // 
            // commandInput
            // 
            this.commandInput.Location = new System.Drawing.Point(12, 576);
            this.commandInput.MaxLength = 2147483647;
            this.commandInput.Multiline = true;
            this.commandInput.Name = "commandInput";
            this.commandInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandInput.Size = new System.Drawing.Size(454, 89);
            this.commandInput.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 677);
            this.Controls.Add(this.commandInput);
            this.Controls.Add(this.controlsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpTurtle";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.controlsBox.ResumeLayout(false);
            this.controlsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.CheckBox paintCheckBox;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectedColor;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown angleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandInput;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonSelectedBackground;
        private System.Windows.Forms.Button buttonBackgroundColour;
    }
}

