using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// by Mark Hawes
// WebAddress program
// Week 5
// form programming, refer to Program.cs for more of the actual code

namespace WebAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create a new WebAddressConverter to use for program
        // definitely not the most efficient way to do this
        WebAddressConverter converto = new WebAddressConverter();

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // users converto to convert company name into web address
            OutputLabel.Text = converto.WebConverter(UserInputBox.Text);
        }
    }
}
