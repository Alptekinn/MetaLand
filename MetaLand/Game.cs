using ComponentFactory.Krypton.Toolkit;
using MetaLand.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Database db=new Database();

        private void Game_Load(object sender, EventArgs e)
        {
            kryptonButton1.BackgroundImage = Image.FromFile("C:\\Users\\alpte\\OneDrive\\Masaüstü\\indir.jpg");
            db.PullAmountData();
            lblItemData.Text=Amount.AmountFood.ToString();
            lblFoodData.Text=Amount.AmountFood.ToString();
            lblMoneyData.Text=Amount.AmountFood.ToString();
        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true ? false: true;
            foreach (Control c in this.Controls)
            {
                if (c is KryptonCheckButton)
                {
                    BackgroundImage = Image.FromFile("C:\\Users\\alpte\\OneDrive\\Masaüstü\\indir.jpg");
                }
            }

        }
    }
}
