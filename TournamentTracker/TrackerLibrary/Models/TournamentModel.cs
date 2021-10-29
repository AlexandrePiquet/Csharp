using System;
using System.Collections.Generic;

namespace TrackerLibrary.models
{
    public class TournamentModel
    {
        public event EventHandler<TournamentModel> OnTournamentComplete;

        /// <summary>
        /// <list type="'identifiant du tournoi"
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }

        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }

    }
}
