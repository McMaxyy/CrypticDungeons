namespace STS
{
    partial class Grind
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
            this.lblExp = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnPotion = new System.Windows.Forms.Button();
            this.btnBomb = new System.Windows.Forms.Button();
            this.btnShield = new System.Windows.Forms.Button();
            this.btnSword = new System.Windows.Forms.Button();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.btnDef = new System.Windows.Forms.Button();
            this.btnStr = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblStrDef = new System.Windows.Forms.Label();
            this.lblLevelUp = new System.Windows.Forms.Label();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.pbLevelUp = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblShields = new System.Windows.Forms.Label();
            this.txtDmgOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(240, 595);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(43, 17);
            this.lblExp.TabIndex = 55;
            this.lblExp.Tag = "Stage";
            this.lblExp.Text = "EXP:";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(28, 355);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(39, 17);
            this.lblPlayerHP.TabIndex = 52;
            this.lblPlayerHP.Tag = "Stage";
            this.lblPlayerHP.Text = "HP: ";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.Location = new System.Drawing.Point(513, 26);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(39, 17);
            this.lblEnemyHP.TabIndex = 51;
            this.lblEnemyHP.Tag = "Stage";
            this.lblEnemyHP.Text = "HP: ";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(469, 391);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(173, 83);
            this.btnAttack.TabIndex = 50;
            this.btnAttack.Tag = "Stage";
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnPotion
            // 
            this.btnPotion.Enabled = false;
            this.btnPotion.Location = new System.Drawing.Point(409, 545);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(70, 67);
            this.btnPotion.TabIndex = 58;
            this.btnPotion.UseVisualStyleBackColor = true;
            this.btnPotion.Click += new System.EventHandler(this.btnPotion_Click);
            // 
            // btnBomb
            // 
            this.btnBomb.Enabled = false;
            this.btnBomb.Location = new System.Drawing.Point(485, 545);
            this.btnBomb.Name = "btnBomb";
            this.btnBomb.Size = new System.Drawing.Size(70, 67);
            this.btnBomb.TabIndex = 59;
            this.btnBomb.UseVisualStyleBackColor = true;
            this.btnBomb.Click += new System.EventHandler(this.btnBomb_Click);
            // 
            // btnShield
            // 
            this.btnShield.Enabled = false;
            this.btnShield.Location = new System.Drawing.Point(561, 545);
            this.btnShield.Name = "btnShield";
            this.btnShield.Size = new System.Drawing.Size(70, 67);
            this.btnShield.TabIndex = 60;
            this.btnShield.UseVisualStyleBackColor = true;
            this.btnShield.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // btnSword
            // 
            this.btnSword.Enabled = false;
            this.btnSword.Location = new System.Drawing.Point(637, 545);
            this.btnSword.Name = "btnSword";
            this.btnSword.Size = new System.Drawing.Size(70, 67);
            this.btnSword.TabIndex = 61;
            this.btnSword.UseVisualStyleBackColor = true;
            this.btnSword.Click += new System.EventHandler(this.btnSword_Click);
            // 
            // pbSword
            // 
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSword.Location = new System.Drawing.Point(24, 391);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(43, 65);
            this.pbSword.TabIndex = 57;
            this.pbSword.TabStop = false;
            this.pbSword.Tag = "Stage";
            // 
            // pbEnemy
            // 
            this.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemy.Location = new System.Drawing.Point(626, 26);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(178, 216);
            this.pbEnemy.TabIndex = 49;
            this.pbEnemy.TabStop = false;
            this.pbEnemy.Tag = "Stage";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(31, 390);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(185, 222);
            this.pbPlayer.TabIndex = 48;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "Stage";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(240, 570);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(52, 17);
            this.lblLevel.TabIndex = 62;
            this.lblLevel.Tag = "Stage";
            this.lblLevel.Text = "Level:";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(240, 545);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(53, 17);
            this.lblCoins.TabIndex = 63;
            this.lblCoins.Tag = "Stage";
            this.lblCoins.Text = "Coins:";
            // 
            // btnDef
            // 
            this.btnDef.Location = new System.Drawing.Point(456, 336);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(23, 23);
            this.btnDef.TabIndex = 70;
            this.btnDef.Tag = "Stage";
            this.btnDef.Text = "+";
            this.btnDef.UseVisualStyleBackColor = true;
            this.btnDef.Visible = false;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // btnStr
            // 
            this.btnStr.Location = new System.Drawing.Point(456, 310);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(23, 23);
            this.btnStr.TabIndex = 69;
            this.btnStr.Tag = "Stage";
            this.btnStr.Text = "+";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Visible = false;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(351, 266);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(121, 37);
            this.lblPoints.TabIndex = 68;
            this.lblPoints.Tag = "Stage";
            this.lblPoints.Text = "Unused points:";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPoints.Visible = false;
            // 
            // lblStrDef
            // 
            this.lblStrDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrDef.Location = new System.Drawing.Point(363, 309);
            this.lblStrDef.Name = "lblStrDef";
            this.lblStrDef.Size = new System.Drawing.Size(63, 48);
            this.lblStrDef.TabIndex = 67;
            this.lblStrDef.Tag = "Stage";
            this.lblStrDef.Text = "Strength\r\n \r\nDefense";
            this.lblStrDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStrDef.Visible = false;
            // 
            // lblLevelUp
            // 
            this.lblLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelUp.Location = new System.Drawing.Point(331, 253);
            this.lblLevelUp.Name = "lblLevelUp";
            this.lblLevelUp.Size = new System.Drawing.Size(185, 13);
            this.lblLevelUp.TabIndex = 66;
            this.lblLevelUp.Tag = "Stage";
            this.lblLevelUp.Text = "You leveled up!";
            this.lblLevelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevelUp.Visible = false;
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(381, 374);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(87, 23);
            this.btnLevelUp.TabIndex = 65;
            this.btnLevelUp.Tag = "Stage";
            this.btnLevelUp.Text = "OK";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Visible = false;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // pbLevelUp
            // 
            this.pbLevelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLevelUp.Location = new System.Drawing.Point(315, 244);
            this.pbLevelUp.Name = "pbLevelUp";
            this.pbLevelUp.Size = new System.Drawing.Size(218, 164);
            this.pbLevelUp.TabIndex = 64;
            this.pbLevelUp.TabStop = false;
            this.pbLevelUp.Tag = "Stage";
            this.pbLevelUp.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 71;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblShields
            // 
            this.lblShields.AutoSize = true;
            this.lblShields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShields.Location = new System.Drawing.Point(127, 355);
            this.lblShields.Name = "lblShields";
            this.lblShields.Size = new System.Drawing.Size(0, 17);
            this.lblShields.TabIndex = 72;
            this.lblShields.Tag = "Stage";
            // 
            // txtDmgOutput
            // 
            this.txtDmgOutput.Enabled = false;
            this.txtDmgOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDmgOutput.Location = new System.Drawing.Point(119, 14);
            this.txtDmgOutput.Multiline = true;
            this.txtDmgOutput.Name = "txtDmgOutput";
            this.txtDmgOutput.ReadOnly = true;
            this.txtDmgOutput.Size = new System.Drawing.Size(299, 292);
            this.txtDmgOutput.TabIndex = 73;
            this.txtDmgOutput.TabStop = false;
            // 
            // Grind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.ControlBox = false;
            this.Controls.Add(this.lblShields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblStrDef);
            this.Controls.Add(this.lblLevelUp);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.pbLevelUp);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnSword);
            this.Controls.Add(this.btnShield);
            this.Controls.Add(this.btnBomb);
            this.Controls.Add(this.btnPotion);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.txtDmgOutput);
            this.Name = "Grind";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnPotion;
        private System.Windows.Forms.Button btnBomb;
        private System.Windows.Forms.Button btnShield;
        private System.Windows.Forms.Button btnSword;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblStrDef;
        private System.Windows.Forms.Label lblLevelUp;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.PictureBox pbLevelUp;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblShields;
        private System.Windows.Forms.TextBox txtDmgOutput;
    }
}