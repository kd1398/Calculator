using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc1
{
    public partial class Calculator : Form
    {
        double f, s, result, m = 0, flag;
        string operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
               textBox2.Text = "0";
            }

            else if (flag == 1)
            {
                textBox2.Text = "0";
                flag = 0;
            }
            else
                {
                    textBox2.Text = textBox2.Text + "0";
                }
            
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else if (flag == 1)
            {
                textBox2.Text = "1";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
            
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "2";
            }
            else if (flag == 1)
            {
                textBox2.Text = "2";
                flag = 0;
            }
            else
                {
                    textBox2.Text = textBox2.Text + "2";
                }
            
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                    textBox2.Text = "3";
            }
            else if (flag == 1)
            {
                textBox2.Text = "3";
                flag = 0;
            }
            else
                {
                    textBox2.Text = textBox2.Text + "3";
                }
            
        }
        private void butt4_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else if (flag == 1)
            {
                textBox2.Text = "4";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else if (flag == 1)
            {
                textBox2.Text = "5";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else if (flag == 1)
            {
                textBox2.Text = "6";
                flag = 0;
            }

            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            

            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else if (flag == 1)
            {
                textBox2.Text = "7";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            
           if (textBox2.Text == "0" && textBox2.Text != null)
            {
               textBox2.Text = "8";
            }
           else if (flag == 1)
            {
                textBox2.Text = "8";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }          
        }

        private void butt9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }

            else if (flag == 1)
            {
                textBox2.Text = "9";
                flag = 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }
    

        private void butt_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = f * (-1);
            textBox2.Text = Convert.ToString(result);
        }
        private void buttequ_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(textBox2.Text);
            switch(operation)
            {
                case "+":
               { 
                    result = f + s;
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
               case "-":
               {
                    result = f - s;
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
               case "*":
               {
                    result = f * s;
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
               case "/":
               {
                    result = f / s;
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
               case "%":
               {
                    result = f % s;
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
               case "^":
               {
                    result = Math.Pow(f,s);
                    textBox2.Text = Convert.ToString(result);
                    f = result;
                    break;
               }
            }
        }

        private void buttsub_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "-";
        
        }

        private void buttmul_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "*";
        }

        private void buttdiv_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "/";
        }

        private void buttrem_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = Math.Floor(f / 10);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttclr_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void buttclral_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble("0");
            textBox2.Text = "";
            textBox2.Text = "0";
        }

        private void buttper_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "%";
        }

        private void buttrev_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = 1 / f;
            textBox2.Text = Convert.ToString(result);

        }

        private void buttsqr_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = Math.Sqrt(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttsq_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = f * f;
            textBox2.Text = Convert.ToString(result);
        }

        private void buttmr_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(m);
        }

        private void buttmsub_Click(object sender, EventArgs e)
        {
            flag = 1;
            f = Convert.ToDouble(textBox2.Text);
            m = m - f;
        }
        private void buttms_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            m = f;
        }

        private void buttcos_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            result = Math.Cos(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttsin_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Sin(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void butttan_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Tan(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void butt10x_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Pow(10,f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttlog_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Log10(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttln_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Log(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttexp_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Exp(f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttxy_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "^";
        }

        private void buttex_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Pow(Math.E,f);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttlb_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.PI;
            textBox2.Text = Convert.ToString(result);
        }

    

        private void buttx3_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox2.Text);
            result = Math.Pow(f,3);
            textBox2.Text = Convert.ToString(result);
        }

        private void buttpi_Click(object sender, EventArgs e)
        {


            f = Convert.ToDouble(textBox2.Text);
            result = Math.PI;
            textBox2.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttmc_Click(object sender, EventArgs e)
        {
            m = 0;

        }
        private void buttMplus_Click(object sender, EventArgs e)
        {
            flag = 1;
            f = Convert.ToDouble(textBox2.Text);
            m = m + f;
        }
        private void buttdot_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==".")
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + ".";
            }
        }
        private void buttplus_Click(object sender, EventArgs e)
        {

            f=Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            operation = "+";
        }
    }
}
