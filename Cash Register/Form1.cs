using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double drinkPrice = 4.50;
        double numOfDrinks = 0;
        double pasteryPrice = 2.75;
        double numOfPasteries = 0;
        double sandwichPrice = 4.50;
        double numOfSandwiches = 0;
        double taxRate = 0.13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double tenderedAmount = 0;
        double changeRequired = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Inputs
                numOfDrinks = Convert.ToDouble(drinkInput.Text);
                numOfPasteries = Convert.ToDouble(pasteryInput.Text);
                numOfSandwiches = Convert.ToDouble(sandwichInput.Text);

                //calculations
                subtotal = (drinkPrice * numOfDrinks) + (sandwichPrice * numOfSandwiches) + (pasteryPrice * numOfPasteries);
                taxAmount = subtotal * taxRate;
                totalPrice = subtotal + taxAmount;

                //output
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalPrice.ToString("C")}";

            }
            catch
            {
                subtotalOutput.ForeColor = Color.Red;
                subtotalOutput.Text = "Input Error";
                taxOutput.Text = "Input Error";
                taxOutput.ForeColor = Color.Red;
                totalOutput.Text = "Input Error";
                totalOutput.ForeColor = Color.Red;
            }

            }

        private void tenderedButton_Click(object sender, EventArgs e)
        {
            tenderedAmount = Convert.ToDouble(tenderedInput.Text);

            changeRequired = tenderedAmount - totalPrice;

           tenderedOutput.Text = $"{tenderedAmount.ToString("C")}";


        }
    }
}
  