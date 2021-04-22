namespace STS
{
    partial class FinalBoss
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
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnPotion = new System.Windows.Forms.Button();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblShields = new System.Windows.Forms.Label();
            this.txtDmgOutput = new System.Windows.Forms.TextBox();
            this.btnDefend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
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
            this.lblEnemyHP.Location = new System.Drawing.Point(466, 26);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(39, 17);
            this.lblEnemyHP.TabIndex = 51;
            this.lblEnemyHP.Tag = "Stage";
            this.lblEnemyHP.Text = "HP: ";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(409, 414);
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
            this.btnPotion.Location = new System.Drawing.Point(559, 520);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(70, 67);
            this.btnPotion.TabIndex = 58;
            this.btnPotion.UseVisualStyleBackColor = true;
            this.btnPotion.Click += new System.EventHandler(this.btnPotion_Click);
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
            this.pbEnemy.BackgroundImage = global::STS.Properties.Resources.Zavr;
            this.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemy.Location = new System.Drawing.Point(543, 26);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(261, 216);
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
            this.lblLevel.Location = new System.Drawing.Point(235, 595);
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
            this.lblCoins.Location = new System.Drawing.Point(235, 570);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(53, 17);
            this.lblCoins.TabIndex = 63;
            this.lblCoins.Tag = "Stage";
            this.lblCoins.Text = "Coins:";
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
            this.txtDmgOutput.Size = new System.Drawing.Size(260, 292);
            this.txtDmgOutput.TabIndex = 73;
            this.txtDmgOutput.TabStop = false;
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.LightGray;
            this.btnDefend.Location = new System.Drawing.Point(607, 414);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(173, 83);
            this.btnDefend.TabIndex = 74;
            this.btnDefend.TabStop = false;
            this.btnDefend.Tag = "Stage";
            this.btnDefend.Text = "Parry";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // FinalBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.lblShields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnPotion);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.txtDmgOutput);
            this.Name = "FinalBoss";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnPotion;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblShields;
        private System.Windows.Forms.TextBox txtDmgOutput;
        private System.Windows.Forms.Button btnDefend;
    }
}