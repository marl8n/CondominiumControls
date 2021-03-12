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

namespace CondominiumControls.formsViews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( validateFieldsPerson())
            {
                Condominium.People.Add(
                    new models.Person(
                        tbDpi.Text,
                        tbFirstName.Text,
                        tbLastName.Text
                        )
                    ) ;
                Condominium.SavePersons();
                Condominium.GenerateReports();
                cbDpi.Items.Add(tbDpi.Text);
                clearFields();
            }
        }

        private bool validateFieldsPerson()
        {
            return !tbDpi.Text.Equals("") &&
                !tbFirstName.Text.Equals("") &&
                !tbLastName.Text.Equals("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateFieldsHouse() )
            {
                Condominium.Properties.Add(
                    new models.Property(
                        int.Parse(tbHouseNumber.Text),
                        cbDpi.Text,
                        double.Parse(tbMantainanceFee.Text)
                        )
                    );
                Condominium.SaveProperties();
                Condominium.GenerateReports();
                clearFields();
            }
        }

        private bool validateFieldsHouse()
        {
            return !cbDpi.Text.Equals("") &&
                !tbMantainanceFee.Text.Equals("") &&
                !tbHouseNumber.Text.Equals("");
        }

        private void clearFields()
        {
            this.tbDpi.Text = "";
            this.tbFirstName.Text = "";
            this.tbLastName.Text = "";
            this.cbDpi.SelectedIndex = 0;
            this.tbHouseNumber.Text = "";
            this.tbMantainanceFee.Text = "";
        }
    }
}
