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
    public partial class frmDay2 : Form
    {
        public frmDay2()
        {
            InitializeComponent();
        }

        //public string globalVariable = "This is a global variable";
        //private string localVariable = "This is a local variable";


        private int counter = 0; // Local Variable

        private string input = string.Empty;

        // Global Variable  = Class Variable | Pwedeng gamitin ng lahat | PUBLIC
        // Local Variable   = Class Variable | Pwedeng gamitin ng lahat | PRIVATE
        // Method Variable  = Variable na nasa loob ng Method | Di pwede gamitin ng iba | PRIVATE

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // string, char, bool, int, float, double, decimal
            // datatype variableName = value;
            //string name = "John Doe";
            //char grade = 'A';
            //int age = 30;
            //float height = 5.9f;
            //double weight = 160.5D;
            //decimal gpa = 3.75M;

            MessageBox.Show($"Counter Value: {counter}");
        }

        private void frmDay2_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Counter Value: {counter}");
        }

        private void btnCounterPlus1_Click(object sender, EventArgs e)
        {
            counter++;
        }

        private void btnMethodVariable_Click(object sender, EventArgs e)
        {
            counter = 0;
            MessageBox.Show($"Method Counter Value: {counter}");
        }

        private void btnNewSubmit_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            MessageBox.Show($"Input Value: {input}");
            txtInput.Clear();
        }

        private void btnCallVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Input Value: {input}");
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string greetings = "HELLO WORLD";
            string result = greetings.Substring(4,7);

            // RefID = Category + Year + Month + Day + Series(uniqueID)
            string refID = "ITM123261232123123200001";
            string getYear = refID.Substring(3,4);
            //string getSeries = refID.Substring(11, 5);

            // Length
            string sampleText = "HELLO WORLD!";
            int sampleTextlength = sampleText.Length;

            string getRefSeries = refID.Substring(refID.Length - 5);

            MessageBox.Show($"Lenth of sampleText: {getRefSeries}");
        }

        // void = method na walang return type
        // Function | return type = string, int, bool, char, float, double, decimal
        private bool conversion()
        {
            /* ==================================================================================
             * String to Integer
             * variable string then gagawing integer
             * int.parse(stringVariable)
             */

            /* OPERATIONS   | ASSIGNMENT
             * + - / * % == | =
             * 
             * string + any data type (converted automatically to string)
             * string + string = stringstring / Concat
             * int + int = total/sum
             * 
             * data conversion
             * datatypes.Parse(value to convert)
             * 
             * any datatypes converted to string
             * value to convert.ToString()
             */

            bool result = true;

            string strNumber = "1";
            int intNumber = int.Parse(strNumber);

            //result = intNumber + 1;

            // boolean sa status 'active or inactive
            // isDeleted = 1/0 | True/False
            // isArchived = 1/0
            // if (isDelete = 1) { True} else {false} 
            // Flagging | loops

            return result;
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{conversion()}");
        }


        /* ==================================================================================
         *  OVER WRITING 
         * VALUE : 1 
         * value : 2
         * ==================================================================================
         * STRING OPS
         * CONCATENATION | pag add ng mga text gamit '+' 
         * SUBSTRING     | pagkuha ng parte ng string gamit 'Substring(startIndex, length)'
         * 
         * string greetings = "HELLO WORLD";
         * string HelloLang = greetings.Substring(0,5);
         * 
         * 
         * 
         * string, char, bool, int, float, double, decimal
         * 
         * 
         * 
        */

    }
}
