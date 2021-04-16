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
            this.SuspendLayout();
            // 
            // btnStage2
            // 
            this.btnStage2.Location = new System.Drawing.Point(264, 168);
            this.btnStage2.Name = "btnStage2";
            this.btnStage2.Size = new System.Drawing.Size(128, 64);
            this.btnStage2.TabIndex = 8;
            this.btnStage2.TabStop = false;
            this.btnStage2.Text = "Stage2";
            this.btnStage2.UseVisualStyleBackColor = true;
            this.btnStage2.Click += new System.EventHandler(this.btnStage2_Click);
            // 
            // btnStage1
            // 
            this.btnStage1.Location = new System.Drawing.Point(56, 56);
            this.btnStage1.Name = "btnStage1";
            this.btnStage1.Size = new System.Drawing.Size(128, 64);
            this.btnStage1.TabIndex = 7;
            this.btnStage1.TabStop = false;
            this.btnStage1.Text = "Stage1";
            this.btnStage1.UseVisualStyleBackColor = true;
            this.btnStage1.Click += new System.EventHandler(this.btnStage1_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.Controls.Add(this.btnStage2);
            this.Controls.Add(this.btnStage1);
            this.Name = "Map";
            this.Text = "Cryptic Dungeons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStage2;
        private System.Windows.Forms.Button btnStage1;
    }
}