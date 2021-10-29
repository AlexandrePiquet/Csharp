using System;

namespace TrackerLibrary.models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// <list type="id for the matchup"
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }

        /// <summary>
        /// The unique id for the team
        /// <value>The team competing.</value>

        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one team in the matchup
        /// <value>The team competing.</value>

        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// <value>The score.</value>

        public double Score { get; set; }

        /// <summary>
        /// The unique id for the parent matchup (team)
        /// <value>The team competing.</value>

        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// <value>The parent matchup.</value>

        public MatchupModel ParentMatchup { get; set; }

    }
}
