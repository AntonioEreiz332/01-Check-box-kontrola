using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkboxkontrola01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtIspis.Text = "Odabrali ste: "+System.Environment.NewLine;
            if (boxDorucak.Checked)
            {
                txtIspis.Text +=
                    "dorucak" +System.Environment.NewLine;
            }
            if (boxRucak.Checked) { txtIspis.Text += "rucak" + System.Environment.NewLine; };
            if (boxVecera.Checked) { txtIspis.Text += "vecera" + System.Environment.NewLine; };

        }

        private void boxSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSakrij.Checked)
            {
                txtIspis.Hide();
            }
            else { txtIspis.Show(); }
            
        }
    }
}
