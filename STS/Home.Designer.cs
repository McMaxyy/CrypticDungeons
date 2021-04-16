namespace STS
{
    partial class Home
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
            this.btnWS = new System.Windows.Forms.Button();
            this.btnIS = new System.Windows.Forms.Button();
            this.btnIA = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnPS = new System.Windows.Forms.Button();
            this.btnCraft = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGS = new System.Windows.Forms.Button();
            this.btnGA = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWS
            // 
            this.btnWS.Location = new System.Drawing.Point(569, 464);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(60, 54);
            this.btnWS.TabIndex = 1;
            this.btnWS.TabStop = false;
            this.btnWS.Tag = "Equipment";
            this.btnWS.Text = "Wooden Sword";
            this.btnWS.UseVisualStyleBackColor = true;
            this.btnWS.Visible = false;
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            // 
            // btnIS
            // 
            this.btnIS.Enabled = false;
            this.btnIS.Location = new System.Drawing.Point(635, 464);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(60, 54);
            this.btnIS.TabIndex = 2;
            this.btnIS.TabStop = false;
            this.btnIS.Tag = "Equipment";
            this.btnIS.Text = "Iron Sword";
            this.btnIS.UseVisualStyleBackColor = true;
            this.btnIS.Visible = false;
            this.btnIS.Click += new System.EventHandler(this.btnIS_Click);
            // 
            // btnIA
            // 
            this.btnIA.Enabled = false;
            this.btnIA.Location = new System.Drawing.Point(635, 524);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(60, 54);
            this.btnIA.TabIndex = 5;
            this.btnIA.TabStop = false;
            this.btnIA.Tag = "Equipment";
            this.btnIA.Text = "Iron Armor";
            this.btnIA.UseVisualStyleBackColor = true;
            this.btnIA.Visible = false;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            // 
            // btnBA
            // 
            this.btnBA.Location = new System.Drawing.Point(569, 524);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(60, 54);
            this.btnBA.TabIndex = 4;
            this.btnBA.TabStop = false;
            this.btnBA.Tag = "Equipment";
            this.btnBA.Text = "Bronze Armor";
            this.btnBA.UseVisualStyleBackColor = true;
            this.btnBA.Visible = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // lblItems
            // 
            this.lblItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(617, 130);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(192, 206);
            this.lblItems.TabIndex = 9;
            this.lblItems.Visible = false;
            // 
            // btnPS
            // 
            this.btnPS.Enabled = false;
            this.btnPS.Location = new System.Drawing.Point(701, 464);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(60, 54);
            this.btnPS.TabIndex = 11;
            this.btnPS.TabStop = false;
            this.btnPS.Tag = "Equipment";
            this.btnPS.Text = "Pickle Sword";
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Visible = false;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // btnCraft
            // 
            this.btnCraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCraft.Location = new System.Drawing.Point(27, 495);
            this.btnCraft.Name = "btnCraft";
            this.btnCraft.Size = new System.Drawing.Size(188, 83);
            this.btnCraft.TabIndex = 12;
            this.btnCraft.TabStop = false;
            this.btnCraft.Text = "Smithy";
            this.btnCraft.UseVisualStyleBackColor = true;
            this.btnCraft.Click += new System.EventHandler(this.btnCraft_Click);
            // 
            // btnPA
            // 
            this.btnPA.Enabled = false;
            this.btnPA.Location = new System.Drawing.Point(701, 524);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(60, 54);
            this.btnPA.TabIndex = 13;
            this.btnPA.TabStop = false;
            this.btnPA.Tag = "Equipment";
            this.btnPA.Text = "Pickle Armor";
            this.btnPA.UseVisualStyleBackColor = true;
            this.btnPA.Visible = false;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(27, 366);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(188, 83);
            this.btnShop.TabIndex = 14;
            this.btnShop.TabStop = false;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(649, 400);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(132, 49);
            this.btnEquipment.TabIndex = 15;
            this.btnEquipment.TabStop = false;
            this.btnEquipment.Text = "Show Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(649, 51);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(132, 49);
            this.btnInventory.TabIndex = 16;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Show Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(614, 113);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(124, 17);
            this.lblCoins.TabIndex = 18;
            this.lblCoins.Text = "Available Coins:";
            this.lblCoins.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Transparent;
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(27, 239);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(188, 83);
            this.btnMap.TabIndex = 20;
            this.btnMap.TabStop = false;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(292, 102);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 17);
            this.lblLevel.TabIndex = 22;
            this.lblLevel.Text = "Level:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(292, 119);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(34, 17);
            this.lblHP.TabIndex = 23;
            this.lblHP.Text = "HP:";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(292, 136);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(55, 17);
            this.lblStats.TabIndex = 24;
            this.lblStats.Text = "Stats: ";
            // 
            // pbSword
            // 
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSword.Location = new System.Drawing.Point(305, 186);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(51, 77);
            this.pbSword.TabIndex = 8;
            this.pbSword.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(313, 185);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(225, 264);
            this.pbPlayer.TabIndex = 7;
            this.pbPlayer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(295, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 300);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnGS
            // 
            this.btnGS.Enabled = false;
            this.btnGS.Location = new System.Drawing.Point(767, 464);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(60, 54);
            this.btnGS.TabIndex = 25;
            this.btnGS.TabStop = false;
            this.btnGS.Tag = "Equipment";
            this.btnGS.Text = "Goblin Sword";
            this.btnGS.UseVisualStyleBackColor = true;
            this.btnGS.Visible = false;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            // 
            // btnGA
            // 
            this.btnGA.Enabled = false;
            this.btnGA.Location = new System.Drawing.Point(767, 524);
            this.btnGA.Name = "btnGA";
            this.btnGA.Size = new System.Drawing.Size(60, 54);
            this.btnGA.TabIndex = 26;
            this.btnGA.TabStop = false;
            this.btnGA.Tag = "Equipment";
            this.btnGA.Text = "Goblin Armor";
            this.btnGA.UseVisualStyleBackColor = true;
            this.btnGA.Visible = false;
            this.btnGA.Click += new System.EventHandler(this.btnGA_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnGA);
            this.Controls.Add(this.btnGS);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnEquipment);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnPA);
            this.Controls.Add(this.btnCraft);
            this.Controls.Add(this.btnPS);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnIA);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.btnWS);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Cryptic Dungeons";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnIS;
        private System.Windows.Forms.Button btnIA;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnPS;
        private System.Windows.Forms.Button btnCraft;
        private System.Windows.Forms.Button btnPA;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Button btnGA;
    }
}