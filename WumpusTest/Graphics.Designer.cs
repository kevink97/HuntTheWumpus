namespace WumpusTest
{
    partial class Graphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphics));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.bat = new System.Windows.Forms.PictureBox();
            this.buyArrows = new System.Windows.Forms.Button();
            this.arrowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(618, 571);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(497, 260);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 15;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(257, 527);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(257, 12);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 23);
            this.forward.TabIndex = 18;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(12, 260);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 19;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            // 
            // bat
            // 
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(95, 127);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(396, 298);
            this.bat.TabIndex = 20;
            this.bat.TabStop = false;
            this.bat.Click += new System.EventHandler(this.bat_Click);
            // 
            // buyArrows
            // 
            this.buyArrows.Location = new System.Drawing.Point(76, 9);
            this.buyArrows.Name = "buyArrows";
            this.buyArrows.Size = new System.Drawing.Size(75, 23);
            this.buyArrows.TabIndex = 21;
            this.buyArrows.Text = "Buy Arrows";
            this.buyArrows.UseVisualStyleBackColor = true;
            this.buyArrows.Click += new System.EventHandler(this.buyArrows_Click);
            // 
            // arrowCount
            // 
            this.arrowCount.AutoSize = true;
            this.arrowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowCount.Location = new System.Drawing.Point(8, 9);
            this.arrowCount.Name = "arrowCount";
            this.arrowCount.Size = new System.Drawing.Size(62, 20);
            this.arrowCount.TabIndex = 22;
            this.arrowCount.Text = "Arrows:";
            this.arrowCount.Click += new System.EventHandler(this.arrowCount_Click);
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.arrowCount);
            this.Controls.Add(this.buyArrows);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.left);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.right);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Graphics";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Graphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.Button buyArrows;
        private System.Windows.Forms.Label arrowCount;
    }
}