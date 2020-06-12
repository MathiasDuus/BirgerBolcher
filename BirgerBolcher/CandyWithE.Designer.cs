namespace BirgerBolcher
{
    partial class CandyWithE
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
            this.DGVCandyWithE = new System.Windows.Forms.DataGridView();
            this.CandyWithEBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandyWithE)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCandyWithE
            // 
            this.DGVCandyWithE.AllowUserToAddRows = false;
            this.DGVCandyWithE.AllowUserToDeleteRows = false;
            this.DGVCandyWithE.AllowUserToResizeColumns = false;
            this.DGVCandyWithE.AllowUserToResizeRows = false;
            this.DGVCandyWithE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCandyWithE.Location = new System.Drawing.Point(12, 58);
            this.DGVCandyWithE.Name = "DGVCandyWithE";
            this.DGVCandyWithE.Size = new System.Drawing.Size(145, 366);
            this.DGVCandyWithE.TabIndex = 7;
            // 
            // CandyWithEBackBtn
            // 
            this.CandyWithEBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.CandyWithEBackBtn.Location = new System.Drawing.Point(12, 12);
            this.CandyWithEBackBtn.Name = "CandyWithEBackBtn";
            this.CandyWithEBackBtn.Size = new System.Drawing.Size(145, 40);
            this.CandyWithEBackBtn.TabIndex = 6;
            this.CandyWithEBackBtn.Text = "Tilbage";
            this.CandyWithEBackBtn.UseVisualStyleBackColor = true;
            this.CandyWithEBackBtn.Click += new System.EventHandler(this.RedBlueCandyBackBtn_Click);
            // 
            // CandyWithE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 450);
            this.Controls.Add(this.DGVCandyWithE);
            this.Controls.Add(this.CandyWithEBackBtn);
            this.Name = "CandyWithE";
            this.Text = "CandyWithE";
            this.Load += new System.EventHandler(this.CandyWithE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCandyWithE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCandyWithE;
        private System.Windows.Forms.Button CandyWithEBackBtn;
    }
}