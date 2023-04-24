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
        ///     The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Represents the title name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        ///     Represents the entry fee in dollars required for each team in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        ///     Represents the list of teams in the current tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        ///     Represents the prizes available to win.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        ///     Represents the list of matchup rounds for the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
