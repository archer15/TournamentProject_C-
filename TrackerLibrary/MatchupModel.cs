using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams playing in the current round
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the current round
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the current round number
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
