using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{   /// <summary>
    /// Represents a single prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The corresponding number for a rank.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The corresponding name for a rank eg: 1st place, 2nd place etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount awarded to a specific rank.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage by which seperates the total reward for a
        /// specific rank.
        /// </summary>
        public decimal PrizePercentage { get; set; }
    }
}
