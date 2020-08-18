using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchModel
    {
        /// <summary>
        /// Represents the teams facing each other in the match.
        /// </summary>
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        /// <summary>
        /// Represents the winner team of this match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round number.
        /// </summary>
        public int MatchRound { get; set; }
    }
}
