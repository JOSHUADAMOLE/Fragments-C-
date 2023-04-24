using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel2.Show();
        }

        public string registrationEmailInput
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public string registrationUsernameInput
        {
            set
            {
                textBox2.Text = value;             
            }
        }
        public string registrationPasswordInput
        {
            set
            {
                textBox3.Text = value;
            }
        }

        private void btn_rgs_Click(object sender, EventArgs e)
        {
            registration1.Show();
            registration1.BringToFront();

            login1.Hide();
            homecontrol1.Hide();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            login1.Show();
            login1.BringToFront();

            registration1.Hide();
            homecontrol1.Hide();
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            homecontrol1.Show();
            homecontrol1.BringToFront();

            login1.Hide();
            registration1.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
