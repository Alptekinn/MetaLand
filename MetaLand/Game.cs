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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetaLand
{
    public partial class Game : Form
    {

        private Timer timer;
        private int seconds;

        public Game()
        {
            InitializeComponent();

            // Timer oluştur
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += timerJob_Tick;
        }
        Database db = new Database();
        GameSetting gameSetting = new GameSetting();
        public List<KryptonCheckButton> buttonlist = new List<KryptonCheckButton>();
        public void addlistButton()
        {
            for (int i = 1; i < 21; i++)
            {
                string buttonName = "Area"+i.ToString();
                KryptonCheckButton button = Controls.Find(buttonName, true).FirstOrDefault() as KryptonCheckButton;

                if (button != null)
                {
                    buttonlist.Add(button);
                }
            }
            List<string> buttonNamesFromDatabase = db.PullAreaName();

            for (int i = 0; i < buttonlist.Count; i++)
            {
                buttonlist[i].Text = buttonNamesFromDatabase[i];
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {

            KryptonCheckButton clickedButton = (KryptonCheckButton)sender;

            if (clickedButton.Text == "Boş") 
            {
                clickedButton.Checked= false;
                MessageBox.Show("Bu alan hizmete açık değildir emlak noktalarından satın alabilirsiniz");
            }

            

        }
        private void Button_CheckedChanged(object sender, EventArgs e)
        {
            KryptonCheckButton clickedButton = (KryptonCheckButton)sender;

            if (clickedButton.Checked)
            {
                foreach (KryptonCheckButton button in buttonlist)
                {
                    if (button != clickedButton)
                    {
                        button.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (KryptonCheckButton button in buttonlist)
                {
                    button.Enabled = true;
                }
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            db.PullGameAreaData();
            addlistButton();
            lblItemData.Text = Amount.AmountItem.ToString();
            lblFoodData.Text = Amount.AmountFood.ToString();
            lblMoneyData.Text = Amount.AmountMoney.ToString();
            for (int i = 1; i <= 24; i++)
            {
                cmbWorkHour.Items.Add(i);
                cmbUrunAdet.Items.Add(i);
            }

            if (GameSetting.AreaWidth <= 3 && GameSetting.AreaHeight <= 3)
            {
                this.Size = new Size(800, 600);
                pnlInfo.Location = new Point(633, 3);
                pnlDeal.Location = new Point(3, 400);
                panel3.Location = new Point(379, 400);
                panel3.Location = new Point(660, 400);

            }
            //db.PullAreaName();
            gameSetting.SetArea();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            KryptonCheckButton clickedButton = (KryptonCheckButton)sender;
            // db.pullAreaInfo(clickedButton.Name);

        }

        private void timerJob_Tick(object sender, EventArgs e)
        {
            this.seconds++;

            TimeSpan time = TimeSpan.FromSeconds(this.seconds);

            // Saat, dakika ve saniye bilgisini al
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;

            string timeString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

            label3.Text = timeString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* UserDetail userDetailform = new UserDetail();
            userDetailform.Show();
           */
           timer.Start();
        }
    }
}
