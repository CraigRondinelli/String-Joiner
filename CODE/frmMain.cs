using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Craig Rondinelli
// CIS 202 - CODE

//User enters an item into each textbox
//Joins strings together on button click
//Outputs result in bottom textbox

namespace CODE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Titles the window upon opening.

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Craig Rondinelli"; 
        }

        //Combines user inputted text using variables and outputs into textbox.

        private void butnJoin_Click(object sender, EventArgs e)
        {
            string str1, str2, strOut; //Declares variables
            str1 = txtIn1.Text;
            str2 = txtIn2.Text;       //Defines variables
            strOut = str1 + str2;
            txtOut.Text = str1 + " + " + str2 + " = " + strOut; // Outputs user entered text and outcome into textbox using variables
        }

        // Clears all text from boxes

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIn1.Clear();
            txtIn2.Clear(); 
            txtOut.Clear();
        }

        //Exits program

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
