using System;
using System.Windows.Forms;

namespace GodziszJ_BudgetCalc
{
    public partial class monthlyBudget : Form
    {
        public monthlyBudget()
        {
            InitializeComponent();
        }
        //accidental double click
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            //set constant variables for budgeting maximums
            const decimal MaxRent = 775.00m;
            const decimal MaxPower = 275.00m;
            const decimal MaxCable = 60.50m;
            const decimal MaxCarPayment = 325.00m;
            const decimal MaxInsurance = 125.76m;
            const decimal MaxGrocery = 300.00m;
            const decimal MaxMisc = 100.00m;
            const decimal TotalBudget = MaxRent + MaxPower + MaxCable + MaxCarPayment + MaxInsurance + MaxGrocery + MaxMisc;

            //set variables for inputs to zero
            decimal Rent = 0m;
            decimal Power = 0m;
            decimal Cable = 0m;
            decimal CarPayment = 0m;
            decimal Insurance = 0m;
            decimal Grocery = 0m;
            decimal Misc =0m;
            decimal TotalExpenses = 0m;
            
            //try statment to validate values
            try
            {
                //assigning inputs to variables
                Rent = decimal.Parse(rentTextBox.Text);
                Power = decimal.Parse(PowerTextBox.Text);
                Cable = decimal.Parse(cableTextBox.Text);
                CarPayment = decimal.Parse(carPaymentTextBox.Text);
                Insurance = decimal.Parse(insuranceTextBox.Text);
                Grocery = decimal.Parse(groceryTextBox.Text);
                Misc = decimal.Parse(miscTextBox.Text);

                //total formulas
                TotalExpenses = Rent + Power + Cable + CarPayment + Insurance + Grocery + Misc;
                

                //formulas for calculations of all outputs
                decimal RemainderOfRent = MaxRent - Rent;
                decimal RemainderOfPower = MaxPower - Power;
                decimal RemainderOfCable = MaxCable - Cable;
                decimal RemainderOfCarPayment = MaxCarPayment - CarPayment;
                decimal RemainderOfInsurance = MaxInsurance - Insurance;
                decimal RemainderOfGrocery = MaxGrocery - Grocery;
                decimal RemainderOfMisc = MaxMisc - Misc;
                decimal RemainderOfTotalBudget = TotalBudget - TotalExpenses;

                //display over/under budget amounts
                rentBudgetOutput.Text = RemainderOfRent.ToString("c");
                PowerBudgetOutputLabel.Text = RemainderOfPower.ToString("c");
                CableBudgetOutputLabel.Text = RemainderOfCable.ToString("c");
                CarPayBudgetOutputLabel.Text = RemainderOfCarPayment.ToString("c");
                insuranceBudgetOutputLabel.Text = RemainderOfInsurance.ToString("C");
                GroceryBudgetOutputLabel.Text = RemainderOfGrocery.ToString("c");
                MiscBudgetOutputLabel.Text = RemainderOfGrocery.ToString("c");

                //display total expenses
                expenseTotalOutputLabel.Text = TotalExpenses.ToString("c");

                //statements to change colors

                //Rent
                if (RemainderOfRent >= 0)
                {
                    //Change Color to a lime green
                    rentBudgetOutput.ForeColor = System.Drawing.Color.Lime;
                    
                }
                else
                {
                    //Change color to red
                    rentBudgetOutput.ForeColor = System.Drawing.Color.Red;
                }

                //Power
                if (RemainderOfPower >= 0)
                {
                    //Change Color to lime green
                    PowerBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    PowerBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Cable
                if (RemainderOfCable >= 0)
                {
                    //Change Color to lime green
                    CableBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    CableBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Car Payment
                if (RemainderOfCarPayment >= 0)
                {
                    //Change Color to lime green
                    CarPayBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    CarPayBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Insurance
                if (RemainderOfInsurance >= 0)
                {
                    //Change Color to lime green
                    insuranceBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    insuranceBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Grocery
                if (RemainderOfGrocery >= 0)
                {
                    //Change Color to lime green
                    GroceryBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    GroceryBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Misc
                if (RemainderOfMisc >= 0)
                {
                    //Change Color to lime green
                    MiscBudgetOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    MiscBudgetOutputLabel.ForeColor = System.Drawing.Color.Red;
                }

                //Statement for total to display
                if (TotalExpenses >= 0)
                {
                    //Change Color to lime green
                    expenseTotalOutputLabel.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    //Change color to red
                    expenseTotalOutputLabel.ForeColor = System.Drawing.Color.Red;
                }
    
                     if (RemainderOfTotalBudget >= 0)
                     {
                        //Display Congratulation message
                         budgetTotalOutputLabel.Text = ("Congratulations! you are ") + RemainderOfTotalBudget.ToString("c")
                             + (" under budget!");

                        //diplay in lime
                        budgetTotalOutputLabel.ForeColor = System.Drawing.Color.Lime;
                     }

                     else
                     {
                        //Display over budget message
                        budgetTotalOutputLabel.Text = ("You are ") + RemainderOfTotalBudget.ToString("c") + (" over budget.");
                        //Display in red
                        budgetTotalOutputLabel.ForeColor = System.Drawing.Color.Red;
                     }


            }
            //catch statment for invalid inputs
            catch
            {
                MessageBox.Show("Please input valid amounts");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all textboxes
            rentTextBox.Text = ("");
            PowerTextBox.Text = ("");
            cableTextBox.Text = ("");
            carPaymentTextBox.Text = ("");
            insuranceTextBox.Text = ("");
            groceryTextBox.Text = ("");
            miscTextBox.Text = ("");

            //clear all output labels
            expenseTotalOutputLabel.Text = ("");
            rentBudgetOutput.Text = ("");
            PowerBudgetOutputLabel.Text = ("");
            CableBudgetOutputLabel.Text = ("");
            CarPayBudgetOutputLabel.Text = ("");
            insuranceBudgetOutputLabel.Text = ("");
            GroceryBudgetOutputLabel.Text = ("");
            MiscBudgetOutputLabel.Text = ("");
            budgetTotalOutputLabel.Text = ("");


            //set focus to rent text box
            rentTextBox.Focus();
            
            



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
    }
}
