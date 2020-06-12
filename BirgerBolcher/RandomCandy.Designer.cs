namespace BirgerBolcher
{
    partial class RandomCandy
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
            this.RandomCandyBackBtn = new System.Windows.Forms.Button();
            this.DGVRanCandy = new System.Windows.Forms.DataGridView();
            this.RanSearchTxtbox = new System.Windows.Forms.TextBox();
            this.RanSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRanCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomCandyBackBtn
            // 
            this.RandomCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.RandomCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.RandomCandyBackBtn.Name = "RandomCandyBackBtn";
            this.RandomCandyBackBtn.Size = new System.Drawing.Size(113, 40);
            this.RandomCandyBackBtn.TabIndex = 1;
            this.RandomCandyBackBtn.Text = "Tilbage";
            this.RandomCandyBackBtn.UseVisualStyleBackColor = true;
            this.RandomCandyBackBtn.Click += new System.EventHandler(this.RandomCandyBackBtn_Click);
            // 
            // DGVRanCandy
            // 
            this.DGVRanCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRanCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVRanCandy.Name = "DGVRanCandy";
            this.DGVRanCandy.Size = new System.Drawing.Size(744, 68);
            this.DGVRanCandy.TabIndex = 2;
            // 
            // RanSearchTxtbox
            // 
            this.RanSearchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.RanSearchTxtbox.Location = new System.Drawing.Point(362, 15);
            this.RanSearchTxtbox.Name = "RanSearchTxtbox";
            this.RanSearchTxtbox.Size = new System.Drawing.Size(226, 35);
            this.RanSearchTxtbox.TabIndex = 3;
            // 
            // RanSearchBtn
            // 
            this.RanSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.RanSearchBtn.Location = new System.Drawing.Point(594, 12);
            this.RanSearchBtn.Name = "RanSearchBtn";
            this.RanSearchBtn.Size = new System.Drawing.Size(113, 40);
            this.RanSearchBtn.TabIndex = 4;
            this.RanSearchBtn.Text = "Søg";
            this.RanSearchBtn.UseVisualStyleBackColor = true;
            this.RanSearchBtn.Click += new System.EventHandler(this.RanSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indtast et bogstav";
            // 
            // RandomCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RanSearchBtn);
            this.Controls.Add(this.RanSearchTxtbox);
            this.Controls.Add(this.DGVRanCandy);
            this.Controls.Add(this.RandomCandyBackBtn);
            this.Name = "RandomCandy";
            this.Text = "RandomCandy";
            ((System.ComponentModel.ISupportInitialize)(this.DGVRanCandy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomCandyBackBtn;
        private System.Windows.Forms.DataGridView DGVRanCandy;
        private System.Windows.Forms.TextBox RanSearchTxtbox;
        private System.Windows.Forms.Button RanSearchBtn;
        private System.Windows.Forms.Label label1;
    }
}