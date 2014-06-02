using System;

namespace WumpusTest
{
    partial class TriviaForm1
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
            Random rc = new Random();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button1.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button2.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button3.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button4.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button4.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button5.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button5.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(163, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button6.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button6.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 61);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button7.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button7.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(88, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 61);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button8.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button8.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 61);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            if (rc.Next(0, 2) == 1)
            {
                this.button9.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.button9.ForeColor = System.Drawing.Color.Blue;
            }
            // 
            // TriviaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "TriviaForm1";
            this.Text = "Trivia";
            this.ResumeLayout(false);

        }

        void button1_Click(object sender, System.EventArgs e)
        {
            if (button1.ForeColor == System.Drawing.Color.Red)
            {
                button1.ForeColor = System.Drawing.Color.Blue;
                if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                else if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
                else if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
            }
            else
                button1.ForeColor = System.Drawing.Color.Red;
            if (button1.ForeColor == System.Drawing.Color.Red)
            {
                if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                else if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
                else if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
            }
        }
        void button2_Click(object sender, System.EventArgs e)
        {
            if (button2.ForeColor == System.Drawing.Color.Red)
            {
                button2.ForeColor = System.Drawing.Color.Blue;
                if (button1.ForeColor == System.Drawing.Color.Red)
                    button1.ForeColor = System.Drawing.Color.Blue;
                else if (button1.ForeColor == System.Drawing.Color.Blue)
                    button1.ForeColor = System.Drawing.Color.Red;
                if (button3.ForeColor == System.Drawing.Color.Red)
                    button3.ForeColor = System.Drawing.Color.Blue;
                else if (button3.ForeColor == System.Drawing.Color.Blue)
                    button3.ForeColor = System.Drawing.Color.Red;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
            else
                button2.ForeColor = System.Drawing.Color.Red;
            if (button2.ForeColor == System.Drawing.Color.Red)
            {
                if (button1.ForeColor == System.Drawing.Color.Blue)
                    button1.ForeColor = System.Drawing.Color.Red;
                else if (button1.ForeColor == System.Drawing.Color.Red)
                    button1.ForeColor = System.Drawing.Color.Blue;
                if (button3.ForeColor == System.Drawing.Color.Blue)
                    button3.ForeColor = System.Drawing.Color.Red;
                else if (button3.ForeColor == System.Drawing.Color.Red)
                    button3.ForeColor = System.Drawing.Color.Blue;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
        }
        void button3_Click(object sender, System.EventArgs e)
        {
            if (button3.ForeColor == System.Drawing.Color.Red)
            {
                button3.ForeColor = System.Drawing.Color.Blue;
                if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                else if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
                else if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
            }
            else
                button3.ForeColor = System.Drawing.Color.Red;
            if (button3.ForeColor == System.Drawing.Color.Red)
            {
                if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                else if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
                else if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
            }
        }
        void button4_Click(object sender, System.EventArgs e)
        {
            if (button4.ForeColor == System.Drawing.Color.Red)
            {
                button4.ForeColor = System.Drawing.Color.Blue;
                if (button1.ForeColor == System.Drawing.Color.Red)
                    button1.ForeColor = System.Drawing.Color.Blue;
                else if (button1.ForeColor == System.Drawing.Color.Blue)
                    button1.ForeColor = System.Drawing.Color.Red;
                if (button7.ForeColor == System.Drawing.Color.Red)
                    button7.ForeColor = System.Drawing.Color.Blue;
                else if (button7.ForeColor == System.Drawing.Color.Blue)
                    button7.ForeColor = System.Drawing.Color.Red;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
            else
                button4.ForeColor = System.Drawing.Color.Red;
            if (button4.ForeColor == System.Drawing.Color.Red)
            {
                if (button1.ForeColor == System.Drawing.Color.Blue)
                    button1.ForeColor = System.Drawing.Color.Red;
                else if (button1.ForeColor == System.Drawing.Color.Red)
                    button1.ForeColor = System.Drawing.Color.Blue;
                if (button7.ForeColor == System.Drawing.Color.Blue)
                    button7.ForeColor = System.Drawing.Color.Red;
                else if (button7.ForeColor == System.Drawing.Color.Red)
                    button7.ForeColor = System.Drawing.Color.Blue;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
        }
        void button5_Click(object sender, System.EventArgs e)
        {
            if (button5.ForeColor == System.Drawing.Color.Red)
            {
                button5.ForeColor = System.Drawing.Color.Blue;
                if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                else if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
                else if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
                if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
                else if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
                if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
                else if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
            }
            else
                button5.ForeColor = System.Drawing.Color.Red;
            if (button5.ForeColor == System.Drawing.Color.Red)
            {
                if (button2.ForeColor == System.Drawing.Color.Blue)
                    button2.ForeColor = System.Drawing.Color.Red;
                else if (button2.ForeColor == System.Drawing.Color.Red)
                    button2.ForeColor = System.Drawing.Color.Blue;
                if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
                else if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
                if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
                else if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
                if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
                else if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
            }
        }
        void button6_Click(object sender, System.EventArgs e)
        {
            if (button6.ForeColor == System.Drawing.Color.Red)
            {
                button6.ForeColor = System.Drawing.Color.Blue;
                if (button3.ForeColor == System.Drawing.Color.Red)
                    button3.ForeColor = System.Drawing.Color.Blue;
                else if (button3.ForeColor == System.Drawing.Color.Blue)
                    button3.ForeColor = System.Drawing.Color.Red;
                if (button9.ForeColor == System.Drawing.Color.Red)
                    button9.ForeColor = System.Drawing.Color.Blue;
                else if (button9.ForeColor == System.Drawing.Color.Blue)
                    button9.ForeColor = System.Drawing.Color.Red;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
            else
                button6.ForeColor = System.Drawing.Color.Red;
            if (button6.ForeColor == System.Drawing.Color.Red)
            {
                if (button3.ForeColor == System.Drawing.Color.Blue)
                    button3.ForeColor = System.Drawing.Color.Red;
                else if (button3.ForeColor == System.Drawing.Color.Red)
                    button3.ForeColor = System.Drawing.Color.Blue;
                if (button9.ForeColor == System.Drawing.Color.Blue)
                    button9.ForeColor = System.Drawing.Color.Red;
                else if (button9.ForeColor == System.Drawing.Color.Red)
                    button9.ForeColor = System.Drawing.Color.Blue;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
        }
        void button7_Click(object sender, System.EventArgs e)
        {
            if (button7.ForeColor == System.Drawing.Color.Red)
            {
                button7.ForeColor = System.Drawing.Color.Blue;
                if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
                else if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
                if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
                else if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
            }
            else
                button7.ForeColor = System.Drawing.Color.Red;
            if (button7.ForeColor == System.Drawing.Color.Red)
            {
                if (button4.ForeColor == System.Drawing.Color.Blue)
                    button4.ForeColor = System.Drawing.Color.Red;
                else if (button4.ForeColor == System.Drawing.Color.Red)
                    button4.ForeColor = System.Drawing.Color.Blue;
                if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
                else if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
            }
        }
        void button8_Click(object sender, System.EventArgs e)
        {
            if (button8.ForeColor == System.Drawing.Color.Red)
            {
                button8.ForeColor = System.Drawing.Color.Blue;
                if (button9.ForeColor == System.Drawing.Color.Red)
                    button9.ForeColor = System.Drawing.Color.Blue;
                else if (button9.ForeColor == System.Drawing.Color.Blue)
                    button9.ForeColor = System.Drawing.Color.Red;
                if (button7.ForeColor == System.Drawing.Color.Red)
                    button7.ForeColor = System.Drawing.Color.Blue;
                else if (button7.ForeColor == System.Drawing.Color.Blue)
                    button7.ForeColor = System.Drawing.Color.Red;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
            else
                button8.ForeColor = System.Drawing.Color.Red;
            if (button8.ForeColor == System.Drawing.Color.Red)
            {
                if (button9.ForeColor == System.Drawing.Color.Blue)
                    button9.ForeColor = System.Drawing.Color.Red;
                else if (button9.ForeColor == System.Drawing.Color.Red)
                    button9.ForeColor = System.Drawing.Color.Blue;
                if (button7.ForeColor == System.Drawing.Color.Blue)
                    button7.ForeColor = System.Drawing.Color.Red;
                else if (button7.ForeColor == System.Drawing.Color.Red)
                    button7.ForeColor = System.Drawing.Color.Blue;
                if (button5.ForeColor == System.Drawing.Color.Red)
                    button5.ForeColor = System.Drawing.Color.Blue;
                else if (button5.ForeColor == System.Drawing.Color.Blue)
                    button5.ForeColor = System.Drawing.Color.Red;
            }
        }
        void button9_Click(object sender, System.EventArgs e)
        {
            if (button9.ForeColor == System.Drawing.Color.Red)
            {
                button9.ForeColor = System.Drawing.Color.Blue;
                if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
                else if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
                if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
                else if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
            }
            else
                button9.ForeColor = System.Drawing.Color.Red;
            if (button9.ForeColor == System.Drawing.Color.Red)
            {
                if (button6.ForeColor == System.Drawing.Color.Blue)
                    button6.ForeColor = System.Drawing.Color.Red;
                else if (button6.ForeColor == System.Drawing.Color.Red)
                    button6.ForeColor = System.Drawing.Color.Blue;
                if (button8.ForeColor == System.Drawing.Color.Blue)
                    button8.ForeColor = System.Drawing.Color.Red;
                else if (button8.ForeColor == System.Drawing.Color.Red)
                    button8.ForeColor = System.Drawing.Color.Blue;
            }
        }

        public bool isAllBlue()
        {
            if (button1.ForeColor == System.Drawing.Color.Blue && button2.ForeColor == System.Drawing.Color.Blue && button3.ForeColor == System.Drawing.Color.Blue && button4.ForeColor == System.Drawing.Color.Blue && button5.ForeColor == System.Drawing.Color.Blue && button6.ForeColor == System.Drawing.Color.Blue && button7.ForeColor == System.Drawing.Color.Blue && button8.ForeColor == System.Drawing.Color.Blue && button9.ForeColor == System.Drawing.Color.Blue)
            {
                return true;
            }
            return false;
        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

