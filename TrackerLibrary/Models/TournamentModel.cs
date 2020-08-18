using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name or type of the tournament 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee to participate in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the teams participating in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the prizes offered in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the rounds in the tournament.
        /// </summary>
        public List<List<MatchModel>> Rounds { get; set; } = new List<List<MatchModel>>();
    }
}
