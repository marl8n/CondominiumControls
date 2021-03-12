using CondominiumControls.contorls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiumControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Condominium.GenerateReports();
            dataGridView1.DataSource = Condominium.ReportsByProperty.OrderBy(p => p.ManteinanceFee).ToArray();
        }

        private void btnOrderByFee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Condominium.ReportsByProperty.OrderBy(p => p.ManteinanceFee);
        }

        private void btnMostProperties_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Condominium.ReportsByPerson.OrderBy(p => p.QuantityOfProperties);
        }

        private void btnByMantainanceTop_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Condominium.ReportsByProperty.OrderBy(p => p.ManteinanceFee);
        }

        private void btnOrderByMaintainanceBottom_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Condominium.ReportsByProperty.OrderBy(p => p.ManteinanceFee).Reverse();
        }

        private void btnMostMantainanceFee_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Condominium.ReportsByPerson.OrderBy(p => p.TotalManteinanceFee);
        }

        private void btnAddPersonOrProperty_Click(object sender, EventArgs e)
        {
            formsViews.Form1 form = new formsViews.Form1();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
