namespace BirgerBolcher
{
    partial class RedCandy
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
            this.DGVRedCandy = new System.Windows.Forms.DataGridView();
            this.RedCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRedCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRedCandy
            // 
            this.DGVRedCandy.AllowUserToAddRows = false;
            this.DGVRedCandy.AllowUserToDeleteRows = false;
            this.DGVRedCandy.AllowUserToResizeColumns = false;
            this.DGVRedCandy.AllowUserToResizeRows = false;
            this.DGVRedCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRedCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVRedCandy.Name = "DGVRedCandy";
            this.DGVRedCandy.Size = new System.Drawing.Size(145, 366);
            this.DGVRedCandy.TabIndex = 3;
            // 
            // RedCandyBackBtn
            // 
            this.RedCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.RedCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.RedCandyBackBtn.Name = "RedCandyBackBtn";
            this.RedCandyBackBtn.Size = new System.Drawing.Size(145, 40);
            this.RedCandyBackBtn.TabIndex = 2;
            this.RedCandyBackBtn.Text = "Tilbage";
            this.RedCandyBackBtn.UseVisualStyleBackColor = true;
            this.RedCandyBackBtn.Click += new System.EventHandler(this.RedCandyBackBtn_Click);
            // 
            // RedCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 440);
            this.Controls.Add(this.DGVRedCandy);
            this.Controls.Add(this.RedCandyBackBtn);
            this.Name = "RedCandy";
            this.Text = "RedCandy";
            this.Load += new System.EventHandler(this.RedCandy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRedCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRedCandy;
        private System.Windows.Forms.Button RedCandyBackBtn;
    }
}