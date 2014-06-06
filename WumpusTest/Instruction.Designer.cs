namespace WumpusTest
{
    partial class Instruction
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
            this.background = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = global::WumpusTest.Properties.Resources.starfish;
            this.background.Location = new System.Drawing.Point(-2, 1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(696, 391);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Purple;
            this.title.Location = new System.Drawing.Point(148, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(354, 47);
            this.title.TabIndex = 1;
            this.title.Text = "INSTRUCTIONS!!";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Aqua;
            this.text.Location = new System.Drawing.Point(66, 93);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(78, 29);
            this.text.TabIndex = 2;
            this.text.Text = "label1";
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 389);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Controls.Add(this.background);
            this.Name = "Instruction";
            this.Text = "Instruction";
            this.Load += new System.EventHandler(this.Instruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text;
    }
}