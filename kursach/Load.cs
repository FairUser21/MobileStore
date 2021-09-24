using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        int startpoint = 0; //указали стартовую переменную
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1; //указали переменной увеличиваться на 1
            progressBar1.Value = startpoint; //присвоили прогресс бару переменную
            if(progressBar1.Value == 100) //функция которая будет заполнять прогресс бар
            {
                progressBar1.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();//запуск таймера для прогресс бара

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
