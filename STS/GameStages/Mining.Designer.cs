namespace STS
{
    partial class Mining
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.lblHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(256, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(509, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(389, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::STS.Properties.Resources.Previous;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 72;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pbRock
            // 
            this.pbRock.BackgroundImage = global::STS.Properties.Resources.IronOre_New;
            this.pbRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRock.Location = new System.Drawing.Point(179, 122);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(452, 377);
            this.pbRock.TabIndex = 3;
            this.pbRock.TabStop = false;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHP.Location = new System.Drawing.Point(175, 78);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(38, 20);
            this.lblHP.TabIndex = 73;
            this.lblHP.Text = "HP:";
            // 
            // Mining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbRock);
            this.Name = "Mining";
            this.Text = "Cryptic Dungeons";
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblHP;
    }
}