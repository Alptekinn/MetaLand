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
using MetaLand.Repository;

namespace MetaLand
{
    public partial class Home : Form
    {
        Database db = new Database();
        public Home()
        {
            InitializeComponent();
        }

        Button button = new Button();
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtUNickname.Clear();
            txtPass.Clear();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.UserNickname = txtUNickname.Text;
            User.Password = txtPass.Text;
            if (db.Login() == 0)
            {
                Game gameform = new Game();
                gameform.FormClosed += form_FormClosed;
                gameform.Show();
                this.Hide();
            }
            else if (db.Login()==1) 
            {
                Manager manager = new Manager();
                manager.FormClosed += form_FormClosed;
                manager.Show();
                this.Hide();
            }
            else
            {
                label2.Text = "Şifreler Uyuşmuyor!!!";
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            txtPass.PasswordChar = '*';
            txtRpass.PasswordChar = '*';
            txtRepass.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            btnDirectory.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
            btnDirectory.Visible = true;
        }

        private void btnRegistera_Click(object sender, EventArgs e)
        {
            if (txtRpass.Text != txtRepass.Text)
            {
                label1.Text = "Şifreler Uyuşmuyor!!!";
            }
            else
            {
                User.UserName = txtRName.Text;
                User.UserSurname = txtRSurname.Text;
                User.UserNickname = txtNickname.Text;
                User.Password = txtRpass.Text;
                User.StartDate = DateTime.Now;

                pnlRegister.Visible = false;
                pnlLogin.Visible = true;
                btnDirectory.Visible = false;
                db.Register(0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Manager us = new Manager();
            us.Show();
            this.Close();
        }
    }
}
