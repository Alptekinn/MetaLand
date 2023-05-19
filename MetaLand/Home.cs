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
        string[] dizi = { "31", "32", "kerhane", "31.7", "31.5", "31.6", "31.8", "31.9" };
        private Image CropImage(Image source, int x, int y, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            }
            return bmp;
        }
        public void CreateBtn()
        {
            PictureBox fullImagePictureBox = new PictureBox();
            fullImagePictureBox.Image = Image.FromFile("C:\\Users\\alpte\\OneDrive\\Masaüstü\\indir.jpg");
            fullImagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            fullImagePictureBox.Visible = false;

            this.Controls.Add(fullImagePictureBox);
            for (int j = 0; j < 3; j++)//yatay
            {
                for (int i = 0; i < 4; i++)//dikey
                {
                    Button button = new Button
                    {
                        Name = "Button" + i + j,
                        Size = new Size(100, 100),
                        Location = new Point(80 + j*100, 40 + i * 100),
                        BackColor = Color.LightBlue,
                        Padding = new Padding(5, 5, 5, 5),
                        BackgroundImage = CropImage(fullImagePictureBox.Image, i * 100, 0, 100, 100),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Text = dizi[i],
                    };
                    this.Controls.Add(button);

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User.UserNickname = txtUNickname.Text;
            User.Password = txtPass.Text;
            if (db.Login())
            {
                Game form = new Game();
                form.Show();
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
                db.Register();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Manager us = new Manager();
            us.Show();
            this.Hide();
        }
    }
}
