using FlexHouseDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexHouseDashboard
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username, password;
            username = "admin";
            password = "ads";
            if ((txtUser.Text == username) && (txtPwd.Text == password))
            {
                new Principal().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Senha ou Usuário incorretos. Tente novamente");
                txtUser.Clear();
                txtPwd.Clear();
                txtPwd.Focus();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1 != null)
            {
                txtPwd.Text = "";
                txtUser.Text = "";
            }
        }

        private void cbkpwd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbkpwd.Checked)
            {
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                txtPwd.PasswordChar = '*';
            }
        }
    }
}
