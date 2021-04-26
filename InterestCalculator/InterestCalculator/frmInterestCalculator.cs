using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class frmInterestCalculator : Form
    {
        public frmInterestCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            InterestCalculator totalInterest = new InterestCalculator();
            lblTotalInterest.Text = "Total Interest is " + totalInterest.TotalInterest(Convert.ToDecimal(txtEnterAmount.Text));
        }
    }
}
