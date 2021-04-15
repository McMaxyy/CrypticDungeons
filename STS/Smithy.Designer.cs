namespace STS
{
    partial class Smithy
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
            this.btnCraftPSword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCraftPArmor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPickleS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickleS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCraftPSword
            // 
            this.btnCraftPSword.Location = new System.Drawing.Point(149, 205);
            this.btnCraftPSword.Name = "btnCraftPSword";
            this.btnCraftPSword.Size = new System.Drawing.Size(37, 23);
            this.btnCraftPSword.TabIndex = 0;
            this.btnCraftPSword.Text = "Craft";
            this.btnCraftPSword.UseVisualStyleBackColor = true;
            this.btnCraftPSword.Click += new System.EventHandler(this.btnCraftPSword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crafting Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pickle Armor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pickle Sword";
            // 
            // btnCraftPArmor
            // 
            this.btnCraftPArmor.Location = new System.Drawing.Point(149, 345);
            this.btnCraftPArmor.Name = "btnCraftPArmor";
            this.btnCraftPArmor.Size = new System.Drawing.Size(37, 23);
            this.btnCraftPArmor.TabIndex = 7;
            this.btnCraftPArmor.Text = "Craft";
            this.btnCraftPArmor.UseVisualStyleBackColor = true;
            this.btnCraftPArmor.Click += new System.EventHandler(this.btnCraftPArmor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventory: ";
            // 
            // lblItems
            // 
            this.lblItems.Location = new System.Drawing.Point(546, 425);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(236, 137);
            this.lblItems.TabIndex = 9;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 13);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preview:";
            // 
            // pbSword
            // 
            this.pbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSword.Location = new System.Drawing.Point(549, 79);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(51, 77);
            this.pbSword.TabIndex = 13;
            this.pbSword.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(557, 78);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(225, 264);
            this.pbPlayer.TabIndex = 12;
            this.pbPlayer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::STS.Properties.Resources.PiklArmor_Equip;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(61, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 96);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbPickleS
            // 
            this.pbPickleS.BackgroundImage = global::STS.Properties.Resources.PiklSword;
            this.pbPickleS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPickleS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPickleS.Location = new System.Drawing.Point(61, 144);
            this.pbPickleS.Name = "pbPickleS";
            this.pbPickleS.Size = new System.Drawing.Size(82, 84);
            this.pbPickleS.TabIndex = 3;
            this.pbPickleS.TabStop = false;
            // 
            // Smithy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.pbSword);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCraftPArmor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPickleS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCraftPSword);
            this.Name = "Smithy";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickleS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCraftPSword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPickleS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCraftPArmor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbSword;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}