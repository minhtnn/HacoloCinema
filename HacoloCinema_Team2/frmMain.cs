using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacoloCinema_Team2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerManagement frmCustomerManagement = new frmCustomerManagement();
            frmCustomerManagement.MdiParent = this;
            frmCustomerManagement.Show();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovie frmMovie = new frmMovie();
            frmMovie.MdiParent = this;
            frmMovie.Show();
        }

        private void giờChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowtimeManagement frmShowtimeManagement = new frmShowtimeManagement();
            frmShowtimeManagement.MdiParent = this;
            frmShowtimeManagement.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.MdiParent = this;
            frmOrder.Show();
        }

        private void đặtVéXemPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhimDangChieu frmPhimDangChieu = new frmPhimDangChieu();
            frmPhimDangChieu.MdiParent = this;
            frmPhimDangChieu.Show();
        }
    }
}
