namespace BirgerBolcher
{
    partial class MinTen
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
            this.DGVMinTen = new System.Windows.Forms.DataGridView();
            this.MinTenBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMinTen)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMinTen
            // 
            this.DGVMinTen.AllowUserToAddRows = false;
            this.DGVMinTen.AllowUserToDeleteRows = false;
            this.DGVMinTen.AllowUserToResizeColumns = false;
            this.DGVMinTen.AllowUserToResizeRows = false;
            this.DGVMinTen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMinTen.Location = new System.Drawing.Point(12, 58);
            this.DGVMinTen.Name = "DGVMinTen";
            this.DGVMinTen.Size = new System.Drawing.Size(246, 366);
            this.DGVMinTen.TabIndex = 7;
            // 
            // MinTenBackBtn
            // 
            this.MinTenBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.MinTenBackBtn.Location = new System.Drawing.Point(70, 12);
            this.MinTenBackBtn.Name = "MinTenBackBtn";
            this.MinTenBackBtn.Size = new System.Drawing.Size(145, 40);
            this.MinTenBackBtn.TabIndex = 6;
            this.MinTenBackBtn.Text = "Tilbage";
            this.MinTenBackBtn.UseVisualStyleBackColor = true;
            this.MinTenBackBtn.Click += new System.EventHandler(this.MinTenBackBtn_Click);
            // 
            // MinTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.DGVMinTen);
            this.Controls.Add(this.MinTenBackBtn);
            this.Name = "MinTen";
            this.Text = "MinTen";
            this.Load += new System.EventHandler(this.MinTen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMinTen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMinTen;
        private System.Windows.Forms.Button MinTenBackBtn;
    }
}