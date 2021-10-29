using System;

namespace TrackerLibrary.models
{
    public class PrizeModel
    {
        /// <summary>
        /// <list type="'identifiant du prix"
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the place number.
        /// </summary>
        /// <value>The place number.</value>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the place.
        /// </summary>
        /// <value>The name of the place.</value>
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or sets the price amount.
        /// </summary>
        /// <value>The price amount.</value>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Gets or sets the prize percentage.
        /// </summary>
        /// <value>The prize percentage.</value>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

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
    }
}
