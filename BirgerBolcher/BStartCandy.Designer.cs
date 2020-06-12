namespace BirgerBolcher
{
    partial class BStartCandy
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
            this.DGVBStartCandy = new System.Windows.Forms.DataGridView();
            this.BStartCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBStartCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBStartCandy
            // 
            this.DGVBStartCandy.AllowUserToAddRows = false;
            this.DGVBStartCandy.AllowUserToDeleteRows = false;
            this.DGVBStartCandy.AllowUserToResizeColumns = false;
            this.DGVBStartCandy.AllowUserToResizeRows = false;
            this.DGVBStartCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBStartCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVBStartCandy.Name = "DGVBStartCandy";
            this.DGVBStartCandy.Size = new System.Drawing.Size(145, 366);
            this.DGVBStartCandy.TabIndex = 7;
            // 
            // BStartCandyBackBtn
            // 
            this.BStartCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.BStartCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.BStartCandyBackBtn.Name = "BStartCandyBackBtn";
            this.BStartCandyBackBtn.Size = new System.Drawing.Size(145, 40);
            this.BStartCandyBackBtn.TabIndex = 6;
            this.BStartCandyBackBtn.Text = "Tilbage";
            this.BStartCandyBackBtn.UseVisualStyleBackColor = true;
            this.BStartCandyBackBtn.Click += new System.EventHandler(this.BStartCandyBackBtn_Click);
            // 
            // BStartCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 450);
            this.Controls.Add(this.DGVBStartCandy);
            this.Controls.Add(this.BStartCandyBackBtn);
            this.Name = "BStartCandy";
            this.Text = "BStartCandy";
            this.Load += new System.EventHandler(this.BStartCandy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBStartCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBStartCandy;
        private System.Windows.Forms.Button BStartCandyBackBtn;
    }
}