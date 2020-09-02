using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a specific Team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents total amount of participant within a specific team.  
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// The name of a specific team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
