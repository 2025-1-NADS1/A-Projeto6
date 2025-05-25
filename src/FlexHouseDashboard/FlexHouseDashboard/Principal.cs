using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexHouseDashboard
{
    public partial class Principal : Form
    {
        private Form formularioAtivo = null;

        private void AbrirFormularioNoPainel(Form formFilho)
        {
            if (formularioAtivo != null)
                formularioAtivo.Close();

            formularioAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            panelTroca.Controls.Clear();
            panelTroca.Controls.Add(formFilho);
            formFilho.Show();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new Dashboard());
        }

        public Principal()
        {
            InitializeComponent();
            AbrirFormularioNoPainel(new Dashboard());

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDash_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new Dashboard());
        }

        private void btnNotif_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new Notificações());
        }

        private void btnLogoff_Click_1(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void panelTroca_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new Consumo());
        }
    }
}
