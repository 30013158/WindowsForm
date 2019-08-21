using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm;

namespace WindowsForms_raj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Calculator c1 = new Calculator();
            lblResult.Text = c1.num1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
