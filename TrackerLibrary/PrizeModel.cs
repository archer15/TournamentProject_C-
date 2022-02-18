using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the finishing position
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the finishing position
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of money for the current finishing position
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of money for the position out of the total prizepool.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
