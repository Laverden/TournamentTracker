using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);
                
                GlobalConfig.Connection.CreatePrize(model);

                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool isPlaceNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);
            bool isPrizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool isPrizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            placeNumberValue.BackColor = System.Drawing.Color.White;
            placeNameValue.BackColor = System.Drawing.Color.White;
            prizeAmountValue.BackColor = System.Drawing.Color.White;
            prizePercentageValue.BackColor = System.Drawing.Color.White;

            if (!isPlaceNumberValid || placeNumber < 1)
            {
                isValid = false;
                placeNumberValue.BackColor = System.Drawing.Color.IndianRed;
            }

            if (placeNameValue.Text.Length == 0)
            {
                isValid = false;
                placeNameValue.BackColor = System.Drawing.Color.IndianRed;
            }

            if (!isPrizeAmountValid && !isPrizePercentageValid)
            {
                isValid = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                isValid = false;
                prizeAmountValue.BackColor = System.Drawing.Color.IndianRed;
                prizePercentageValue.BackColor = System.Drawing.Color.IndianRed;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                isValid = false;
                prizePercentageValue.BackColor = System.Drawing.Color.IndianRed;
            }

            return isValid;
        }
    }
}
