namespace MetaLand
{
    partial class Manager
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
            this.btnUserSet = new System.Windows.Forms.Button();
            this.btnGameSet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Oyuncuverisi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserSet
            // 
            this.btnUserSet.Location = new System.Drawing.Point(631, 12);
            this.btnUserSet.Name = "btnUserSet";
            this.btnUserSet.Size = new System.Drawing.Size(177, 78);
            this.btnUserSet.TabIndex = 0;
            this.btnUserSet.Text = "User Setting";
            this.btnUserSet.UseVisualStyleBackColor = true;
            // 
            // btnGameSet
            // 
            this.btnGameSet.Location = new System.Drawing.Point(631, 131);
            this.btnGameSet.Name = "btnGameSet";
            this.btnGameSet.Size = new System.Drawing.Size(177, 87);
            this.btnGameSet.TabIndex = 1;
            this.btnGameSet.Text = "Game Setting";
            this.btnGameSet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oyuncuverisi1,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Oyuncuverisi1
            // 
            this.Oyuncuverisi1.HeaderText = "Oyuncu Verisi";
            this.Oyuncuverisi1.MinimumWidth = 6;
            this.Oyuncuverisi1.Name = "Oyuncuverisi1";
            this.Oyuncuverisi1.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Oyuncu verisi 2";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "veri3";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGameSet);
            this.Controls.Add(this.btnUserSet);
            this.Name = "Manager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSet;
        private System.Windows.Forms.Button btnGameSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oyuncuverisi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}