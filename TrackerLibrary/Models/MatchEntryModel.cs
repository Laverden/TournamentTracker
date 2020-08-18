using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchEntryModel
    {
        /// <summary>
        /// Represents one team in the match.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the match that this team came from as the winner.
        /// </summary>
        public MatchModel ParentMatch { get; set; }
    }
}
