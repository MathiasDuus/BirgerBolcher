namespace BirgerBolcher
{
    partial class HeavyCandy
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
            this.DGVHeavyCandy = new System.Windows.Forms.DataGridView();
            this.HeavyCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeavyCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHeavyCandy
            // 
            this.DGVHeavyCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHeavyCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVHeavyCandy.Name = "DGVHeavyCandy";
            this.DGVHeavyCandy.Size = new System.Drawing.Size(744, 112);
            this.DGVHeavyCandy.TabIndex = 4;
            // 
            // HeavyCandyBackBtn
            // 
            this.HeavyCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.HeavyCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.HeavyCandyBackBtn.Name = "HeavyCandyBackBtn";
            this.HeavyCandyBackBtn.Size = new System.Drawing.Size(113, 40);
            this.HeavyCandyBackBtn.TabIndex = 3;
            this.HeavyCandyBackBtn.Text = "Tilbage";
            this.HeavyCandyBackBtn.UseVisualStyleBackColor = true;
            this.HeavyCandyBackBtn.Click += new System.EventHandler(this.HeavyCandyBackBtn_Click);
            // 
            // HeavyCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 186);
            this.Controls.Add(this.DGVHeavyCandy);
            this.Controls.Add(this.HeavyCandyBackBtn);
            this.Name = "HeavyCandy";
            this.Text = "HeavyCandy";
            this.Load += new System.EventHandler(this.HeavyCandy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeavyCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHeavyCandy;
        private System.Windows.Forms.Button HeavyCandyBackBtn;
    }
}