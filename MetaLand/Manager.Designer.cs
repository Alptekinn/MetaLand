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
            this.components = new System.ComponentModel.Container();
            this.btnUserSetShow = new System.Windows.Forms.Button();
            this.btnGameSet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserSet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNickNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metaLandDataSet = new MetaLand.MetaLandDataSet();
            this.tbl_UsersTableAdapter = new MetaLand.MetaLandDataSetTableAdapters.Tbl_UsersTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateAmount = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblGameArea = new System.Windows.Forms.Label();
            this.lblGameArea0 = new System.Windows.Forms.Label();
            this.btnAreaSave = new System.Windows.Forms.Button();
            this.txtAreaHeigth = new System.Windows.Forms.TextBox();
            this.txtAreaWidth = new System.Windows.Forms.TextBox();
            this.btnShowGameArea = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaLandDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserSetShow
            // 
            this.btnUserSetShow.Location = new System.Drawing.Point(498, 109);
            this.btnUserSetShow.Name = "btnUserSetShow";
            this.btnUserSetShow.Size = new System.Drawing.Size(177, 81);
            this.btnUserSetShow.TabIndex = 0;
            this.btnUserSetShow.Text = "Kullanıcı Ayarları";
            this.btnUserSetShow.UseVisualStyleBackColor = true;
            this.btnUserSetShow.Click += new System.EventHandler(this.btnUserSetShow_Click);
            // 
            // btnGameSet
            // 
            this.btnGameSet.Location = new System.Drawing.Point(498, 12);
            this.btnGameSet.Name = "btnGameSet";
            this.btnGameSet.Size = new System.Drawing.Size(177, 81);
            this.btnGameSet.TabIndex = 1;
            this.btnGameSet.Text = "Oyun Ayarları";
            this.btnGameSet.UseVisualStyleBackColor = true;
            this.btnGameSet.Click += new System.EventHandler(this.btnGameSet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 409);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUserSet);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 344);
            this.panel1.TabIndex = 3;
            // 
            // btnUserSet
            // 
            this.btnUserSet.Location = new System.Drawing.Point(377, 313);
            this.btnUserSet.Name = "btnUserSet";
            this.btnUserSet.Size = new System.Drawing.Size(75, 23);
            this.btnUserSet.TabIndex = 4;
            this.btnUserSet.Text = "Kaydet";
            this.btnUserSet.UseVisualStyleBackColor = true;
            this.btnUserSet.Click += new System.EventHandler(this.btnUserSet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userSurnameDataGridViewTextBoxColumn,
            this.userNickNameDataGridViewTextBoxColumn,
            this.userPassDataGridViewTextBoxColumn,
            this.amountFoodDataGridViewTextBoxColumn,
            this.amountItemDataGridViewTextBoxColumn,
            this.amountMoneyDataGridViewTextBoxColumn,
            this.gameStartDateDataGridViewTextBoxColumn,
            this.userTypeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userSurnameDataGridViewTextBoxColumn
            // 
            this.userSurnameDataGridViewTextBoxColumn.DataPropertyName = "User_Surname";
            this.userSurnameDataGridViewTextBoxColumn.HeaderText = "User_Surname";
            this.userSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userSurnameDataGridViewTextBoxColumn.Name = "userSurnameDataGridViewTextBoxColumn";
            this.userSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNickNameDataGridViewTextBoxColumn
            // 
            this.userNickNameDataGridViewTextBoxColumn.DataPropertyName = "User_NickName";
            this.userNickNameDataGridViewTextBoxColumn.HeaderText = "User_NickName";
            this.userNickNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNickNameDataGridViewTextBoxColumn.Name = "userNickNameDataGridViewTextBoxColumn";
            this.userNickNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPassDataGridViewTextBoxColumn
            // 
            this.userPassDataGridViewTextBoxColumn.DataPropertyName = "User_Pass";
            this.userPassDataGridViewTextBoxColumn.HeaderText = "User_Pass";
            this.userPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPassDataGridViewTextBoxColumn.Name = "userPassDataGridViewTextBoxColumn";
            this.userPassDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountFoodDataGridViewTextBoxColumn
            // 
            this.amountFoodDataGridViewTextBoxColumn.DataPropertyName = "AmountFood";
            this.amountFoodDataGridViewTextBoxColumn.HeaderText = "AmountFood";
            this.amountFoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountFoodDataGridViewTextBoxColumn.Name = "amountFoodDataGridViewTextBoxColumn";
            this.amountFoodDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountItemDataGridViewTextBoxColumn
            // 
            this.amountItemDataGridViewTextBoxColumn.DataPropertyName = "AmountItem";
            this.amountItemDataGridViewTextBoxColumn.HeaderText = "AmountItem";
            this.amountItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountItemDataGridViewTextBoxColumn.Name = "amountItemDataGridViewTextBoxColumn";
            this.amountItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountMoneyDataGridViewTextBoxColumn
            // 
            this.amountMoneyDataGridViewTextBoxColumn.DataPropertyName = "AmountMoney";
            this.amountMoneyDataGridViewTextBoxColumn.HeaderText = "AmountMoney";
            this.amountMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountMoneyDataGridViewTextBoxColumn.Name = "amountMoneyDataGridViewTextBoxColumn";
            this.amountMoneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameStartDateDataGridViewTextBoxColumn
            // 
            this.gameStartDateDataGridViewTextBoxColumn.DataPropertyName = "GameStartDate";
            this.gameStartDateDataGridViewTextBoxColumn.HeaderText = "GameStartDate";
            this.gameStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameStartDateDataGridViewTextBoxColumn.Name = "gameStartDateDataGridViewTextBoxColumn";
            this.gameStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeDataGridViewCheckBoxColumn
            // 
            this.userTypeDataGridViewCheckBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewCheckBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewCheckBoxColumn.Name = "userTypeDataGridViewCheckBoxColumn";
            this.userTypeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "Tbl_Users";
            this.tblUsersBindingSource.DataSource = this.metaLandDataSet;
            // 
            // metaLandDataSet
            // 
            this.metaLandDataSet.DataSetName = "MetaLandDataSet";
            this.metaLandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInfo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtFood);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnUpdateAmount);
            this.panel3.Controls.Add(this.txtItem);
            this.panel3.Controls.Add(this.txtMoney);
            this.panel3.Controls.Add(this.lblGameArea);
            this.panel3.Controls.Add(this.lblGameArea0);
            this.panel3.Controls.Add(this.btnAreaSave);
            this.panel3.Controls.Add(this.txtAreaHeigth);
            this.panel3.Controls.Add(this.txtAreaWidth);
            this.panel3.Location = new System.Drawing.Point(3, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 594);
            this.panel3.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(336, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Başlangıç Yemek Miktarı :";
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(187, 73);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(100, 22);
            this.txtFood.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Başlangıç Eşya Miktarı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Başlangıç Para Miktarı :";
            // 
            // btnUpdateAmount
            // 
            this.btnUpdateAmount.Location = new System.Drawing.Point(211, 110);
            this.btnUpdateAmount.Name = "btnUpdateAmount";
            this.btnUpdateAmount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAmount.TabIndex = 14;
            this.btnUpdateAmount.Text = "Kaydet";
            this.btnUpdateAmount.UseVisualStyleBackColor = true;
            this.btnUpdateAmount.Click += new System.EventHandler(this.btnUpdateAmount_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(186, 41);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 13;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(186, 10);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 12;
            // 
            // lblGameArea
            // 
            this.lblGameArea.AutoSize = true;
            this.lblGameArea.Location = new System.Drawing.Point(9, 197);
            this.lblGameArea.Name = "lblGameArea";
            this.lblGameArea.Size = new System.Drawing.Size(145, 16);
            this.lblGameArea.TabIndex = 4;
            this.lblGameArea.Text = "Oyun Alanı Yüksekliği : ";
            // 
            // lblGameArea0
            // 
            this.lblGameArea0.AutoSize = true;
            this.lblGameArea0.Location = new System.Drawing.Point(9, 163);
            this.lblGameArea0.Name = "lblGameArea0";
            this.lblGameArea0.Size = new System.Drawing.Size(132, 16);
            this.lblGameArea0.TabIndex = 3;
            this.lblGameArea0.Text = "Oyun Alanı Genişliği :";
            // 
            // btnAreaSave
            // 
            this.btnAreaSave.Location = new System.Drawing.Point(212, 228);
            this.btnAreaSave.Name = "btnAreaSave";
            this.btnAreaSave.Size = new System.Drawing.Size(75, 23);
            this.btnAreaSave.TabIndex = 2;
            this.btnAreaSave.Text = "Kaydet";
            this.btnAreaSave.UseVisualStyleBackColor = true;
            this.btnAreaSave.Click += new System.EventHandler(this.btnAreaSave_Click);
            // 
            // txtAreaHeigth
            // 
            this.txtAreaHeigth.Location = new System.Drawing.Point(186, 191);
            this.txtAreaHeigth.Name = "txtAreaHeigth";
            this.txtAreaHeigth.Size = new System.Drawing.Size(100, 22);
            this.txtAreaHeigth.TabIndex = 1;
            // 
            // txtAreaWidth
            // 
            this.txtAreaWidth.Location = new System.Drawing.Point(186, 160);
            this.txtAreaWidth.Name = "txtAreaWidth";
            this.txtAreaWidth.Size = new System.Drawing.Size(100, 22);
            this.txtAreaWidth.TabIndex = 0;
            // 
            // btnShowGameArea
            // 
            this.btnShowGameArea.Location = new System.Drawing.Point(498, 208);
            this.btnShowGameArea.Name = "btnShowGameArea";
            this.btnShowGameArea.Size = new System.Drawing.Size(177, 81);
            this.btnShowGameArea.TabIndex = 7;
            this.btnShowGameArea.Text = "Oyun Alanını Göster";
            this.btnShowGameArea.UseVisualStyleBackColor = true;
            this.btnShowGameArea.Click += new System.EventHandler(this.btnShowGameArea_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 605);
            this.Controls.Add(this.btnShowGameArea);
            this.Controls.Add(this.btnGameSet);
            this.Controls.Add(this.btnUserSetShow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaLandDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSetShow;
        private System.Windows.Forms.Button btnGameSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUserSet;
        private MetaLandDataSet metaLandDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private MetaLandDataSetTableAdapters.Tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNickNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowGameArea;
        private System.Windows.Forms.Label lblGameArea;
        private System.Windows.Forms.Label lblGameArea0;
        private System.Windows.Forms.Button btnAreaSave;
        private System.Windows.Forms.TextBox txtAreaHeigth;
        private System.Windows.Forms.TextBox txtAreaWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateAmount;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblInfo;
    }
}