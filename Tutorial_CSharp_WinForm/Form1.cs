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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_clicked(object sender, EventArgs e)
        {
            // lblMyLabel.Text = "Hello World!";

            lblMyLabel.Text = txtMyTextbox.Text;
        }

        private void btnShow_clicked(object sender, EventArgs e)
        {
            txtMyTextbox.UseSystemPasswordChar = false;
        }

        private void btnHide_clicked(object sender, EventArgs e)
        {
            txtMyTextbox.UseSystemPasswordChar = true;
        }

        private void lblMyLabel_clicked(object sender, EventArgs e)
        {
            btnSubmit.Text = "lblMyLabel is clicked!";
        }

        private void btnClickMe_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me!");
        }

        private void btnMsgBoxIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me!", "My First App", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnMsgBoxButtons_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me?", "My First App", MessageBoxButtons.YesNo);
        }

        private void btnMsgBoxTitle_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You clicked me!", "My First App");
        }

        // Message, Title, button, Icon
    }
}
