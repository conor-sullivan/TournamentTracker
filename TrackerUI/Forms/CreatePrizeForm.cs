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

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        ///     When "Create Prize" button is clicked, the inputs get added to a new Prize Model.
        ///     The Prize Model attributes get validated for data types.
        ///     If the data inside the Prize Model is valid, the Prize Model gets saved in the database.
        ///     The form fields are cleared so another prize can be created.
        ///     If the Prize Model contained invalid data, a message box informs the user to correct the data and try again.
        /// </summary>

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);
               
                GlobalConfig.Connection.CreatePrize(model);
                
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        /// <summary>
        ///     Attempts to convert Prize Model attributes to specific data types.
        ///     Verifies there are no null values.
        ///     Verifies values are within logical ranges.
        /// </summary>
        /// <returns>
        ///     True if data is acceptable. False if data is not acceptable.
        /// </returns>

        private bool ValidateForm()
        {
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (
                !placeNumberValidNumber
                || placeNumber < 1
                || placeNameValue.Text.Length == 0
                || !prizeAmountValid
                || !prizePercentageValid
                || prizeAmount <= 0 && prizePercentage <= 0
                || prizePercentage < 0
                || prizePercentage > 100
                )
            {
                return false;
            }
            return true;
        }

        private void prizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
