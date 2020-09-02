using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{    /// <summary>
    /// Represents a single tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The cost of entering a specific tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents total number of teams in a specific tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents total prizes for a specific rank.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the total amount of rounds within a specific matchup.
        /// </summary>
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();
    }
}
