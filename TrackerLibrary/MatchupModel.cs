using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{    /// <summary>
    /// Represents one match in the Tournament.
    /// </summary>
    public class MatchUpModel
    {
        /// <summary>
        /// Set of teams involved/involve in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this team came from.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
