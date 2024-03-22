namespace HacoloCinema_Team2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            phimToolStripMenuItem = new ToolStripMenuItem();
            giờChiếuToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            đặtVéXemPhimToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem, phimToolStripMenuItem, giờChiếuToolStripMenuItem, đơnHàngToolStripMenuItem, đặtVéXemPhimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1135, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(152, 24);
            kháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // phimToolStripMenuItem
            // 
            phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            phimToolStripMenuItem.Size = new Size(111, 24);
            phimToolStripMenuItem.Text = "Quản lý phim";
            phimToolStripMenuItem.Click += phimToolStripMenuItem_Click;
            // 
            // giờChiếuToolStripMenuItem
            // 
            giờChiếuToolStripMenuItem.Name = "giờChiếuToolStripMenuItem";
            giờChiếuToolStripMenuItem.Size = new Size(138, 24);
            giờChiếuToolStripMenuItem.Text = "Quản lý giờ chiếu";
            giờChiếuToolStripMenuItem.Click += giờChiếuToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(140, 24);
            đơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // đặtVéXemPhimToolStripMenuItem
            // 
            đặtVéXemPhimToolStripMenuItem.Name = "đặtVéXemPhimToolStripMenuItem";
            đặtVéXemPhimToolStripMenuItem.Size = new Size(136, 24);
            đặtVéXemPhimToolStripMenuItem.Text = "Đặt vé xem phim";
            đặtVéXemPhimToolStripMenuItem.Click += đặtVéXemPhimToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 557);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Hacolo cinema";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem phimToolStripMenuItem;
        private ToolStripMenuItem giờChiếuToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem đặtVéXemPhimToolStripMenuItem;
    }
}