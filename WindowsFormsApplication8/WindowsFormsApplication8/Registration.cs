using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            var UsernameInput = this.textBox2.Text;
            var PasswordInput = this.textBox3.Text;
            var EmailInput = this.textBox1.Text;

            //Parent

            var parent = this.Parent as Form1;

            parent.registrationUsernameInput = UsernameInput;
            parent.registrationPasswordInput = PasswordInput;
            parent.registrationEmailInput = EmailInput;
            
        }
    }
}
