using MetaLand.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MetaLand
{
    public partial class Manager : Form
    {
        Database db = new Database();
        public Manager()
        {
            InitializeComponent();

        }
        private void btnGameSet_Click(object sender, EventArgs e)
        {
            db.PullGameAreaData();
            db.PullAmountData();
            txtAreaWidth.Text=GameSetting.AreaWidth.ToString();
            txtAreaHeigth.Text= GameSetting.AreaHeight.ToString();
            txtMoney.Text = Amount.AmountMoney.ToString();
            txtFood.Text = Amount.AmountFood.ToString();
            txtItem.Text = Amount.AmountItem.ToString();
            panel3.Visible = true;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            this.tbl_UsersTableAdapter.Fill(this.metaLandDataSet.Tbl_Users);

        }

        private void btnUserSet_Click(object sender, EventArgs e)
        {
            db.SetUserData(dataGridView1);
            //DataTable dataTable = new DataTable();
            //dataGridView1.DataSource = dataTable;
            //db.InsertData(dataTable);
        }


        private void btnUserSetShow_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;  panel3.Visible = false;
        }

        private void btnAreaSave_Click(object sender, EventArgs e)
        {
            GameSetting.AreaWidth = Convert.ToInt32(txtAreaWidth.Text);
            GameSetting.AreaHeight = Convert.ToInt32(txtAreaHeigth.Text);
            db.UpdateAreaSize();
            lblInfo.Text = "Kayıt işlemi başarılı";
        }

        private void btnUpdateAmount_Click(object sender, EventArgs e)
        {
            Amount.AmountFood = Convert.ToInt32(txtFood.Text);
            Amount.AmountItem = Convert.ToInt32(txtItem.Text);
            Amount.AmountMoney = Convert.ToInt32(txtMoney.Text);
            db.UpdateAmount();
            lblInfo.Text = "Kayıt işlemi başarılı";
        }

        private void btnShowGameArea_Click(object sender, EventArgs e)
        {
            Game gameform = new Game();
            gameform.ShowDialog();
        }
    }
}
