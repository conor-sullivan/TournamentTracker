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
        ///     Represents the list of team matchups for a given round.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        ///     Represents which team won the round.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        ///     Represents the number of the round.
        /// </summary>
        public int MatchRound { get; set; }
    }

}
