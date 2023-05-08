using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MetaLand
{
    public partial class Home : Form
    {
        Button button = new Button();
        public void CreateBtn()
        {
            for (int j = 0; j < 3; j++)//yatay
            {
                for (int i = 0; i < 4; i++)//dikey
                {
                    Button button = new Button
                    {
                        Name = "Button" + i + j,
                        Text = "Text" + i + j,
                        Size = new Size(100, 100),
                        Location = new Point(80 + j * 100, 40 + i * 100),
                        BackColor = Color.LightBlue,
                        Padding = new Padding(5, 5, 5, 5),
                        BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\alpte\OneDrive\Masaüstü\indir.jpg"),
                    };
                    this.Controls.Add(button);

                }
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBtn();
            Game form = new Game();
            form.Show();

        }
        private void button_click(object sender, EventArgs e)
        {
            
        }
    }
}
