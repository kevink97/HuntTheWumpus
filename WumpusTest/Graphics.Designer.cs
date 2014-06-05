namespace WumpusTest
{
    partial class InGame
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
            this.buyArrows = new System.Windows.Forms.Button();
            this.arrowCount = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gold = new System.Windows.Forms.Label();
            this.CurrentRoomNum = new System.Windows.Forms.Label();
            this.cavet1 = new System.Windows.Forms.Label();
            this.cavet2 = new System.Windows.Forms.Label();
            this.cavet3 = new System.Windows.Forms.Label();
            this.arrowt1 = new System.Windows.Forms.Label();
            this.arrowt2 = new System.Windows.Forms.Label();
            this.arrowt3 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // buyArrows
            // 
            this.buyArrows.Location = new System.Drawing.Point(193, 6);
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
            this.arrowCount.BackColor = System.Drawing.Color.Transparent;
            this.arrowCount.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowCount.ForeColor = System.Drawing.Color.White;
            this.arrowCount.Location = new System.Drawing.Point(45, 9);
            this.arrowCount.Name = "arrowCount";
            this.arrowCount.Size = new System.Drawing.Size(49, 23);
            this.arrowCount.TabIndex = 22;
            this.arrowCount.Text = "temp";
            this.arrowCount.Click += new System.EventHandler(this.arrowCount_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(686, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(56, 23);
            this.score.TabIndex = 23;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold.ForeColor = System.Drawing.Color.White;
            this.gold.Location = new System.Drawing.Point(401, 12);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(47, 23);
            this.gold.TabIndex = 24;
            this.gold.Text = "Gold";
            this.gold.Click += new System.EventHandler(this.gold_Click);
            // 
            // CurrentRoomNum
            // 
            this.CurrentRoomNum.AutoSize = true;
            this.CurrentRoomNum.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRoomNum.ForeColor = System.Drawing.Color.White;
            this.CurrentRoomNum.Location = new System.Drawing.Point(446, 530);
            this.CurrentRoomNum.Name = "CurrentRoomNum";
            this.CurrentRoomNum.Size = new System.Drawing.Size(124, 23);
            this.CurrentRoomNum.TabIndex = 26;
            this.CurrentRoomNum.Text = "Current Room";
            this.CurrentRoomNum.Click += new System.EventHandler(this.CurrentRoomNum_Click);
            // 
            // cavet1
            // 
            this.cavet1.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cavet1.ForeColor = System.Drawing.Color.Snow;
            this.cavet1.Location = new System.Drawing.Point(12, 143);
            this.cavet1.Name = "cavet1";
            this.cavet1.Size = new System.Drawing.Size(159, 147);
            this.cavet1.TabIndex = 27;
            this.cavet1.Text = "Template1";
            this.cavet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cavet1.Click += new System.EventHandler(this.cavet1_Click);
            // 
            // cavet2
            // 
            this.cavet2.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cavet2.ForeColor = System.Drawing.Color.Snow;
            this.cavet2.Location = new System.Drawing.Point(273, 143);
            this.cavet2.Name = "cavet2";
            this.cavet2.Size = new System.Drawing.Size(126, 128);
            this.cavet2.TabIndex = 28;
            this.cavet2.Text = "Template2";
            this.cavet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cavet2.Click += new System.EventHandler(this.cavet2_Click);
            // 
            // cavet3
            // 
            this.cavet3.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cavet3.ForeColor = System.Drawing.Color.Snow;
            this.cavet3.Location = new System.Drawing.Point(578, 126);
            this.cavet3.Name = "cavet3";
            this.cavet3.Size = new System.Drawing.Size(150, 145);
            this.cavet3.TabIndex = 29;
            this.cavet3.Text = "Template3";
            this.cavet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cavet3.Click += new System.EventHandler(this.cavet3_Click);
            // 
            // arrowt1
            // 
            this.arrowt1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowt1.ForeColor = System.Drawing.Color.DeepPink;
            this.arrowt1.Location = new System.Drawing.Point(12, 310);
            this.arrowt1.Name = "arrowt1";
            this.arrowt1.Size = new System.Drawing.Size(159, 87);
            this.arrowt1.TabIndex = 30;
            this.arrowt1.Text = "arrow1";
            this.arrowt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arrowt1.Click += new System.EventHandler(this.arrowt1_Click);
            // 
            // arrowt2
            // 
            this.arrowt2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowt2.ForeColor = System.Drawing.Color.DeepPink;
            this.arrowt2.Location = new System.Drawing.Point(258, 285);
            this.arrowt2.Name = "arrowt2";
            this.arrowt2.Size = new System.Drawing.Size(157, 99);
            this.arrowt2.TabIndex = 31;
            this.arrowt2.Text = "arrow1";
            this.arrowt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arrowt2.Click += new System.EventHandler(this.arrowt2_Click);
            // 
            // arrowt3
            // 
            this.arrowt3.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowt3.ForeColor = System.Drawing.Color.DeepPink;
            this.arrowt3.Location = new System.Drawing.Point(559, 285);
            this.arrowt3.Name = "arrowt3";
            this.arrowt3.Size = new System.Drawing.Size(169, 88);
            this.arrowt3.TabIndex = 32;
            this.arrowt3.Text = "arrow1";
            this.arrowt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arrowt3.Click += new System.EventHandler(this.arrowt3_Click);
            // 
            // background
            // 
            this.background.Image = global::WumpusTest.Properties.Resources.underwaterCaves2;
            this.background.Location = new System.Drawing.Point(1, -3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(785, 571);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 14;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 562);
            this.Controls.Add(this.arrowt3);
            this.Controls.Add(this.arrowt2);
            this.Controls.Add(this.arrowt1);
            this.Controls.Add(this.cavet3);
            this.Controls.Add(this.cavet2);
            this.Controls.Add(this.cavet1);
            this.Controls.Add(this.CurrentRoomNum);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.score);
            this.Controls.Add(this.arrowCount);
            this.Controls.Add(this.buyArrows);
            this.Controls.Add(this.background);
            this.Name = "InGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Graphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button buyArrows;
        private System.Windows.Forms.Label arrowCount;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gold;
        private System.Windows.Forms.Label CurrentRoomNum;
        private System.Windows.Forms.Label cavet1;
        private System.Windows.Forms.Label cavet2;
        private System.Windows.Forms.Label cavet3;
        private System.Windows.Forms.Label arrowt1;
        private System.Windows.Forms.Label arrowt2;
        private System.Windows.Forms.Label arrowt3;
    }
}