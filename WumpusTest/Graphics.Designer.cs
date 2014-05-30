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
            this.cave2 = new System.Windows.Forms.Button();
            this.cave3 = new System.Windows.Forms.Button();
            this.cave1 = new System.Windows.Forms.Button();
            this.bat = new System.Windows.Forms.PictureBox();
            this.buyArrows = new System.Windows.Forms.Button();
            this.arrowCount = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gold = new System.Windows.Forms.Label();
            this.pit = new System.Windows.Forms.PictureBox();
            this.CurrentRoomNum = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.wumpus = new System.Windows.Forms.PictureBox();
            this.shootArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wumpus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(618, 571);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // cave2
            // 
            this.cave2.Location = new System.Drawing.Point(224, 53);
            this.cave2.Name = "cave2";
            this.cave2.Size = new System.Drawing.Size(150, 150);
            this.cave2.TabIndex = 15;
            this.cave2.UseVisualStyleBackColor = true;
            this.cave2.Click += new System.EventHandler(this.cave2_Click);
            // 
            // cave3
            // 
            this.cave3.Location = new System.Drawing.Point(405, 53);
            this.cave3.Name = "cave3";
            this.cave3.Size = new System.Drawing.Size(150, 150);
            this.cave3.TabIndex = 17;
            this.cave3.UseVisualStyleBackColor = true;
            this.cave3.Click += new System.EventHandler(this.cave3_Click);
            // 
            // cave1
            // 
            this.cave1.Location = new System.Drawing.Point(49, 53);
            this.cave1.Name = "cave1";
            this.cave1.Size = new System.Drawing.Size(150, 150);
            this.cave1.TabIndex = 18;
            this.cave1.UseVisualStyleBackColor = true;
            this.cave1.Click += new System.EventHandler(this.cave1_Click_1);
            // 
            // bat
            // 
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(96, 209);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(396, 298);
            this.bat.TabIndex = 20;
            this.bat.TabStop = false;
            this.bat.Visible = false;
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
            this.arrowCount.Size = new System.Drawing.Size(45, 20);
            this.arrowCount.TabIndex = 22;
            this.arrowCount.Text = "temp";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(527, 12);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(51, 20);
            this.score.TabIndex = 23;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold.Location = new System.Drawing.Point(401, 12);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(43, 20);
            this.gold.TabIndex = 24;
            this.gold.Text = "Gold";
            this.gold.Click += new System.EventHandler(this.gold_Click);
            // 
            // pit
            // 
            this.pit.Image = ((System.Drawing.Image)(resources.GetObject("pit.Image")));
            this.pit.Location = new System.Drawing.Point(-574, 391);
            this.pit.Name = "pit";
            this.pit.Size = new System.Drawing.Size(646, 619);
            this.pit.TabIndex = 25;
            this.pit.TabStop = false;
            this.pit.Visible = false;
            this.pit.Click += new System.EventHandler(this.pit_Click);
            // 
            // CurrentRoomNum
            // 
            this.CurrentRoomNum.AutoSize = true;
            this.CurrentRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRoomNum.Location = new System.Drawing.Point(469, 533);
            this.CurrentRoomNum.Name = "CurrentRoomNum";
            this.CurrentRoomNum.Size = new System.Drawing.Size(109, 20);
            this.CurrentRoomNum.TabIndex = 26;
            this.CurrentRoomNum.Text = "Current Room";
            this.CurrentRoomNum.Click += new System.EventHandler(this.CurrentRoomNum_Click);
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(175, 209);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(269, 341);
            this.player.TabIndex = 27;
            this.player.TabStop = false;
            // 
            // wumpus
            // 
            this.wumpus.Image = ((System.Drawing.Image)(resources.GetObject("wumpus.Image")));
            this.wumpus.Location = new System.Drawing.Point(106, 209);
            this.wumpus.Name = "wumpus";
            this.wumpus.Size = new System.Drawing.Size(397, 308);
            this.wumpus.TabIndex = 28;
            this.wumpus.TabStop = false;
            this.wumpus.Visible = false;
            this.wumpus.Click += new System.EventHandler(this.wumpus_Click);
            // 
            // shootArrow
            // 
            this.shootArrow.Location = new System.Drawing.Point(175, 9);
            this.shootArrow.Name = "shootArrow";
            this.shootArrow.Size = new System.Drawing.Size(75, 23);
            this.shootArrow.TabIndex = 29;
            this.shootArrow.Text = "Shoot Arrows";
            this.shootArrow.UseVisualStyleBackColor = true;
            this.shootArrow.Click += new System.EventHandler(this.shootArrow_Click);
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.shootArrow);
            this.Controls.Add(this.wumpus);
            this.Controls.Add(this.player);
            this.Controls.Add(this.CurrentRoomNum);
            this.Controls.Add(this.pit);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.score);
            this.Controls.Add(this.arrowCount);
            this.Controls.Add(this.buyArrows);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.cave1);
            this.Controls.Add(this.cave3);
            this.Controls.Add(this.cave2);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Graphics";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Graphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wumpus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button cave2;
        private System.Windows.Forms.Button cave3;
        private System.Windows.Forms.Button cave1;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.Button buyArrows;
        private System.Windows.Forms.Label arrowCount;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gold;
        private System.Windows.Forms.PictureBox pit;
        private System.Windows.Forms.Label CurrentRoomNum;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox wumpus;
        private System.Windows.Forms.Button shootArrow;
    }
}