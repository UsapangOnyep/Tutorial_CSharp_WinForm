using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_CSharp_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BTN Submit
            lblName.Text = txtName.Text;
            lblAddress.Text = txtAddress.Text;
            lblAge.Text = txtAge.Text;

            MessageBox.Show(
                "Information Submitted Successfully!",      // message
                "Success",                                  // title
                MessageBoxButtons.OK,                       // buttons
                MessageBoxIcon.Information                  // icon
            );
        }

        // BTN Change Color to Black
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Black;
        }


    }
}
