using System;
using System.Windows.Forms;

namespace AddingFractions
{
    public partial class FormAddingFractions : Form
    {
        public FormAddingFractions()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a: ", "Mixed number."));
            int b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter b: ", "Mixed number."));
            int c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter c: ", "Mixed number."));

            TxtResult.Text = "The mixed number " + a + " " + b + "/" + c + " converts to improper fraction ";
            TxtResult.Text += ConvertToImproperFraction(a, b, c);
        }

        private string ConvertToImproperFraction(int a, int b, int c)
        {
            string result = "";

            int denominator = c;
            int numerator = a * c + b;
            int divisor = FindGCD(numerator, denominator);

            numerator = numerator / divisor;
            denominator = denominator / divisor;

            return result = numerator + "/" + denominator;
        }

        //Find the greatest common divisor.
        private int FindGCD(int a, int b)
        {
            int remainder = 0;
            int temp = 0;

            int number1 = Math.Abs(a);
            int number2 = Math.Abs(b);

            if (number1 < number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }

            while (true)
            {
                remainder = number1 % number2;

                if (remainder == 0)
                    break;

                number1 = number2;
                number2 = remainder;
            }

            return number2;
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a: ", "Enter a number."));
            int b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter b: ", "Enter a number."));
            int c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter c: ", "Enter a number."));
            int d = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter d: ", "Enter a number."));

            TxtResult.Text = a + "/" + b + " + " + c + "/" + d + " equals ";
            TxtResult.Text += AddFractions(a, b, c, d);

        }

        private string AddFractions(int a, int b, int c, int d)
        {
            string result;

            //The easiest way to find a common denominator between any 2 numbers is to times them together.
            //In our example we would have b * d = 4 * 8 = 32.
            //The numerator would be a * d + c * b.
            //To find the lowest terms we can divide the numerator and denumerator by the greatest common divisor.
            int denominator = b * d;
            int numerator = a * d + c * b;
            int divisor = FindGCD(numerator, denominator);

            numerator = numerator / divisor;
            denominator = denominator / divisor;

            return result = numerator + "/" + denominator;
        }


    }
}
