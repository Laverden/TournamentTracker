using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier of the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The numeric identifier for the place.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The friendly name for the place (second, first runner up, etc.)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// A fixed amount given to this place, zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// A percentual value of the overall take given to this place, zero if it
        /// is not used. The percentual value is a fraction of 1.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            PlaceName = placeName;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
