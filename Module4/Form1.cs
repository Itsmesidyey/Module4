/*
* Module 4: Assesstment
* Casinsinan, Cj C.
* BSCS 3-1N
*/

using System.Linq.Expressions;

namespace Module4

{
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void label1 (object sender, EventArgs e)
        {

        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNum.Text);
                double secondNumber = Convert.ToDouble(txtSecondNum.Text);
                double result = firstNumber + secondNumber;

                txtResult.Text = Convert.ToString("The answer is " + result);
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't entered a valid number in this text box!");
        }
    }

        public void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNum.Text);
                double secondNumber = Convert.ToDouble(txtSecondNum.Text);
                double result = firstNumber - secondNumber;

                txtResult.Text = Convert.ToString("The answer is " + result);
            }
            catch (Exception)  
            {
                MessageBox.Show("You haven't entered a valid number in this text box!");
        }
    }

        public void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNum.Text);
                double secondNumber = Convert.ToDouble(txtSecondNum.Text);
                double result = firstNumber * secondNumber;

                txtResult.Text = Convert.ToString("The answer is " + result);
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't entered a valid number in this text box!");
        }
    }

        public void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNum.Text);
                double secondNumber = Convert.ToDouble(txtSecondNum.Text);

                if (secondNumber == 0)
                {
                    MessageBox.Show("    Invalid! Cannot divide by zero");
                }
                else
                {
                    double result = firstNumber / secondNumber;
                    txtResult.Text = Convert.ToString("The answer is " + result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't entered a valid number in this text box!");
            }
        }

        private void Arithmetic_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstNum_Click(object sender, EventArgs e)
        {

        }
    }
}