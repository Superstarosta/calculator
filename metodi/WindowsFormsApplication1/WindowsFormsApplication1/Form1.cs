using System;
using System.Windows.Forms;
using Calculator;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void division_Click(object sender, EventArgs e)
        {
            var calc = new Calculating();
            try
            {
                result.Text =
                    Convert.ToString(calc.Division(Convert.ToDouble(firstParameter.Text),
                        Convert.ToDouble(secondParameter.Text)));
            }
            catch (Exception)
            {
                result.Text = @"Division to zero";
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            var calc = new Calculating();
            result.Text = Convert.ToString(calc.Addition(Convert.ToDouble(firstParameter.Text), Convert.ToDouble(secondParameter.Text)));
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            var calc = new Calculating();
            result.Text = Convert.ToString(calc.Substraction(Convert.ToDouble(firstParameter.Text), Convert.ToDouble(secondParameter.Text)));
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            var calc = new Calculating();
            result.Text = Convert.ToString(calc.Multiplication(Convert.ToDouble(firstParameter.Text), Convert.ToDouble(secondParameter.Text)));
        }

        private void mod_Click(object sender, EventArgs e)
        {
            var calc = new Calculating();
            result.Text = Convert.ToString(calc.Mod(Convert.ToInt32(firstParameter.Text), Convert.ToInt32(secondParameter.Text)));
        }
    }
}
