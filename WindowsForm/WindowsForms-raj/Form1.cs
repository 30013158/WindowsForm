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
        static int counter = 0;
        static double num1 = 0;
        static double num2 = 0;
        static string opp = "";
        static string equation = "";
        static Calculator c1 = new Calculator();
        public Form1()
        {
            
            InitializeComponent();

            lblResult.Text = "";
            equation = lblResult.Text;
        }

      

       

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 9;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 9;
                equation += $"{num2}";
            }

            lblResult.Text = equation;
            counter++;
          
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (counter == 0)

            {
                num1 = 8;
                equation += $"{num1}";
            }
            else if (counter == 1)
            {
                num2 = 8;
                equation += $"{num2}";
            
            }
            lblResult.Text = equation;
            //  lblResult.Text = num1.ToString();
            counter++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 7;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 7;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 6;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 6;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 5;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 5;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 4;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 4;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 1;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 1;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 3;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 3;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                num1 = 0;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 0;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            opp = ".";
            equation += $"{opp}";
            lblResult.Text = equation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            c1.num1 = num1;
            c1.num2 = num2;
            if(opp == "+")
            {
               equation += $" = {c1.Add().ToString()}";
                lblResult.Text = equation;
                counter = 0;
            }
            if (opp == "-")
            {    

                equation += $" = {c1.Sub().ToString()}";
                lblResult.Text = equation;
                counter = 0;
            }
            if (opp == "*")
            {
                equation += $" = {c1.Multi().ToString()}";
                lblResult.Text = equation;
                counter = 0;
            }
            if (opp == "/")
            {
                equation += $" = {c1.Divide().ToString()}";
                lblResult.Text = equation;
                counter = 0;
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            opp = "+";
            equation += $"{opp}";
            lblResult.Text = equation;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            opp = "-";
            equation += $"{opp}";
            lblResult.Text = equation;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            opp = "*";
            equation += $"{opp}";
            lblResult.Text = equation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            opp = "/";
            equation += $"{opp}";
            lblResult.Text = equation;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            { num1 = 2;
                equation += $"{num1}";
            }
            else if (counter == 1)
            { num2 = 2;
                equation += $"{num2}";
            }
            lblResult.Text = equation;
            counter++;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            opp = "";
            lblResult.Text = "Result";
            equation = "";
        }
    }
}
