using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FlexHouseDashboard
{


    public partial class Dashboard : Form
    {
        private static void ArredondarPainel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - raio, panel.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - raio, raio, raio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
