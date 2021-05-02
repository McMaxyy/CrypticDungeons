namespace STS
{
    partial class STS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STS));
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblDmg1 = new System.Windows.Forms.Label();
            this.lblDmg2 = new System.Windows.Forms.Label();
            this.lblYY = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblLost = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lblSkip = new System.Windows.Forms.Label();
            this.lblCleared = new System.Windows.Forms.Label();
            this.btnCleared = new System.Windows.Forms.Button();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLevelUp = new System.Windows.Forms.Label();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.lblStrDef = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnStr = new System.Windows.Forms.Button();
            this.btnDef = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pbLevelUp = new System.Windows.Forms.PictureBox();
            this.pbCleared = new System.Windows.Forms.PictureBox();
            this.pbSkip = new System.Windows.Forms.PictureBox();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.btnFlee = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.btnRand5 = new System.Windows.Forms.Button();
            this.btnRand4 = new System.Windows.Forms.Button();
            this.btnRand3 = new System.Windows.Forms.Button();
            this.btnRand2 = new System.Windows.Forms.Button();
            this.btnBattle3 = new System.Windows.Forms.Button();
            this.btnBattle2 = new System.Windows.Forms.Button();
            this.btnBoss = new System.Windows.Forms.Button();
            this.btnBattle1 = new System.Windows.Forms.Button();
            this.btnRand1 = new System.Windows.Forms.Button();
            this.pbFight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCleared)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblEnemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnemyHP.Location = new System.Drawing.Point(143, 52);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(39, 17);
            this.lblEnemyHP.TabIndex = 24;
            this.lblEnemyHP.Tag = "Stage";
            this.lblEnemyHP.Text = "HP: ";
            this.lblEnemyHP.Visible = false;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayerHP.Location = new System.Drawing.Point(143, 348);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(39, 17);
            this.lblPlayerHP.TabIndex = 25;
            this.lblPlayerHP.Tag = "Stage";
            this.lblPlayerHP.Text = "HP: ";
            this.lblPlayerHP.Visible = false;
            // 
            // lblDmg1
            // 
            this.lblDmg1.AutoSize = true;
            this.lblDmg1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDmg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmg1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDmg1.Location = new System.Drawing.Point(163, 230);
            this.lblDmg1.Name = "lblDmg1";
            this.lblDmg1.Size = new System.Drawing.Size(69, 13);
            this.lblDmg1.TabIndex = 26;
            this.lblDmg1.Tag = "Stage";
            this.lblDmg1.Text = "You dealt: ";
            this.lblDmg1.Visible = false;
            // 
            // lblDmg2
            // 
            this.lblDmg2.AutoSize = true;
            this.lblDmg2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDmg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmg2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDmg2.Location = new System.Drawing.Point(163, 154);
            this.lblDmg2.Name = "lblDmg2";
            this.lblDmg2.Size = new System.Drawing.Size(80, 13);
            this.lblDmg2.TabIndex = 27;
            this.lblDmg2.Tag = "Stage";
            this.lblDmg2.Text = "Enemy dealt:";
            this.lblDmg2.Visible = false;
            // 
            // lblYY
            // 
            this.lblYY.AutoSize = true;
            this.lblYY.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYY.ForeColor = System.Drawing.Color.Maroon;
            this.lblYY.Location = new System.Drawing.Point(143, 90);
            this.lblYY.Name = "lblYY";
            this.lblYY.Size = new System.Drawing.Size(0, 17);
            this.lblYY.TabIndex = 28;
            this.lblYY.Tag = "";
            this.lblYY.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackgroundImage = global::STS.Properties.Resources.Previous;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Location = new System.Drawing.Point(12, 66);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 23);
            this.btnRestart.TabIndex = 29;
            this.btnRestart.TabStop = false;
            this.btnRestart.Tag = "Stage";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLost.Location = new System.Drawing.Point(9, 48);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(48, 13);
            this.lblLost.TabIndex = 30;
            this.lblLost.Tag = "Stage";
            this.lblLost.Text = "You lost!";
            this.lblLost.Visible = false;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.LightGray;
            this.btnSkip.Location = new System.Drawing.Point(393, 324);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(87, 23);
            this.btnSkip.TabIndex = 32;
            this.btnSkip.TabStop = false;
            this.btnSkip.Tag = "Stage";
            this.btnSkip.Text = "OK";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Visible = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.BackColor = System.Drawing.Color.LightGray;
            this.lblSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkip.Location = new System.Drawing.Point(365, 272);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(150, 13);
            this.lblSkip.TabIndex = 33;
            this.lblSkip.Tag = "Stage";
            this.lblSkip.Text = "You get to skip the level!";
            this.lblSkip.Visible = false;
            // 
            // lblCleared
            // 
            this.lblCleared.BackColor = System.Drawing.Color.LightGray;
            this.lblCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleared.Location = new System.Drawing.Point(343, 280);
            this.lblCleared.Name = "lblCleared";
            this.lblCleared.Size = new System.Drawing.Size(185, 13);
            this.lblCleared.TabIndex = 36;
            this.lblCleared.Tag = "Stage";
            this.lblCleared.Text = "You cleared the battle!";
            this.lblCleared.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCleared.Visible = false;
            // 
            // btnCleared
            // 
            this.btnCleared.BackColor = System.Drawing.Color.LightGray;
            this.btnCleared.Location = new System.Drawing.Point(393, 324);
            this.btnCleared.Name = "btnCleared";
            this.btnCleared.Size = new System.Drawing.Size(87, 23);
            this.btnCleared.TabIndex = 35;
            this.btnCleared.TabStop = false;
            this.btnCleared.Tag = "Stage";
            this.btnCleared.Text = "OK";
            this.btnCleared.UseVisualStyleBackColor = false;
            this.btnCleared.Visible = false;
            this.btnCleared.Click += new System.EventHandler(this.btnCleared_Click);
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExp.Location = new System.Drawing.Point(358, 577);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(43, 17);
            this.lblExp.TabIndex = 37;
            this.lblExp.Tag = "Stage";
            this.lblExp.Text = "EXP:";
            this.lblExp.Visible = false;
            // 
            // lblLevelUp
            // 
            this.lblLevelUp.BackColor = System.Drawing.Color.LightGray;
            this.lblLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelUp.Location = new System.Drawing.Point(343, 231);
            this.lblLevelUp.Name = "lblLevelUp";
            this.lblLevelUp.Size = new System.Drawing.Size(185, 13);
            this.lblLevelUp.TabIndex = 40;
            this.lblLevelUp.Tag = "Stage";
            this.lblLevelUp.Text = "You leveled up!";
            this.lblLevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevelUp.Visible = false;
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.BackColor = System.Drawing.Color.LightGray;
            this.btnLevelUp.Location = new System.Drawing.Point(393, 352);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(87, 23);
            this.btnLevelUp.TabIndex = 39;
            this.btnLevelUp.TabStop = false;
            this.btnLevelUp.Tag = "Stage";
            this.btnLevelUp.Text = "OK";
            this.btnLevelUp.UseVisualStyleBackColor = false;
            this.btnLevelUp.Visible = false;
            this.btnLevelUp.Click += new System.EventHandler(this.btnCleared_Click);
            // 
            // lblStrDef
            // 
            this.lblStrDef.BackColor = System.Drawing.Color.LightGray;
            this.lblStrDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrDef.Location = new System.Drawing.Point(375, 287);
            this.lblStrDef.Name = "lblStrDef";
            this.lblStrDef.Size = new System.Drawing.Size(63, 48);
            this.lblStrDef.TabIndex = 41;
            this.lblStrDef.Tag = "Stage";
            this.lblStrDef.Text = "Strength\r\n \r\nDefense";
            this.lblStrDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStrDef.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.LightGray;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(363, 244);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(121, 37);
            this.lblPoints.TabIndex = 42;
            this.lblPoints.Tag = "Stage";
            this.lblPoints.Text = "Unused points:";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPoints.Visible = false;
            // 
            // btnStr
            // 
            this.btnStr.BackColor = System.Drawing.Color.LightGray;
            this.btnStr.Location = new System.Drawing.Point(468, 288);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(23, 23);
            this.btnStr.TabIndex = 43;
            this.btnStr.TabStop = false;
            this.btnStr.Tag = "Stage";
            this.btnStr.Text = "+";
            this.btnStr.UseVisualStyleBackColor = false;
            this.btnStr.Visible = false;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // btnDef
            // 
            this.btnDef.BackColor = System.Drawing.Color.LightGray;
            this.btnDef.Location = new System.Drawing.Point(468, 314);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(23, 23);
            this.btnDef.TabIndex = 44;
            this.btnDef.TabStop = false;
            this.btnDef.Tag = "Stage";
            this.btnDef.Text = "+";
            this.btnDef.UseVisualStyleBackColor = false;
            this.btnDef.Visible = false;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // lblStats
            // 
            this.lblStats.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStats.Location = new System.Drawing.Point(425, 502);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(185, 13);
            this.lblStats.TabIndex = 45;
            this.lblStats.Tag = "Stage";
            this.lblStats.Text = "Str | Def";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStats.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::STS.Properties.Resources.Previous;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.TabStop = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pbLevelUp
            // 
            this.pbLevelUp.BackColor = System.Drawing.Color.LightGray;
            this.pbLevelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLevelUp.Location = new System.Drawing.Point(327, 222);
            this.pbLevelUp.Name = "pbLevelUp";
            this.pbLevelUp.Size = new System.Drawing.Size(218, 164);
            this.pbLevelUp.TabIndex = 38;
            this.pbLevelUp.TabStop = false;
            this.pbLevelUp.Tag = "Stage";
            this.pbLevelUp.Visible = false;
            // 
            // pbCleared
            // 
            this.pbCleared.BackColor = System.Drawing.Color.LightGray;
            this.pbCleared.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCleared.Location = new System.Drawing.Point(327, 250);
            this.pbCleared.Name = "pbCleared";
            this.pbCleared.Size = new System.Drawing.Size(218, 112);
            this.pbCleared.TabIndex = 34;
            this.pbCleared.TabStop = false;
            this.pbCleared.Tag = "Stage";
            this.pbCleared.Visible = false;
            // 
            // pbSkip
            // 
            this.pbSkip.BackColor = System.Drawing.Color.LightGray;
            this.pbSkip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSkip.Location = new System.Drawing.Point(327, 250);
            this.pbSkip.Name = "pbSkip";
            this.pbSkip.Size = new System.Drawing.Size(218, 112);
            this.pbSkip.TabIndex = 31;
            this.pbSkip.TabStop = false;
            this.pbSkip.Tag = "Stage";
            this.pbSkip.Visible = false;
            // 
            // pbSword
            // 
            this.pbSword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSword.Location = new System.Drawing.Point(141, 369);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(43, 65);
            this.pbSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSword.TabIndex = 47;
            this.pbSword.TabStop = false;
            this.pbSword.Tag = "Stage";
            this.pbSword.Visible = false;
            // 
            // btnFlee
            // 
            this.btnFlee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFlee.BackgroundImage = global::STS.Properties.Resources.Flee;
            this.btnFlee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlee.Location = new System.Drawing.Point(530, 437);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(150, 43);
            this.btnFlee.TabIndex = 23;
            this.btnFlee.TabStop = false;
            this.btnFlee.Tag = "Stage";
            this.btnFlee.UseVisualStyleBackColor = false;
            this.btnFlee.Visible = false;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDefend.BackgroundImage = global::STS.Properties.Resources.Defend;
            this.btnDefend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefend.Location = new System.Drawing.Point(361, 437);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(150, 42);
            this.btnDefend.TabIndex = 22;
            this.btnDefend.TabStop = false;
            this.btnDefend.Tag = "Stage";
            this.btnDefend.UseVisualStyleBackColor = false;
            this.btnDefend.Visible = false;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAttack.BackgroundImage = global::STS.Properties.Resources.Attack;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.Location = new System.Drawing.Point(443, 373);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(150, 43);
            this.btnAttack.TabIndex = 21;
            this.btnAttack.TabStop = false;
            this.btnAttack.Tag = "Stage";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemy.Location = new System.Drawing.Point(502, 52);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(178, 216);
            this.pbEnemy.TabIndex = 20;
            this.pbEnemy.TabStop = false;
            this.pbEnemy.Tag = "Stage";
            this.pbEnemy.Visible = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(148, 368);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(185, 222);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 19;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "Stage";
            this.pbPlayer.Visible = false;
            // 
            // btnSpecial
            // 
            this.btnSpecial.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpecial.BackgroundImage = global::STS.Properties.Resources.Special;
            this.btnSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpecial.Enabled = false;
            this.btnSpecial.Location = new System.Drawing.Point(489, 154);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(88, 62);
            this.btnSpecial.TabIndex = 16;
            this.btnSpecial.TabStop = false;
            this.btnSpecial.UseVisualStyleBackColor = false;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // btnRand5
            // 
            this.btnRand5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRand5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRand5.BackgroundImage")));
            this.btnRand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRand5.Enabled = false;
            this.btnRand5.Location = new System.Drawing.Point(233, 154);
            this.btnRand5.Name = "btnRand5";
            this.btnRand5.Size = new System.Drawing.Size(88, 62);
            this.btnRand5.TabIndex = 15;
            this.btnRand5.TabStop = false;
            this.btnRand5.UseVisualStyleBackColor = false;
            this.btnRand5.Click += new System.EventHandler(this.btnRand2_Click);
            // 
            // btnRand4
            // 
            this.btnRand4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRand4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRand4.BackgroundImage")));
            this.btnRand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRand4.Enabled = false;
            this.btnRand4.Location = new System.Drawing.Point(489, 284);
            this.btnRand4.Name = "btnRand4";
            this.btnRand4.Size = new System.Drawing.Size(88, 62);
            this.btnRand4.TabIndex = 14;
            this.btnRand4.TabStop = false;
            this.btnRand4.UseVisualStyleBackColor = false;
            this.btnRand4.Click += new System.EventHandler(this.btnRand2_Click);
            // 
            // btnRand3
            // 
            this.btnRand3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRand3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRand3.BackgroundImage")));
            this.btnRand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRand3.Enabled = false;
            this.btnRand3.Location = new System.Drawing.Point(233, 284);
            this.btnRand3.Name = "btnRand3";
            this.btnRand3.Size = new System.Drawing.Size(88, 62);
            this.btnRand3.TabIndex = 13;
            this.btnRand3.TabStop = false;
            this.btnRand3.UseVisualStyleBackColor = false;
            this.btnRand3.Click += new System.EventHandler(this.btnRand2_Click);
            // 
            // btnRand2
            // 
            this.btnRand2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRand2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRand2.BackgroundImage")));
            this.btnRand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRand2.Location = new System.Drawing.Point(488, 417);
            this.btnRand2.Name = "btnRand2";
            this.btnRand2.Size = new System.Drawing.Size(88, 62);
            this.btnRand2.TabIndex = 12;
            this.btnRand2.TabStop = false;
            this.btnRand2.UseVisualStyleBackColor = false;
            this.btnRand2.Click += new System.EventHandler(this.btnRand2_Click);
            // 
            // btnBattle3
            // 
            this.btnBattle3.BackColor = System.Drawing.Color.LightGray;
            this.btnBattle3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBattle3.BackgroundImage")));
            this.btnBattle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBattle3.Enabled = false;
            this.btnBattle3.Location = new System.Drawing.Point(361, 154);
            this.btnBattle3.Name = "btnBattle3";
            this.btnBattle3.Size = new System.Drawing.Size(88, 62);
            this.btnBattle3.TabIndex = 11;
            this.btnBattle3.TabStop = false;
            this.btnBattle3.UseVisualStyleBackColor = false;
            this.btnBattle3.Click += new System.EventHandler(this.btnBattle1_Click);
            // 
            // btnBattle2
            // 
            this.btnBattle2.BackColor = System.Drawing.Color.LightGray;
            this.btnBattle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBattle2.BackgroundImage")));
            this.btnBattle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBattle2.Enabled = false;
            this.btnBattle2.Location = new System.Drawing.Point(361, 284);
            this.btnBattle2.Name = "btnBattle2";
            this.btnBattle2.Size = new System.Drawing.Size(88, 62);
            this.btnBattle2.TabIndex = 10;
            this.btnBattle2.TabStop = false;
            this.btnBattle2.UseVisualStyleBackColor = false;
            this.btnBattle2.Click += new System.EventHandler(this.btnBattle1_Click);
            // 
            // btnBoss
            // 
            this.btnBoss.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBoss.BackgroundImage = global::STS.Properties.Resources.Boss;
            this.btnBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoss.Enabled = false;
            this.btnBoss.Location = new System.Drawing.Point(330, 12);
            this.btnBoss.Name = "btnBoss";
            this.btnBoss.Size = new System.Drawing.Size(147, 91);
            this.btnBoss.TabIndex = 9;
            this.btnBoss.TabStop = false;
            this.btnBoss.UseVisualStyleBackColor = false;
            this.btnBoss.Click += new System.EventHandler(this.btnBoss_Click);
            // 
            // btnBattle1
            // 
            this.btnBattle1.BackColor = System.Drawing.Color.LightGray;
            this.btnBattle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBattle1.BackgroundImage")));
            this.btnBattle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBattle1.Location = new System.Drawing.Point(360, 417);
            this.btnBattle1.Name = "btnBattle1";
            this.btnBattle1.Size = new System.Drawing.Size(88, 62);
            this.btnBattle1.TabIndex = 1;
            this.btnBattle1.TabStop = false;
            this.btnBattle1.UseVisualStyleBackColor = false;
            this.btnBattle1.Click += new System.EventHandler(this.btnBattle1_Click);
            // 
            // btnRand1
            // 
            this.btnRand1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRand1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRand1.BackgroundImage")));
            this.btnRand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRand1.Location = new System.Drawing.Point(232, 417);
            this.btnRand1.Name = "btnRand1";
            this.btnRand1.Size = new System.Drawing.Size(88, 62);
            this.btnRand1.TabIndex = 0;
            this.btnRand1.TabStop = false;
            this.btnRand1.UseVisualStyleBackColor = false;
            this.btnRand1.Click += new System.EventHandler(this.btnRand2_Click);
            // 
            // pbFight
            // 
            this.pbFight.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbFight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFight.Location = new System.Drawing.Point(136, 41);
            this.pbFight.Name = "pbFight";
            this.pbFight.Size = new System.Drawing.Size(555, 560);
            this.pbFight.TabIndex = 18;
            this.pbFight.TabStop = false;
            this.pbFight.Tag = "Stage";
            this.pbFight.Visible = false;
            // 
            // STS
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblStrDef);
            this.Controls.Add(this.lblLevelUp);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.pbLevelUp);
            this.Controls.Add(this.lblCleared);
            this.Controls.Add(this.btnCleared);
            this.Controls.Add(this.pbCleared);
            this.Controls.Add(this.lblSkip);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.pbSkip);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblYY);
            this.Controls.Add(this.lblDmg2);
            this.Controls.Add(this.lblDmg1);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.btnFlee);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.btnRand5);
            this.Controls.Add(this.btnRand4);
            this.Controls.Add(this.btnRand3);
            this.Controls.Add(this.btnRand2);
            this.Controls.Add(this.btnBattle3);
            this.Controls.Add(this.btnBattle2);
            this.Controls.Add(this.btnBoss);
            this.Controls.Add(this.btnBattle1);
            this.Controls.Add(this.btnRand1);
            this.Controls.Add(this.pbFight);
            this.Name = "STS";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCleared)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnRand1;
        private System.Windows.Forms.Button btnBattle1;
        private System.Windows.Forms.Button btnBoss;
        private System.Windows.Forms.Button btnBattle2;
        private System.Windows.Forms.Button btnBattle3;
        private System.Windows.Forms.Button btnRand2;
        private System.Windows.Forms.Button btnRand4;
        private System.Windows.Forms.Button btnRand3;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Button btnRand5;
        private System.Windows.Forms.PictureBox pbFight;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblDmg1;
        private System.Windows.Forms.Label lblDmg2;
        private System.Windows.Forms.Label lblYY;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.PictureBox pbSkip;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.Label lblCleared;
        private System.Windows.Forms.Button btnCleared;
        private System.Windows.Forms.PictureBox pbCleared;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblLevelUp;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.PictureBox pbLevelUp;
        private System.Windows.Forms.Label lblStrDef;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbSword;
    }
}

