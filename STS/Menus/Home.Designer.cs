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
            this.btnPA = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnGS = new System.Windows.Forms.Button();
            this.btnGA = new System.Windows.Forms.Button();
            this.btnMA = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCraft = new System.Windows.Forms.Button();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnCook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWS
            // 
            this.btnWS.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWS.BackgroundImage = global::STS.Properties.Resources.WoodenSword;
            this.btnWS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWS.Location = new System.Drawing.Point(617, 443);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(60, 54);
            this.btnWS.TabIndex = 1;
            this.btnWS.TabStop = false;
            this.btnWS.Tag = "Equipment1";
            this.btnWS.UseVisualStyleBackColor = false;
            this.btnWS.Visible = false;
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            this.btnWS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnIS
            // 
            this.btnIS.BackColor = System.Drawing.Color.DimGray;
            this.btnIS.BackgroundImage = global::STS.Properties.Resources.IronSword;
            this.btnIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIS.Enabled = false;
            this.btnIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIS.Location = new System.Drawing.Point(683, 443);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(60, 54);
            this.btnIS.TabIndex = 2;
            this.btnIS.TabStop = false;
            this.btnIS.Tag = "Equipment1";
            this.btnIS.UseVisualStyleBackColor = false;
            this.btnIS.Visible = false;
            this.btnIS.Click += new System.EventHandler(this.btnIS_Click);
            this.btnIS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnIA
            // 
            this.btnIA.BackColor = System.Drawing.Color.DimGray;
            this.btnIA.BackgroundImage = global::STS.Properties.Resources.IronArmor_Equip;
            this.btnIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIA.Enabled = false;
            this.btnIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIA.Location = new System.Drawing.Point(683, 503);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(60, 70);
            this.btnIA.TabIndex = 5;
            this.btnIA.TabStop = false;
            this.btnIA.Tag = "Equipment1";
            this.btnIA.UseVisualStyleBackColor = false;
            this.btnIA.Visible = false;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            this.btnIA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnBA
            // 
            this.btnBA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBA.BackgroundImage = global::STS.Properties.Resources.BronzeArmor_Equip;
            this.btnBA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBA.Location = new System.Drawing.Point(617, 503);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(60, 70);
            this.btnBA.TabIndex = 4;
            this.btnBA.TabStop = false;
            this.btnBA.Tag = "Equipment1";
            this.btnBA.UseVisualStyleBackColor = false;
            this.btnBA.Visible = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            this.btnBA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // lblItems
            // 
            this.lblItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItems.Location = new System.Drawing.Point(617, 134);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(192, 226);
            this.lblItems.TabIndex = 9;
            this.lblItems.Visible = false;
            // 
            // btnPS
            // 
            this.btnPS.BackColor = System.Drawing.Color.DimGray;
            this.btnPS.BackgroundImage = global::STS.Properties.Resources.PiklSword;
            this.btnPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPS.Enabled = false;
            this.btnPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPS.Location = new System.Drawing.Point(749, 443);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(60, 54);
            this.btnPS.TabIndex = 11;
            this.btnPS.TabStop = false;
            this.btnPS.Tag = "Equipment1";
            this.btnPS.UseVisualStyleBackColor = false;
            this.btnPS.Visible = false;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            this.btnPS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnPA
            // 
            this.btnPA.BackColor = System.Drawing.Color.DimGray;
            this.btnPA.BackgroundImage = global::STS.Properties.Resources.PiklArmor_Equip;
            this.btnPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPA.Enabled = false;
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.Location = new System.Drawing.Point(749, 503);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(60, 70);
            this.btnPA.TabIndex = 13;
            this.btnPA.TabStop = false;
            this.btnPA.Tag = "Equipment1";
            this.btnPA.UseVisualStyleBackColor = false;
            this.btnPA.Visible = false;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            this.btnPA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoins.Location = new System.Drawing.Point(614, 113);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(124, 17);
            this.lblCoins.TabIndex = 18;
            this.lblCoins.Text = "Available Coins:";
            this.lblCoins.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitGameToolStripMenuItem,
            this.saveLoadGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
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
            // saveLoadGameToolStripMenuItem
            // 
            this.saveLoadGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.saveNewGameToolStripMenuItem});
            this.saveLoadGameToolStripMenuItem.Name = "saveLoadGameToolStripMenuItem";
            this.saveLoadGameToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.saveLoadGameToolStripMenuItem.Text = "Save/Load Game";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // saveNewGameToolStripMenuItem
            // 
            this.saveNewGameToolStripMenuItem.Name = "saveNewGameToolStripMenuItem";
            this.saveNewGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveNewGameToolStripMenuItem.Text = "Save New Game";
            this.saveNewGameToolStripMenuItem.Click += new System.EventHandler(this.saveNewGameToolStripMenuItem_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLevel.Location = new System.Drawing.Point(286, 102);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 17);
            this.lblLevel.TabIndex = 22;
            this.lblLevel.Text = "Level:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHP.Location = new System.Drawing.Point(286, 119);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(34, 17);
            this.lblHP.TabIndex = 23;
            this.lblHP.Text = "HP:";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStats.Location = new System.Drawing.Point(286, 136);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(55, 17);
            this.lblStats.TabIndex = 24;
            this.lblStats.Text = "Stats: ";
            // 
            // btnGS
            // 
            this.btnGS.BackColor = System.Drawing.Color.DimGray;
            this.btnGS.BackgroundImage = global::STS.Properties.Resources.GoblinSword;
            this.btnGS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGS.Enabled = false;
            this.btnGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS.Location = new System.Drawing.Point(617, 443);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(60, 54);
            this.btnGS.TabIndex = 25;
            this.btnGS.TabStop = false;
            this.btnGS.Tag = "Equipment2";
            this.btnGS.UseVisualStyleBackColor = false;
            this.btnGS.Visible = false;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            this.btnGS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnGA
            // 
            this.btnGA.BackColor = System.Drawing.Color.DimGray;
            this.btnGA.BackgroundImage = global::STS.Properties.Resources.GoblinArmor;
            this.btnGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGA.Enabled = false;
            this.btnGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA.Location = new System.Drawing.Point(617, 503);
            this.btnGA.Name = "btnGA";
            this.btnGA.Size = new System.Drawing.Size(60, 70);
            this.btnGA.TabIndex = 26;
            this.btnGA.TabStop = false;
            this.btnGA.Tag = "Equipment2";
            this.btnGA.UseVisualStyleBackColor = false;
            this.btnGA.Visible = false;
            this.btnGA.Click += new System.EventHandler(this.btnGA_Click);
            this.btnGA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnMA
            // 
            this.btnMA.BackColor = System.Drawing.Color.DimGray;
            this.btnMA.BackgroundImage = global::STS.Properties.Resources.MonkeArmor;
            this.btnMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMA.Enabled = false;
            this.btnMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMA.Location = new System.Drawing.Point(683, 503);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(60, 70);
            this.btnMA.TabIndex = 29;
            this.btnMA.TabStop = false;
            this.btnMA.Tag = "Equipment2";
            this.btnMA.UseVisualStyleBackColor = false;
            this.btnMA.Visible = false;
            this.btnMA.Click += new System.EventHandler(this.btnMA_Click);
            this.btnMA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnMM
            // 
            this.btnMM.BackColor = System.Drawing.Color.DimGray;
            this.btnMM.BackgroundImage = global::STS.Properties.Resources.MonkeMallet;
            this.btnMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMM.Enabled = false;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMM.Location = new System.Drawing.Point(683, 443);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(60, 54);
            this.btnMM.TabIndex = 28;
            this.btnMM.TabStop = false;
            this.btnMM.Tag = "Equipment2";
            this.btnMM.UseVisualStyleBackColor = false;
            this.btnMM.Visible = false;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            this.btnMM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.DimGray;
            this.btnDA.BackgroundImage = global::STS.Properties.Resources.DinoArmor;
            this.btnDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDA.Enabled = false;
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDA.Location = new System.Drawing.Point(749, 503);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(60, 70);
            this.btnDA.TabIndex = 31;
            this.btnDA.TabStop = false;
            this.btnDA.Tag = "Equipment2";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Visible = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            this.btnDA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // btnDS
            // 
            this.btnDS.BackColor = System.Drawing.Color.DimGray;
            this.btnDS.BackgroundImage = global::STS.Properties.Resources.DinoSword;
            this.btnDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDS.Enabled = false;
            this.btnDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDS.Location = new System.Drawing.Point(749, 443);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(60, 54);
            this.btnDS.TabIndex = 30;
            this.btnDS.TabStop = false;
            this.btnDS.Tag = "Equipment2";
            this.btnDS.UseVisualStyleBackColor = false;
            this.btnDS.Visible = false;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            this.btnDS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateStats);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON (*.json) | *.json;";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JSON (*.json) | *.json;";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::STS.Properties.Resources.Next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(720, 588);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 30);
            this.btnNext.TabIndex = 27;
            this.btnNext.TabStop = false;
            this.btnNext.Tag = "Equipment";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMap.BackgroundImage = global::STS.Properties.Resources.Map;
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(29, 250);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(188, 83);
            this.btnMap.TabIndex = 20;
            this.btnMap.TabStop = false;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackgroundImage = global::STS.Properties.Resources.Inventory;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(649, 51);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(132, 49);
            this.btnInventory.TabIndex = 16;
            this.btnInventory.TabStop = false;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.BackgroundImage = global::STS.Properties.Resources.Gear;
            this.btnEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(649, 379);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(132, 49);
            this.btnEquipment.TabIndex = 15;
            this.btnEquipment.TabStop = false;
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.BackgroundImage = global::STS.Properties.Resources.Shop;
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(29, 378);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(188, 83);
            this.btnShop.TabIndex = 14;
            this.btnShop.TabStop = false;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnCraft
            // 
            this.btnCraft.BackgroundImage = global::STS.Properties.Resources.Smithy;
            this.btnCraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCraft.Location = new System.Drawing.Point(29, 507);
            this.btnCraft.Name = "btnCraft";
            this.btnCraft.Size = new System.Drawing.Size(188, 83);
            this.btnCraft.TabIndex = 12;
            this.btnCraft.TabStop = false;
            this.btnCraft.UseVisualStyleBackColor = true;
            this.btnCraft.Click += new System.EventHandler(this.btnCraft_Click);
            // 
            // pbSword
            // 
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSword.Location = new System.Drawing.Point(299, 186);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(51, 77);
            this.pbSword.TabIndex = 8;
            this.pbSword.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(307, 185);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(225, 264);
            this.pbPlayer.TabIndex = 7;
            this.pbPlayer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(289, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 300);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::STS.Properties.Resources.Previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(617, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 30);
            this.btnBack.TabIndex = 32;
            this.btnBack.TabStop = false;
            this.btnBack.Tag = "Equipment";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFood.Location = new System.Drawing.Point(26, 51);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(121, 17);
            this.lblFood.TabIndex = 33;
            this.lblFood.Text = "Available food: ";
            // 
            // btnCook
            // 
            this.btnCook.BackColor = System.Drawing.Color.Teal;
            this.btnCook.Enabled = false;
            this.btnCook.Location = new System.Drawing.Point(29, 81);
            this.btnCook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCook.Name = "btnCook";
            this.btnCook.Size = new System.Drawing.Size(56, 24);
            this.btnCook.TabIndex = 34;
            this.btnCook.TabStop = false;
            this.btnCook.Text = "Cook";
            this.btnCook.UseVisualStyleBackColor = false;
            this.btnCook.Click += new System.EventHandler(this.btnCook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCook);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnMA);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnNext);
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMA;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.ToolStripMenuItem saveLoadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveNewGameToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnCook;
        private System.Windows.Forms.Button button1;
    }
}