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
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsBox
            // 
            this.controlsBox.Controls.Add(this.buttonSelectedColor);
            this.controlsBox.Controls.Add(this.buttonSelectColor);
            this.controlsBox.Controls.Add(this.paintCheckBox);
            this.controlsBox.Controls.Add(this.buttonUp);
            this.controlsBox.Controls.Add(this.buttonRight);
            this.controlsBox.Controls.Add(this.buttonLeft);
            this.controlsBox.Controls.Add(this.buttonDown);
            this.controlsBox.Location = new System.Drawing.Point(487, 5);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(185, 544);
            this.controlsBox.TabIndex = 0;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // buttonSelectedColor
            // 
            this.buttonSelectedColor.Enabled = false;
            this.buttonSelectedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectedColor.Location = new System.Drawing.Point(132, 252);
            this.buttonSelectedColor.Name = "buttonSelectedColor";
            this.buttonSelectedColor.Size = new System.Drawing.Size(44, 44);
            this.buttonSelectedColor.TabIndex = 0;
            this.buttonSelectedColor.UseVisualStyleBackColor = true;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(6, 250);
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
            this.paintCheckBox.Location = new System.Drawing.Point(24, 204);
            this.paintCheckBox.Name = "paintCheckBox";
            this.paintCheckBox.Size = new System.Drawing.Size(144, 29);
            this.paintCheckBox.TabIndex = 5;
            this.paintCheckBox.Text = "Brush down";
            this.paintCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(61, 30);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(63, 58);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "⇧";
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(121, 85);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(63, 58);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "⇨";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(1, 85);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(63, 58);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "⇦";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(61, 140);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(63, 58);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "⇩";
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 544);
            this.panel1.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
    }
}

