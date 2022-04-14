namespace HelloCSharp
{
    partial class Calculator
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
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.NumSub = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(31, 278);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(76, 78);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(129, 278);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(76, 78);
            this.NumButton2.TabIndex = 1;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.Window;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumScreen.Location = new System.Drawing.Point(31, 18);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(742, 45);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(650, 179);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(94, 139);
            this.NumPlus.TabIndex = 3;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(228, 278);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(76, 78);
            this.NumButton3.TabIndex = 4;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(31, 179);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(76, 78);
            this.NumButton4.TabIndex = 5;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(228, 179);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(76, 78);
            this.NumButton6.TabIndex = 6;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(129, 179);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(76, 78);
            this.NumButton5.TabIndex = 7;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(31, 81);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(76, 78);
            this.NumButton7.TabIndex = 8;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(129, 81);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(76, 78);
            this.NumButton8.TabIndex = 9;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(228, 81);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(76, 78);
            this.NumButton9.TabIndex = 10;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(129, 370);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(76, 78);
            this.NumButton0.TabIndex = 11;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumSub
            // 
            this.NumSub.Location = new System.Drawing.Point(650, 81);
            this.NumSub.Name = "NumSub";
            this.NumSub.Size = new System.Drawing.Size(94, 78);
            this.NumSub.TabIndex = 12;
            this.NumSub.Text = "-";
            this.NumSub.UseVisualStyleBackColor = true;
            this.NumSub.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(509, 338);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(94, 78);
            this.NumClear.TabIndex = 13;
            this.NumClear.Text = "Clear";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 78);
            this.button1.TabIndex = 14;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 78);
            this.button2.TabIndex = 15;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 78);
            this.button3.TabIndex = 16;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.NumSub);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button NumButton1;
        private Button NumButton2;
        private Label NumScreen;
        private Button NumPlus;
        private Button NumButton3;
        private Button NumButton4;
        private Button NumButton6;
        private Button NumButton5;
        private Button NumButton7;
        private Button NumButton8;
        private Button NumButton9;
        private Button NumButton0;
        private Button NumSub;
        private Button NumClear;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}