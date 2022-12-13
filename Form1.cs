using System.Reflection.Metadata.Ecma335;

namespace CS311_FinalProject_Zts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertUnits();
        }
    
        private void ConvertUnits()
        {
            double input = double.Parse(txtInput.Text);
            double output;
            if (rdoCon1.Checked) 
            {
                output = input * 3.28084;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon2.Checked)
            {
                output = input * .3048;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon3.Checked)
            {
                output = input * 0.6213711922;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon4.Checked)
            {
                output = input * (1.609344);
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon5.Checked)
            {
                output = (input * (1.8))+32;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon6.Checked)
            {
                output = (input - 32) * 5/9;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon7.Checked)
            {
                output = input * 2.20462;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon8.Checked)
            {
                output = input * .453592;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon9.Checked)
            {
                output = input * .035274;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
            else if (rdoCon10.Checked)
            {
                output = input * 28.3495;
                double rounded = Math.Round((Double)output, 6);
                txtOutput.Text = rounded.ToString();
            }
        }

        private void rdoCon1_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Meters";
            txtUnit2.Text = "Feet";
        }

        private void rdoCon2_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Feet";
            txtUnit2.Text = "Meters";
        }

        private void rdoCon3_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Kilometers";
            txtUnit2.Text = "Miles";
        }

        private void rdoCon4_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Miles";
            txtUnit2.Text = "Kilometers";
        }

        private void rdoCon5_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Celsious";
            txtUnit2.Text = "Fahrenheit";
        }

        private void rdoCon6_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Fahrenheit";
            txtUnit2.Text = "Celsious";
        }

        private void rdoCon7_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Kilograms";
            txtUnit2.Text = "Pounds";
        }

        private void rdoCon8_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Pounds";
            txtUnit2.Text = "Kilograms";
        }

        private void rdoCon9_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Grams";
            txtUnit2.Text = "Ounces";
        }

        private void rdoCon10_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit1.Text = "Ounces";
            txtUnit2.Text = "Grams";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.ResetText();
            txtOutput.ResetText();
        }
    }
}