using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        ///     The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Represents the numbered position the team placed in the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        ///     Represents the text version of the position the team placed.
        ///     First, Second, Champion, Runner Up, etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        ///     Represents the prize amount in dollars.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        ///     Represents the prize amount percentage of total.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

        /// <summary>
        ///     Necessary blank constructor
        /// </summary>
        public PrizeModel()
        {
        }
    }
}
