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
    public partial class Reserv : Form
    {
        public Reserv()
        {
            InitializeComponent();
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            ReservOption reservOpt = new ReservOption();
            reservOpt.Show();
        }
    }
}
