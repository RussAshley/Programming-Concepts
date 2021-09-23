using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Concepts
{
    public partial class LandingForm : Form
    {
        public  LandingForm()
        {
            InitializeComponent();
        }

        private void CommonButton_Click(object sender, EventArgs e)
        {
            CommonForm commonForm = new CommonForm();
            commonForm.Show();
          //  LandingForm.Hide();
        }

        private void OOPButton_Click(object sender, EventArgs e)
        {
            OOPForm oopForm = new OOPForm();
            oopForm.Show();
         //   LandingForm.Hide();
        }
    }
}
