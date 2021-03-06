﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
    {   /// <summary>
        /// Represents one team in the entire matchup.
        /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the entire matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup this team came from
        /// </summary>
        public MatchUpModel ParentMatchup { get; set; }
    }
}
