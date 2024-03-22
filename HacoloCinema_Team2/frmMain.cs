using BussinessObject.Models;
using Repositories.mintnn;
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
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }
        private IWalletRepository _walletRepository= new WalletRepository();
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Customer != null && Admin == null)
            {
                EnableMenuForStaff(false);
                EnableMenuForCustomer(true);
            }
            if (Customer == null && Admin != null)
            {
                EnableMenuForStaff(true);
                EnableMenuForCustomer(false);
            }
        }
        private void EnableMenuForStaff(bool status)
        {
            kháchHàngToolStripMenuItem.Visible = status;
            phimToolStripMenuItem.Visible = status;
            giờChiếuToolStripMenuItem.Visible = status;
            đơnHàngToolStripMenuItem.Visible = status;
            đặtVéXemPhimStaffToolStripMenuItem.Visible = status;
        }
        private void EnableMenuForCustomer(bool status)
        {
            víTiềnToolStripMenuItem.Visible = status;
            đặtVéXemPhimCustomerToolStripMenuItem.Visible= status;
            profileCủaTôiToolStripMenuItem.Visible = status;
            lịchSửĐặtHàngToolStripMenuItem.Visible = status;
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
            
        }
        private void đặtVéXemPhimStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhimDangChieu frmPhimDangChieu = new frmPhimDangChieu();
            frmPhimDangChieu.MdiParent = this;
            frmPhimDangChieu.Show();
        }

        private void víTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_walletRepository.HaveWallet(this.Customer.CustomerId))
            {
                frmWallet frmWallet = new frmWallet(this.Customer.CustomerId);
                frmWallet.MdiParent = this;
                frmWallet.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa tạo ví!", "Ví của bạn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void đặtVéXemPhimCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhimDangChieu frmPhimDangChieu = new frmPhimDangChieu();
            frmPhimDangChieu.MdiParent = this;
            frmPhimDangChieu.Show();
        }

        private void profileCủaTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchSửĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.MdiParent = this;
            frmOrder.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
