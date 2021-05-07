namespace STS
{
    partial class Map
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
            this.btnStage2 = new System.Windows.Forms.Button();
            this.btnStage1 = new System.Windows.Forms.Button();
            this.btnEndless = new System.Windows.Forms.Button();
            this.btnLowGrind = new System.Windows.Forms.Button();
            this.btnMidGrind = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnStage3 = new System.Windows.Forms.Button();
            this.btnHighGrind = new System.Windows.Forms.Button();
            this.btnFinalBoss = new System.Windows.Forms.Button();
            this.btnHunting = new System.Windows.Forms.Button();
            this.btnMining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStage2
            // 
            this.btnStage2.Enabled = false;
            this.btnStage2.Location = new System.Drawing.Point(217, 107);
            this.btnStage2.Name = "btnStage2";
            this.btnStage2.Size = new System.Drawing.Size(128, 64);
            this.btnStage2.TabIndex = 8;
            this.btnStage2.TabStop = false;
            this.btnStage2.Text = "Forest";
            this.btnStage2.UseVisualStyleBackColor = true;
            this.btnStage2.Click += new System.EventHandler(this.btnStage2_Click);
            // 
            // btnStage1
            // 
            this.btnStage1.Location = new System.Drawing.Point(54, 107);
            this.btnStage1.Name = "btnStage1";
            this.btnStage1.Size = new System.Drawing.Size(128, 64);
            this.btnStage1.TabIndex = 7;
            this.btnStage1.TabStop = false;
            this.btnStage1.Text = "Seabed";
            this.btnStage1.UseVisualStyleBackColor = true;
            this.btnStage1.Click += new System.EventHandler(this.btnStage1_Click);
            // 
            // btnEndless
            // 
            this.btnEndless.Enabled = false;
            this.btnEndless.Location = new System.Drawing.Point(54, 360);
            this.btnEndless.Name = "btnEndless";
            this.btnEndless.Size = new System.Drawing.Size(456, 64);
            this.btnEndless.TabIndex = 9;
            this.btnEndless.TabStop = false;
            this.btnEndless.Text = "Endless";
            this.btnEndless.UseVisualStyleBackColor = true;
            this.btnEndless.Click += new System.EventHandler(this.btnEndless_Click);
            // 
            // btnLowGrind
            // 
            this.btnLowGrind.Location = new System.Drawing.Point(54, 233);
            this.btnLowGrind.Name = "btnLowGrind";
            this.btnLowGrind.Size = new System.Drawing.Size(128, 64);
            this.btnLowGrind.TabIndex = 10;
            this.btnLowGrind.TabStop = false;
            this.btnLowGrind.Text = "LowRank Grind";
            this.btnLowGrind.UseVisualStyleBackColor = true;
            this.btnLowGrind.Click += new System.EventHandler(this.btnLowGrind_Click);
            // 
            // btnMidGrind
            // 
            this.btnMidGrind.Enabled = false;
            this.btnMidGrind.Location = new System.Drawing.Point(217, 233);
            this.btnMidGrind.Name = "btnMidGrind";
            this.btnMidGrind.Size = new System.Drawing.Size(128, 64);
            this.btnMidGrind.TabIndex = 11;
            this.btnMidGrind.TabStop = false;
            this.btnMidGrind.Text = "MidRank Grind";
            this.btnMidGrind.UseVisualStyleBackColor = true;
            this.btnMidGrind.Click += new System.EventHandler(this.btnMidGrind_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::STS.Properties.Resources.Previous;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 72;
            this.btnReturn.TabStop = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnStage3
            // 
            this.btnStage3.Enabled = false;
            this.btnStage3.Location = new System.Drawing.Point(382, 107);
            this.btnStage3.Name = "btnStage3";
            this.btnStage3.Size = new System.Drawing.Size(128, 64);
            this.btnStage3.TabIndex = 73;
            this.btnStage3.TabStop = false;
            this.btnStage3.Text = "Jungle";
            this.btnStage3.UseVisualStyleBackColor = true;
            this.btnStage3.Click += new System.EventHandler(this.btnStage3_Click);
            // 
            // btnHighGrind
            // 
            this.btnHighGrind.Enabled = false;
            this.btnHighGrind.Location = new System.Drawing.Point(382, 233);
            this.btnHighGrind.Name = "btnHighGrind";
            this.btnHighGrind.Size = new System.Drawing.Size(128, 64);
            this.btnHighGrind.TabIndex = 74;
            this.btnHighGrind.TabStop = false;
            this.btnHighGrind.Text = "HighRank Grind";
            this.btnHighGrind.UseVisualStyleBackColor = true;
            this.btnHighGrind.Click += new System.EventHandler(this.btnHighGrind_Click);
            // 
            // btnFinalBoss
            // 
            this.btnFinalBoss.Enabled = false;
            this.btnFinalBoss.Location = new System.Drawing.Point(623, 107);
            this.btnFinalBoss.Name = "btnFinalBoss";
            this.btnFinalBoss.Size = new System.Drawing.Size(148, 317);
            this.btnFinalBoss.TabIndex = 75;
            this.btnFinalBoss.TabStop = false;
            this.btnFinalBoss.Text = "Böss";
            this.btnFinalBoss.UseVisualStyleBackColor = true;
            this.btnFinalBoss.Click += new System.EventHandler(this.btnFinalBoss_Click);
            // 
            // btnHunting
            // 
            this.btnHunting.Location = new System.Drawing.Point(54, 543);
            this.btnHunting.Name = "btnHunting";
            this.btnHunting.Size = new System.Drawing.Size(219, 64);
            this.btnHunting.TabIndex = 76;
            this.btnHunting.TabStop = false;
            this.btnHunting.Text = "Hunting";
            this.btnHunting.UseVisualStyleBackColor = true;
            // 
            // btnMining
            // 
            this.btnMining.Location = new System.Drawing.Point(291, 543);
            this.btnMining.Name = "btnMining";
            this.btnMining.Size = new System.Drawing.Size(219, 64);
            this.btnMining.TabIndex = 77;
            this.btnMining.TabStop = false;
            this.btnMining.Text = "Mining";
            this.btnMining.UseVisualStyleBackColor = true;
            this.btnMining.Click += new System.EventHandler(this.btnMining_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnMining);
            this.Controls.Add(this.btnHunting);
            this.Controls.Add(this.btnFinalBoss);
            this.Controls.Add(this.btnHighGrind);
            this.Controls.Add(this.btnStage3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMidGrind);
            this.Controls.Add(this.btnLowGrind);
            this.Controls.Add(this.btnEndless);
            this.Controls.Add(this.btnStage2);
            this.Controls.Add(this.btnStage1);
            this.Name = "Map";
            this.Text = "Cryptic Dungeons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStage2;
        private System.Windows.Forms.Button btnStage1;
        private System.Windows.Forms.Button btnEndless;
        private System.Windows.Forms.Button btnLowGrind;
        private System.Windows.Forms.Button btnMidGrind;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnStage3;
        private System.Windows.Forms.Button btnHighGrind;
        private System.Windows.Forms.Button btnFinalBoss;
        private System.Windows.Forms.Button btnHunting;
        private System.Windows.Forms.Button btnMining;
    }
}