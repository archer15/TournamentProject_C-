using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// represents the name of the current tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the Fee to enter the current tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of teams in the current tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Represents a list of prizes for the current tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represents the list of rounds which each team will play in. 
        /// The inside list is the teams that will play in each round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
