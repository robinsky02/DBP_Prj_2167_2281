using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_2167_2281
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Home home;
        Reserv reserv;
        Site site;
        Cust cust;
        Emp emp;
        Option opt;
        private void Form1_Load(object sender, EventArgs e)
        {
            home = new Home();
            home.MdiParent = this;
            home.Show();
        }
        private void 예약관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reserv == null || reserv.IsDisposed)
            {
                reserv = new Reserv();
                reserv.MdiParent = this;
                reserv.Show();
            }
        }
        private void 사이트관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (site== null || site.IsDisposed)
            {
                site = new Site();
                site.MdiParent = this;
                site.Show();
            }
        }
        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cust == null || cust.IsDisposed)
            {
                cust = new Cust();
                cust.MdiParent = this;
                cust.Show();
            }
        }
        private void 직원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emp == null || emp.IsDisposed)
            {
                emp = new Emp();
                emp.MdiParent = this;
                emp.Show();
            }
        }
        private void 옵션관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opt == null || opt.IsDisposed)
            {
                opt = new Option();
                opt.MdiParent = this;
                opt.Show();
            }
        }
    }
}
