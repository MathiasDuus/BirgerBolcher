namespace BirgerBolcher
{
    partial class VisAlt
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
            this.components = new System.ComponentModel.Container();
            this.ShowAllBackBtn = new System.Windows.Forms.Button();
            this.birgerBolcherDBDataSet = new BirgerBolcher.BirgerBolcherDBDataSet();
            this.birgerBolcherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DGVVisAlt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.birgerBolcherDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birgerBolcherDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAllBackBtn
            // 
            this.ShowAllBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ShowAllBackBtn.Location = new System.Drawing.Point(12, 12);
            this.ShowAllBackBtn.Name = "ShowAllBackBtn";
            this.ShowAllBackBtn.Size = new System.Drawing.Size(113, 40);
            this.ShowAllBackBtn.TabIndex = 0;
            this.ShowAllBackBtn.Text = "Tilbage";
            this.ShowAllBackBtn.UseVisualStyleBackColor = true;
            this.ShowAllBackBtn.Click += new System.EventHandler(this.ShowAllBackBtn_Click);
            // 
            // birgerBolcherDBDataSet
            // 
            this.birgerBolcherDBDataSet.DataSetName = "BirgerBolcherDBDataSet";
            this.birgerBolcherDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birgerBolcherDBDataSetBindingSource
            // 
            this.birgerBolcherDBDataSetBindingSource.DataSource = this.birgerBolcherDBDataSet;
            this.birgerBolcherDBDataSetBindingSource.Position = 0;
            // 
            // DGVVisAlt
            // 
            this.DGVVisAlt.AllowUserToAddRows = false;
            this.DGVVisAlt.AllowUserToDeleteRows = false;
            this.DGVVisAlt.AllowUserToResizeColumns = false;
            this.DGVVisAlt.AllowUserToResizeRows = false;
            this.DGVVisAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVisAlt.Location = new System.Drawing.Point(12, 58);
            this.DGVVisAlt.Name = "DGVVisAlt";
            this.DGVVisAlt.Size = new System.Drawing.Size(744, 366);
            this.DGVVisAlt.TabIndex = 1;
            // 
            // VisAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 436);
            this.Controls.Add(this.DGVVisAlt);
            this.Controls.Add(this.ShowAllBackBtn);
            this.Name = "VisAlt";
            this.Text = "VisAlt";
            this.Load += new System.EventHandler(this.VisAlt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birgerBolcherDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birgerBolcherDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVisAlt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowAllBackBtn;
        private System.Windows.Forms.BindingSource birgerBolcherDBDataSetBindingSource;
        private BirgerBolcherDBDataSet birgerBolcherDBDataSet;
        private System.Windows.Forms.DataGridView DGVVisAlt;
    }
}