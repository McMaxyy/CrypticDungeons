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
            this.btnEndless = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStage2
            // 
            this.btnStage2.Location = new System.Drawing.Point(219, 56);
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
            // btnEndless
            // 
            this.btnEndless.Location = new System.Drawing.Point(56, 511);
            this.btnEndless.Name = "btnEndless";
            this.btnEndless.Size = new System.Drawing.Size(717, 64);
            this.btnEndless.TabIndex = 9;
            this.btnEndless.TabStop = false;
            this.btnEndless.Text = "Endless";
            this.btnEndless.UseVisualStyleBackColor = true;
            this.btnEndless.Click += new System.EventHandler(this.btnEndless_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 64);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "LowLevel Grind";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEndless);
            this.Controls.Add(this.btnStage2);
            this.Controls.Add(this.btnStage1);
            this.Name = "Map";
            this.Text = "Cryptic Dungeons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStage2;
        private System.Windows.Forms.Button btnStage1;
        private System.Windows.Forms.Button btnEndless;
        private System.Windows.Forms.Button button1;
    }
}