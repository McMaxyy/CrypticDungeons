namespace STS
{
    partial class Shop
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuyIronS = new System.Windows.Forms.Button();
            this.btnBuyIronA = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPickleS = new System.Windows.Forms.PictureBox();
            this.lblIronS = new System.Windows.Forms.Label();
            this.lblIronA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickleS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Available Items:";
            // 
            // btnBuyIronS
            // 
            this.btnBuyIronS.Enabled = false;
            this.btnBuyIronS.Location = new System.Drawing.Point(184, 197);
            this.btnBuyIronS.Name = "btnBuyIronS";
            this.btnBuyIronS.Size = new System.Drawing.Size(40, 23);
            this.btnBuyIronS.TabIndex = 15;
            this.btnBuyIronS.Tag = "Buy";
            this.btnBuyIronS.Text = "Buy";
            this.btnBuyIronS.UseVisualStyleBackColor = true;
            this.btnBuyIronS.Click += new System.EventHandler(this.btnBuyIronS_Click);
            // 
            // btnBuyIronA
            // 
            this.btnBuyIronA.Enabled = false;
            this.btnBuyIronA.Location = new System.Drawing.Point(184, 356);
            this.btnBuyIronA.Name = "btnBuyIronA";
            this.btnBuyIronA.Size = new System.Drawing.Size(40, 23);
            this.btnBuyIronA.TabIndex = 16;
            this.btnBuyIronA.Tag = "Buy";
            this.btnBuyIronA.Text = "Buy";
            this.btnBuyIronA.UseVisualStyleBackColor = true;
            this.btnBuyIronA.Click += new System.EventHandler(this.btnBuyIronA_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoins.Location = new System.Drawing.Point(21, 565);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(124, 17);
            this.lblCoins.TabIndex = 17;
            this.lblCoins.Text = "Available Coins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(96, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Iron Sword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(93, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Iron Armor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BackgroundImage = global::STS.Properties.Resources.IronArmor_Equip;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(96, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 96);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pbPickleS
            // 
            this.pbPickleS.BackgroundImage = global::STS.Properties.Resources.IronSword;
            this.pbPickleS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPickleS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPickleS.Location = new System.Drawing.Point(96, 136);
            this.pbPickleS.Name = "pbPickleS";
            this.pbPickleS.Size = new System.Drawing.Size(82, 84);
            this.pbPickleS.TabIndex = 12;
            this.pbPickleS.TabStop = false;
            // 
            // lblIronS
            // 
            this.lblIronS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIronS.Location = new System.Drawing.Point(184, 163);
            this.lblIronS.Name = "lblIronS";
            this.lblIronS.Size = new System.Drawing.Size(100, 31);
            this.lblIronS.TabIndex = 30;
            this.lblIronS.Text = "Coins:\r\nIron Ore:";
            // 
            // lblIronA
            // 
            this.lblIronA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIronA.Location = new System.Drawing.Point(184, 322);
            this.lblIronA.Name = "lblIronA";
            this.lblIronA.Size = new System.Drawing.Size(100, 31);
            this.lblIronA.TabIndex = 31;
            this.lblIronA.Text = "Coins: \r\nIron Ore:";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.lblIronA);
            this.Controls.Add(this.lblIronS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnBuyIronA);
            this.Controls.Add(this.btnBuyIronS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPickleS);
            this.Controls.Add(this.btnReturn);
            this.Name = "Shop";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickleS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbPickleS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyIronS;
        private System.Windows.Forms.Button btnBuyIronA;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIronS;
        private System.Windows.Forms.Label lblIronA;
    }
}