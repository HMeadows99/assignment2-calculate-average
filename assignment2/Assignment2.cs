using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

/*
 * Haidan
 * Mr. Hardman 
 * Assignment #2, Calculating Averages
 * October 19 2016
 */

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double Mark1 = Convert.ToDouble(txtMark1.Text)/100;
            double Mark2 = Convert.ToDouble(txtMark2.Text)/100;
            double Mark3 = Convert.ToDouble(txtMark3.Text)/100;
            double Mark4 = Convert.ToDouble(txtMark4.Text)/100;
            double Mark5 = Convert.ToDouble(txtMark5.Text)/100;
            double Average = (Mark1 + Mark2 + Mark3 + Mark4 + Mark5) / 5.0;

            lblDisplay.Text = String.Format("{0,8}{1,13:P}\n{2,8}{3,13:P}\n{4,8}{5,13:P}\n{6,8}{7,13:P}\n{8,8}{9,13:P}\n\n{10,10}{11,10:P}",
                "Grade1:", Mark1, "Grade2", Mark2, "Grade3", Mark3, "Grade4", Mark4, "Grade5", Mark5, "Average", Average);

        }
    }
}
