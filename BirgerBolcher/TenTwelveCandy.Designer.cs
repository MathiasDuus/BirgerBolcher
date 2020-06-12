namespace BirgerBolcher
{
    partial class TenTwelveCandy
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
            this.DGVTenTwelveCandy = new System.Windows.Forms.DataGridView();
            this.TenTwelveCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenTwelveCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTenTwelveCandy
            // 
            this.DGVTenTwelveCandy.AllowUserToAddRows = false;
            this.DGVTenTwelveCandy.AllowUserToDeleteRows = false;
            this.DGVTenTwelveCandy.AllowUserToResizeColumns = false;
            this.DGVTenTwelveCandy.AllowUserToResizeRows = false;
            this.DGVTenTwelveCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTenTwelveCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVTenTwelveCandy.Name = "DGVTenTwelveCandy";
            this.DGVTenTwelveCandy.Size = new System.Drawing.Size(145, 366);
            this.DGVTenTwelveCandy.TabIndex = 7;
            // 
            // TenTwelveCandyBackBtn
            // 
            this.TenTwelveCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TenTwelveCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.TenTwelveCandyBackBtn.Name = "TenTwelveCandyBackBtn";
            this.TenTwelveCandyBackBtn.Size = new System.Drawing.Size(145, 40);
            this.TenTwelveCandyBackBtn.TabIndex = 6;
            this.TenTwelveCandyBackBtn.Text = "Tilbage";
            this.TenTwelveCandyBackBtn.UseVisualStyleBackColor = true;
            this.TenTwelveCandyBackBtn.Click += new System.EventHandler(this.TenTwelveCandyBackBtn_Click);
            // 
            // TenTwelveCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 450);
            this.Controls.Add(this.DGVTenTwelveCandy);
            this.Controls.Add(this.TenTwelveCandyBackBtn);
            this.Name = "TenTwelveCandy";
            this.Text = "TenTwelveCandy";
            this.Load += new System.EventHandler(this.TenTwelveCandy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenTwelveCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTenTwelveCandy;
        private System.Windows.Forms.Button TenTwelveCandyBackBtn;
    }
}