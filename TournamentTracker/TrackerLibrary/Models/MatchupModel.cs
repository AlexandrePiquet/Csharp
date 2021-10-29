using System;
using System.Collections.Generic;

namespace TrackerLibrary.models
{
    public class MatchupModel
    {
        /// <summary>
        /// <list type="id for the matchup"
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match
        /// </summary>
        /// <value>The entries.</value>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// The id from the database that will be used to identify the winner
        /// </summary>
        /// <value>The winner identifier.</value>
        public int WinnerId { get; set; }

        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";

                foreach(MatchupEntryModel me in Entries)
                {
                    if me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined.";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
