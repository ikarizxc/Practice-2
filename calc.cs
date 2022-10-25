using System;
using System.Windows.Forms;
using System.Drawing;

namespace calc
{
    public partial class calc : Form
    {
        private int number1;
        private int number2;

        public calc()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(number1 + number2);
        }
        private void subtraction_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(number1 - number2);
        }
        private void multiplication_Click(object sender, EventArgs e)
        {
            result.Text = Convert.ToString(number1 * number2);
        }
        private void division_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
                result.Text = Convert.ToString(Convert.ToDouble(number1) / number2);
            else
            {
                MessageBox.Show("Division by 0 isn't possible!");
            }
        }
        private void num1_TextChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(num1.Text);
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(num2.Text);
        }
    }
}
