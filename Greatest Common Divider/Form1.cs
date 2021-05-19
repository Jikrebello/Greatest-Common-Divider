using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Greatest_Common_Divider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Question 1
        private void BtnGreatestCommonDivider_Click(object sender, EventArgs e)
        {
            int numerator = Convert.ToInt32(Interaction.InputBox("Enter the Numerator", "Numerator"));
            int denominator = Convert.ToInt32(Interaction.InputBox("Enter the Denominator", "Denominator"));

            MessageBox.Show("The greatest Common Divider of " + numerator + " and " + denominator + " is " + GreatestCommonDivider(numerator, denominator));
        }
        private int GreatestCommonDivider(int _numerator, int _denominator)
        {
            int _temp;
            int remainder;

            // check and fix the order of the numerator and denominator if typed incorrectly
            if (_denominator < _numerator)
            {
                _temp = _numerator;
                _numerator = _denominator;
                _denominator = _temp;
            }

            // do the euclid algorithm
            while (true)
            {
                remainder = _numerator % _denominator;
                if (remainder == 0)
                    break;

                _numerator = _denominator;
                _denominator = remainder;
            }

            return _denominator;

        }

        // Question 2
        private void BtnMixedToImproper_Click(object sender, EventArgs e)
        {
            int wholeNumber = Convert.ToInt32(Interaction.InputBox("Enter the Whole Number", "Whole Number"));
            int numerator = Convert.ToInt32(Interaction.InputBox("Enter the Numerator", "Numerator"));
            int denominator = Convert.ToInt32(Interaction.InputBox("Enter the Denominator", "Denominator"));

            MessageBox.Show("The mixed fraction of " + wholeNumber + ", " + numerator + " and " + denominator + " is " + MixedToImproper(wholeNumber, numerator, denominator) + " over " + denominator);

        }
        private int MixedToImproper(int _wholeNumber, int _numerator, int _denominator)
        {
            return _ = _denominator * _wholeNumber + _numerator;
        }

        // Question 3
        private void BtnLowestFormFractions_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(Interaction.InputBox("Enter the First Numbers' Numerator", ""));
            int y1 = Convert.ToInt32(Interaction.InputBox("Enter the First Numbers' Denominator", ""));
            
            int x2 = Convert.ToInt32(Interaction.InputBox("Enter the Second Numbers' Denominator", ""));
            int y2 = Convert.ToInt32(Interaction.InputBox("Enter the Second Numbers' Denominator", ""));

            MessageBox.Show(AddingFractions(x1, y1, x2, y2));

        }
        private string AddingFractions(int _a, int _b, int _c, int _d)
        {
            int x = (_a * _d) + (_b * _c);
            int y = _b * _d;

            return _ = "The added fraction is " + x / GreatestCommonDivider(x, y) + "/" + y / GreatestCommonDivider(x, y);
        }

    }
}
