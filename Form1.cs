using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CondominiumControls.contorls.Condominium;

namespace CondominiumControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrderByFee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsByProperty.OrderBy(p => p.ManteinanceFee);
        }

        private void btnMostProperties_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsByPerson.OrderBy(p => p.QuantityOfProperties);
        }

        private void btnByMantainanceTop_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsByProperty.OrderBy(p => p.ManteinanceFee);
        }

        private void btnOrderByMaintainanceBottom_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsByProperty.OrderBy(p => p.ManteinanceFee).Reverse();
        }

        private void btnMostMantainanceFee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsByPerson.OrderBy(p => p.TotalManteinanceFee);
        }
    }
}
