namespace BirgerBolcher
{
    partial class NotRedCandy
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
            this.DGVNotRedCandy = new System.Windows.Forms.DataGridView();
            this.NotRedCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotRedCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVNotRedCandy
            // 
            this.DGVNotRedCandy.AllowUserToAddRows = false;
            this.DGVNotRedCandy.AllowUserToDeleteRows = false;
            this.DGVNotRedCandy.AllowUserToResizeColumns = false;
            this.DGVNotRedCandy.AllowUserToResizeRows = false;
            this.DGVNotRedCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotRedCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVNotRedCandy.Name = "DGVNotRedCandy";
            this.DGVNotRedCandy.Size = new System.Drawing.Size(145, 366);
            this.DGVNotRedCandy.TabIndex = 5;
            // 
            // NotRedCandyBackBtn
            // 
            this.NotRedCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.NotRedCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.NotRedCandyBackBtn.Name = "NotRedCandyBackBtn";
            this.NotRedCandyBackBtn.Size = new System.Drawing.Size(145, 40);
            this.NotRedCandyBackBtn.TabIndex = 4;
            this.NotRedCandyBackBtn.Text = "Tilbage";
            this.NotRedCandyBackBtn.UseVisualStyleBackColor = true;
            this.NotRedCandyBackBtn.Click += new System.EventHandler(this.NotRedCandyBackBtn_Click);
            // 
            // NotRedCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 434);
            this.Controls.Add(this.DGVNotRedCandy);
            this.Controls.Add(this.NotRedCandyBackBtn);
            this.Name = "NotRedCandy";
            this.Text = "NotRedCandy";
            this.Load += new System.EventHandler(this.NotRedCandy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotRedCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVNotRedCandy;
        private System.Windows.Forms.Button NotRedCandyBackBtn;
    }
}