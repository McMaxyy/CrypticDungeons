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
            this.btnStage1 = new System.Windows.Forms.Button();
            this.btnWS = new System.Windows.Forms.Button();
            this.btnIS = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnIA = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btnStage2 = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStage1
            // 
            this.btnStage1.Location = new System.Drawing.Point(12, 12);
            this.btnStage1.Name = "btnStage1";
            this.btnStage1.Size = new System.Drawing.Size(66, 56);
            this.btnStage1.TabIndex = 0;
            this.btnStage1.Text = "Stage1";
            this.btnStage1.UseVisualStyleBackColor = true;
            this.btnStage1.Click += new System.EventHandler(this.btnStage1_Click);
            // 
            // btnWS
            // 
            this.btnWS.Location = new System.Drawing.Point(12, 425);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(60, 54);
            this.btnWS.TabIndex = 1;
            this.btnWS.Tag = "Equipment";
            this.btnWS.Text = "Wooden Sword";
            this.btnWS.UseVisualStyleBackColor = true;
            this.btnWS.Visible = false;
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            // 
            // btnIS
            // 
            this.btnIS.Enabled = false;
            this.btnIS.Location = new System.Drawing.Point(78, 425);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(60, 54);
            this.btnIS.TabIndex = 2;
            this.btnIS.Tag = "Equipment";
            this.btnIS.Text = "Iron Sword";
            this.btnIS.UseVisualStyleBackColor = true;
            this.btnIS.Visible = false;
            this.btnIS.Click += new System.EventHandler(this.btnIS_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(144, 516);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Tag = "Equipment";
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnIA
            // 
            this.btnIA.Enabled = false;
            this.btnIA.Location = new System.Drawing.Point(78, 485);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(60, 54);
            this.btnIA.TabIndex = 5;
            this.btnIA.Tag = "Equipment";
            this.btnIA.Text = "Iron Armor";
            this.btnIA.UseVisualStyleBackColor = true;
            this.btnIA.Visible = false;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            // 
            // btnBA
            // 
            this.btnBA.Location = new System.Drawing.Point(12, 485);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(60, 54);
            this.btnBA.TabIndex = 4;
            this.btnBA.Tag = "Equipment";
            this.btnBA.Text = "Bronze Armor";
            this.btnBA.UseVisualStyleBackColor = true;
            this.btnBA.Visible = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // btnStage2
            // 
            this.btnStage2.Location = new System.Drawing.Point(12, 74);
            this.btnStage2.Name = "btnStage2";
            this.btnStage2.Size = new System.Drawing.Size(66, 56);
            this.btnStage2.TabIndex = 6;
            this.btnStage2.Text = "Stage2";
            this.btnStage2.UseVisualStyleBackColor = true;
            this.btnStage2.Click += new System.EventHandler(this.btnStage2_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(12, 146);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(247, 264);
            this.pbPlayer.TabIndex = 7;
            this.pbPlayer.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 551);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnStage2);
            this.Controls.Add(this.btnIA);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.btnWS);
            this.Controls.Add(this.btnStage1);
            this.Name = "Map";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStage1;
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnIS;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnIA;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btnStage2;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}