namespace BirgerBolcher
{
    partial class RedBlueCanndy
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
            this.DGVRedBlueCandy = new System.Windows.Forms.DataGridView();
            this.RedBlueCandyBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRedBlueCandy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRedBlueCandy
            // 
            this.DGVRedBlueCandy.AllowUserToAddRows = false;
            this.DGVRedBlueCandy.AllowUserToDeleteRows = false;
            this.DGVRedBlueCandy.AllowUserToResizeColumns = false;
            this.DGVRedBlueCandy.AllowUserToResizeRows = false;
            this.DGVRedBlueCandy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRedBlueCandy.Location = new System.Drawing.Point(12, 58);
            this.DGVRedBlueCandy.Name = "DGVRedBlueCandy";
            this.DGVRedBlueCandy.Size = new System.Drawing.Size(145, 366);
            this.DGVRedBlueCandy.TabIndex = 5;
            // 
            // RedBlueCandyBackBtn
            // 
            this.RedBlueCandyBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.RedBlueCandyBackBtn.Location = new System.Drawing.Point(12, 12);
            this.RedBlueCandyBackBtn.Name = "RedBlueCandyBackBtn";
            this.RedBlueCandyBackBtn.Size = new System.Drawing.Size(145, 40);
            this.RedBlueCandyBackBtn.TabIndex = 4;
            this.RedBlueCandyBackBtn.Text = "Tilbage";
            this.RedBlueCandyBackBtn.UseVisualStyleBackColor = true;
            this.RedBlueCandyBackBtn.Click += new System.EventHandler(this.RedBlueCandyBackBtn_Click);
            // 
            // RedBlueCanndy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 450);
            this.Controls.Add(this.DGVRedBlueCandy);
            this.Controls.Add(this.RedBlueCandyBackBtn);
            this.Name = "RedBlueCanndy";
            this.Text = "RedBlueCanndy";
            this.Load += new System.EventHandler(this.RedBlueCanndy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRedBlueCandy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRedBlueCandy;
        private System.Windows.Forms.Button RedBlueCandyBackBtn;
    }
}