using System;

namespace BinaryDigitCalculator
{
    public partial class Form1 : Form
    {
        int decimalValue = 0;
        int[] binaryValue = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void calcCheckBoxValueToDecimal(CheckBox chk)
        {
            int value = int.Parse(chk.Text);
            int checkBoxChecked = Convert.ToInt32(chk.Checked);
            int pos = value * checkBoxChecked;

            if (checkBoxChecked == 0) 
            {
                decimalValue -= value;
                binaryValue[binaryValue.Length - chk.TabIndex] = checkBoxChecked;
                lblDecimal.Text = decimalValue.ToString();
                lblBinary.Text = $"{string.Join("", binaryValue)}";
                return;
            }

            decimalValue += pos;
            binaryValue[binaryValue.Length - chk.TabIndex] = checkBoxChecked;
            lblDecimal.Text = decimalValue.ToString();
            lblBinary.Text = $"{string.Join("", binaryValue)}";
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            calcCheckBoxValueToDecimal((CheckBox)sender);
        }

    }
}