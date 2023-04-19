namespace Lekcja18___WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelA = new Label();
            InputA = new NumericUpDown();
            InputB = new NumericUpDown();
            labelB = new Label();
            InputC = new NumericUpDown();
            labelC = new Label();
            triangleA = new Label();
            triangleC = new Label();
            triangleB = new Label();
            Calculate = new Button();
            Ob = new Label();
            P = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputC).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.triangle;
            pictureBox1.Location = new Point(351, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(12, 12);
            labelA.Name = "labelA";
            labelA.Size = new Size(31, 20);
            labelA.TabIndex = 1;
            labelA.Text = "a =";
            // 
            // InputA
            // 
            InputA.Location = new Point(49, 10);
            InputA.Name = "InputA";
            InputA.Size = new Size(150, 27);
            InputA.TabIndex = 3;
            // 
            // InputB
            // 
            InputB.Location = new Point(49, 43);
            InputB.Name = "InputB";
            InputB.Size = new Size(150, 27);
            InputB.TabIndex = 5;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(12, 45);
            labelB.Name = "labelB";
            labelB.Size = new Size(32, 20);
            labelB.TabIndex = 4;
            labelB.Text = "b =";
            // 
            // InputC
            // 
            InputC.Location = new Point(49, 76);
            InputC.Name = "InputC";
            InputC.Size = new Size(150, 27);
            InputC.TabIndex = 7;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(12, 78);
            labelC.Name = "labelC";
            labelC.Size = new Size(30, 20);
            labelC.TabIndex = 6;
            labelC.Text = "c =";
            // 
            // triangleA
            // 
            triangleA.AutoSize = true;
            triangleA.Location = new Point(365, 83);
            triangleA.Name = "triangleA";
            triangleA.Size = new Size(31, 20);
            triangleA.TabIndex = 8;
            triangleA.Text = "a =";
            // 
            // triangleC
            // 
            triangleC.AutoSize = true;
            triangleC.Location = new Point(572, 120);
            triangleC.Name = "triangleC";
            triangleC.Size = new Size(30, 20);
            triangleC.TabIndex = 9;
            triangleC.Text = "c =";
            // 
            // triangleB
            // 
            triangleB.AutoSize = true;
            triangleB.Location = new Point(464, 298);
            triangleB.Name = "triangleB";
            triangleB.Size = new Size(32, 20);
            triangleB.TabIndex = 10;
            triangleB.Text = "b =";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(12, 116);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(187, 29);
            Calculate.TabIndex = 11;
            Calculate.Text = "Oblicz";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Ob
            // 
            Ob.AutoSize = true;
            Ob.Location = new Point(225, 31);
            Ob.Name = "Ob";
            Ob.Size = new Size(43, 20);
            Ob.TabIndex = 12;
            Ob.Text = "Ob =";
            // 
            // P
            // 
            P.AutoSize = true;
            P.Location = new Point(225, 60);
            P.Name = "P";
            P.Size = new Size(31, 20);
            P.TabIndex = 13;
            P.Text = "P =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(P);
            Controls.Add(Ob);
            Controls.Add(Calculate);
            Controls.Add(triangleB);
            Controls.Add(triangleC);
            Controls.Add(triangleA);
            Controls.Add(InputC);
            Controls.Add(labelC);
            Controls.Add(InputB);
            Controls.Add(labelB);
            Controls.Add(InputA);
            Controls.Add(labelA);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputA).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputB).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelA;
        private NumericUpDown InputA;
        private NumericUpDown InputB;
        private Label labelB;
        private NumericUpDown InputC;
        private Label labelC;
        private Label triangleA;
        private Label triangleC;
        private Label triangleB;
        private Button Calculate;
        private Label Ob;
        private Label P;
    }
}